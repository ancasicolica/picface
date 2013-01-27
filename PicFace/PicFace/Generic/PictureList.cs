/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2011 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

      LICENSE TERMS

       The redistribution and use of this software (with or without changes)
       is allowed without the payment of fees or royalties provided that:

        1. source code distributions include the above copyright notice, this
           list of conditions and the following disclaimer; 

        2. binary distributions include the above copyright notice, this list
           of conditions and the following disclaimer in their documentation;

        3. the name of the copyright holder is not used to endorse products
           built using this software without specific written permission.

       DISCLAIMER

       This software is provided 'as is' with no explicit or implied warranties
       in respect of its properties, including, but not limited to, correctness
       and/or fitness for purpose. 
*/
/************************************************************************************/
using System;
using System.Collections.Generic;
using Kusti.PicFaceLib.ExifTool;
using System.Diagnostics;

namespace Kusti.PicFaceLib.Generic
{
   #region OnPictureListSavedEventArgs
   /// <summary>
   /// Event args when saved
   /// </summary>
   internal class OnPictureListSavedEventArgs
   {
      /// <summary>
      /// Output of the tool when saving data
      /// </summary>
      public string Result { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="output"></param>
      public OnPictureListSavedEventArgs(string output)
      {
         Result = output;
      }
   }
   #endregion
   #region OnPictureSavedEventArgs
   /// <summary>
   /// Event args when saved
   /// </summary>
   internal class OnPictureSavedEventArgs
   {
      /// <summary>
      /// How many percents (from 0 to 100) are done?
      /// </summary>
      public int PercentDone { get; private set; }
      /// <summary>
      /// Name of the last file saved
      /// </summary>
      public string FileName { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="output"></param>
      public OnPictureSavedEventArgs(string filename, int percentDone)
      {
         FileName = filename;
         if (percentDone >= 0 && percentDone <= 100)
         {
            PercentDone = percentDone;
         }
         else
         {
            PercentDone = 0;
         }
      }
   }
   #endregion
   /// <summary>
   /// This class contains all pictures of a directory 
   /// </summary>
   internal class PictureList
   {
      #region Fields
      private PictureInfoList _ExifPictures;
      private Dictionary<string, PictureComparer> _ConsolidatedList;
      private Dictionary<string, PictureComparer> _ChangesPendingList;
      private string _Path;
      private string _SaveResult;
      private int _NumberOfPicturesToSave;
      private int _TotalNumberOfPictures;
      private Queue<PictureComparer> _PicturesToSave;
      #endregion
      /// <summary>
      /// Delegate for event after data was saved
      /// </summary>
      /// <param name="sender">Sender object</param>
      /// <param name="args">Result of saving</param>
      public delegate void OnSaved(object sender, OnPictureListSavedEventArgs args);
      /// <summary>
      /// Event after data was saved
      /// </summary>
      public event OnSaved Saved;
      /// <summary>
      /// Delegate for event after data for a single picturewas saved
      /// </summary>
      /// <param name="sender">Sender object</param>
      /// <param name="args">Result of saving</param>
      public delegate void OnPictureSaved(object sender, OnPictureSavedEventArgs args);
      /// <summary>
      /// Event after data of a single picture was saved
      /// </summary>
      public event OnPictureSaved PictureSaved;
      /// <summary>
      /// Path where the pictures were found
      /// </summary>
      public string Path
      {
         get
         {
            return _Path;
         }
      }
      /// <summary>
      /// Exif Pictures
      /// </summary>
      public PictureInfoList ExifPictures
      {
         get
         {
            return _ExifPictures;
         }
      }
      /// <summary>
      /// List containing every picture with a face in it, not depending if the source was picasa or exif
      /// </summary>
      public Dictionary<string, PictureComparer> ConsolidatedList
      {
         get
         {
            return _ConsolidatedList;
         }
      }
      /// <summary>
      /// List all pictures with pending changes (Data in picasa and XMP different, needed to save)
      /// </summary>
      public Dictionary<string, PictureComparer> ChangesPendingList
      {
         get
         {
            return _ChangesPendingList;
         }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="path">Path where the pictures are</param>
      public PictureList(string path)
      {
         
         _Path = path;

         _ExifPictures = new PictureInfoList(path);
         _ConsolidatedList = new Dictionary<string, PictureComparer>();
         _ChangesPendingList = new Dictionary<string, PictureComparer>();

         // now add all pictures having exiftool information
         foreach (KeyValuePair<string, PictureInfo> entry in _ExifPictures)
         {
            if (_ConsolidatedList.ContainsKey(entry.Key))
            {
               _ConsolidatedList[entry.Key].ExifInfo = entry.Value as ExifPictureInfo;
               _ConsolidatedList[entry.Key].CheckPics();
            }
            else
            {
               PictureComparer pc = new PictureComparer();
               pc.ExifInfo = entry.Value as ExifPictureInfo;
               pc.CheckPics();
               _ConsolidatedList.Add(entry.Key, pc);
            }
         }
         // setup the changes pending list
         foreach (KeyValuePair<string, PictureComparer> kvp in _ConsolidatedList)
         {
            if (kvp.Value.ExifUpdateNeeded)
            {
               _ChangesPendingList.Add(kvp.Key, kvp.Value);
            }
         }
      }
      /// <summary>
      /// Save all changed data
      /// </summary>
      public void SaveChangedData()
      {
         _SaveResult = "";
         _NumberOfPicturesToSave = 0;
         _PicturesToSave = new Queue<PictureComparer>();
         foreach (KeyValuePair<string, PictureComparer> kvp in _ChangesPendingList)
         {
            _NumberOfPicturesToSave++;
            kvp.Value.Saved += new PictureComparer.OnSaved(Value_Saved);
            _PicturesToSave.Enqueue(kvp.Value);
         }
         if (_NumberOfPicturesToSave == 0)
         {  // nothing to save! finish!
            if (Saved != null)
            {
               Saved(this, new OnPictureListSavedEventArgs(_SaveResult));
            }
            return;
         }
         lock (_PicturesToSave)
         {
            _TotalNumberOfPictures = _PicturesToSave.Count;
            Debug.WriteLine(_TotalNumberOfPictures.ToString() + " Pictures in Save-Queue (Starting)");
            // start with maximal four threads
            for (int i = 0; i < 4 && i < _PicturesToSave.Count; i++)
            {
               PictureComparer pc = _PicturesToSave.Dequeue();
               pc.Save();
            }

         }
      }
      /// <summary>
      /// Value was saved. Collect info, then finish
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void Value_Saved(object sender, OnSavedEventArgs args)
      {
         lock (_PicturesToSave)
         {
            PictureComparer pc = sender as PictureComparer;
            if (pc != null)
            {
               _SaveResult += pc.FileName + ":" + Environment.NewLine;
            }
            _SaveResult += args.ToolOutput;
            _NumberOfPicturesToSave--;

            if (PictureSaved != null)
            {
               PictureSaved(this, new OnPictureSavedEventArgs(pc.FileName, (int)(100 - 100 * (float)((float)_NumberOfPicturesToSave / (float)_TotalNumberOfPictures))));
            }

            // one more in the queue? -> dequeue, start saving
            if (_PicturesToSave.Count > 0)
            {
               PictureComparer pic = _PicturesToSave.Dequeue();
               pic.Save();
            }

            Debug.WriteLine(_PicturesToSave.Count.ToString() + " Pictures in Save-Queue");

            // finished?
            if (_NumberOfPicturesToSave == 0)
            {
               if (Saved != null)
               {
                  Saved(this, new OnPictureListSavedEventArgs(_SaveResult));
               }
            }
         }
      }
   }
}

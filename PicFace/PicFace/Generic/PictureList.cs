using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;
using System.Diagnostics;

namespace PicFace.Generic
{
   #region OnSavedEventArgs
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
   /// <summary>
   /// This class contains all pictures of a directory 
   /// </summary>
   internal class PictureList
   {
      private PicasaPictureInfoList _PicasaPictures;
      private ExifPictureInfoList _ExifPictures;
      private Dictionary<string, PictureComparer> _ConsolidatedList;
      private Dictionary<string, PictureComparer> _ChangesPendingList;
      private string _Path;
      private string _SaveResult;
      private int _NumberOfPicturesToSave;
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
      /// Picasa Pictures
      /// </summary>
      public PicasaPictureInfoList PicasaPictures 
      { 
         get
         {
            return _PicasaPictures;
         }
      }
      /// <summary>
      /// Exif Pictures
      /// </summary>
      public ExifPictureInfoList ExifPictures
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
      public PictureList(string path, ContactTable contacts)
      {
         
         _Path = path;
         _PicasaPictures = new PicasaPictureInfoList(path, contacts);
         _ExifPictures = new ExifPictureInfoList(path);
         _ConsolidatedList = new Dictionary<string, PictureComparer>();
         _ChangesPendingList = new Dictionary<string, PictureComparer>();

         // add first all picasa pictures
         foreach (KeyValuePair<string, PictureInfo> entry in _PicasaPictures)
         {
            PictureComparer pc = new PictureComparer();
            pc.PicasaInfo = entry.Value as PicasaPictureInfo;
            pc.CheckPics();
            _ConsolidatedList.Add(entry.Key, pc);
         }
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
         foreach (KeyValuePair<string, PictureComparer> kvp in _ChangesPendingList)
         {
            _NumberOfPicturesToSave++;
            kvp.Value.Saved += new PictureComparer.OnSaved(Value_Saved);
            kvp.Value.Save();
         }
      }
      /// <summary>
      /// Value was saved. Collect info, then finish
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void Value_Saved(object sender, OnSavedEventArgs args)
      {
         lock (_SaveResult)
         {
            PictureComparer pc = sender as PictureComparer;
            if (pc != null)
            {
               _SaveResult += pc.FileName + ":" + Environment.NewLine;
            }
            _SaveResult += args.ToolOutput;
            _NumberOfPicturesToSave--;
         }
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

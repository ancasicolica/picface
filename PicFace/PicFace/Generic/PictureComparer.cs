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
using System.Diagnostics;
using System.Drawing;
using PicFace.ExifTool;
using PicFace.Picasa;

namespace PicFace.Generic
{
   #region OnSavedEventArgs
   /// <summary>
   /// Event args when saved
   /// </summary>
   internal class OnSavedEventArgs
   {
      /// <summary>
      /// Output of the tool when saving data
      /// </summary>
      public string ToolOutput { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="output"></param>
      public OnSavedEventArgs(string output)
      {
         ToolOutput = output;
      }
   }
   #endregion
   /// <summary>
   /// This class contains the information of picasa and exiftool and compares them
   /// </summary>
   internal class PictureComparer
   {
      /// <summary>
      /// Delegate for event after data was saved
      /// </summary>
      /// <param name="sender">Sender object</param>
      /// <param name="args">Result of saving</param>
      public delegate void OnSaved(object sender, OnSavedEventArgs args);
      /// <summary>
      /// Event after data was saved
      /// </summary>
      public event OnSaved Saved;

      /// <summary>
      /// The delta between Picasa and exif
      /// </summary>
      private FaceList _DeltaList;
      private FaceList _OnlyInPicasa;
      private FaceList _OnlyInExif;
      private FaceList _RegionMismatch;
      /// <summary>
      /// The data which will be written
      /// </summary>
      private FaceList _WriteData;
      /// <summary>
      /// The Picasa Part of the Information
      /// </summary>
      public PicasaPictureInfo PicasaInfo {get; set;}
      /// <summary>
      /// The Exif Part of the Information
      /// </summary>
      public ExifPictureInfo ExifInfo {get; set;}
      /// <summary>
      /// The string needed for exif tool to set the settings from picasa
      /// </summary>
      public string ExifToolChangeString
      {
         get
         {
            if (PicasaInfoMissing)
            {  // nothing
               return "";
            }
            string s = "";
            foreach (KeyValuePair<string, Face> kvp in _WriteData)
            {
               Face f = kvp.Value;
               if (f.Name.Length > 0)
               {
                  s += "-xmp-mp:RegionPersonDisplayName=" + f.Name + Environment.NewLine;
                  s += "-xmp-mp:RegionRectangle=" + f.Rect.X.ToString("0.00000000") + ", " +
                     f.Rect.Y.ToString("0.00000000") + ", " + f.Rect.Width.ToString("0.00000000") + ", " +
                     f.Rect.Height.ToString("0.00000000") + Environment.NewLine;
               }
            }
            return s;
         }
      }
      /// <summary>
      /// Filename
      /// </summary>
      public string FileName
      {
         get
         {
            if (!ExifInfoMissing)
            {
               return ExifInfo.FileName;
            }
            if (!PicasaInfoMissing)
            {
               return PicasaInfo.FileName;
            }
            return "none.jpg"; // should not happen!
         }
      }
      /// <summary>
      /// Filename including the path
      /// </summary>
      public string FullFileName
      {
         get
         {
            if (!ExifInfoMissing)
            {
               return ExifInfo.FullFileName;
            }
            if (!PicasaInfoMissing)
            {
               return PicasaInfo.FullFileName;
            }
            return "none.jpg"; // should not happen!
         }
      }
      /// <summary>
      /// The Deltas between picasa and exif
      /// </summary>
      public FaceList DeltaList
      {
         get
         {
            return _DeltaList;
         }
      }
      /// <summary>
      /// Faces where the region is wrong
      /// </summary>
      public FaceList RegionMismatch
      {
         get
         {
            return _RegionMismatch;
         }
      }
      /// <summary>
      /// Is an Exif-Data Update needed?
      /// </summary>
      public bool ExifUpdateNeeded
      {
         get
         {
            if (ExifInfoMissing && !PicasaInfoMissing)
            {
               return true;
            }
            return _DeltaList.Count > 0;
         }
      }
      /// <summary>
      /// The Deltas between picasa and exif
      /// </summary>
      public FaceList OnlyInPicasa
      {
         get
         {
            return _OnlyInPicasa;
         }
      }
      /// <summary>
      /// The Deltas between picasa and exif
      /// </summary>
      public FaceList OnlyInExif
      {
         get
         {
            return _OnlyInExif;
         }
      }
      /// <summary>
      /// Is Picasa Info missing?
      /// </summary>
      public bool PicasaInfoMissing
      {
         get
         {
            return PicasaInfo == null;
         }
      }
      /// <summary>
      /// Is Exif Info missing?
      /// </summary>
      public bool ExifInfoMissing
      {
         get
         {
            return ExifInfo == null;
         }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      public PictureComparer()
      {
         _DeltaList = new FaceList();
         _OnlyInPicasa = new FaceList();
         _OnlyInExif = new FaceList();
      }
      /// <summary>
      /// ToString override
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return FileName + " Update: " + this.ExifUpdateNeeded.ToString();
      }
      /// <summary>
      /// Check the Pictures, if delta is found, set it to DeltaList
      /// </summary>
      /// <returns>true, DeltaList is built</returns>
      public bool CheckPics()
      {
         _DeltaList = new FaceList();
         _OnlyInPicasa = new FaceList();
         _OnlyInExif = new FaceList();
         _RegionMismatch = new FaceList();
         _WriteData = new FaceList();

         // 1) if there are faces in Picasa and none in exif: copy all
         // 2) if there are none in Picasa and some in exif: do nothing
         // 3) compare, list difference

         // 1)
         if (ExifInfoMissing && !PicasaInfoMissing)
         {
            foreach (KeyValuePair<string, Face> kp in PicasaInfo.Faces)
            {
               _DeltaList.Add(kp.Key, kp.Value);
               _OnlyInPicasa.Add(kp.Key, kp.Value);
               _WriteData.Add(kp.Key, kp.Value);
            }
            return true;
         }
         // 2)
         if (PicasaInfoMissing && !ExifInfoMissing)
         {
            foreach (KeyValuePair<string, Face> kp in ExifInfo.Faces)
            {
               _OnlyInExif.Add(kp.Key, kp.Value);
               _WriteData.Add(kp.Key, kp.Value);
            }
            return false;
         }
         // 3) Compare: not only the name, also the region
         foreach (KeyValuePair<string, Face> kp in PicasaInfo.Faces)
         {
            if (!ExifInfo.Faces.ContainsKey(kp.Key))
            {  // name was found in Picasa but not in exif. But what if it was
               // renamed in picasa? we add it here, but we have to check it
               // when reading exiftool data later on
               _DeltaList.Add(kp.Key, kp.Value);
               _OnlyInPicasa.Add(kp.Key, kp.Value);
               _WriteData.Add(kp.Key, kp.Value);
            }
            else
            { // how about the region?
               if (!CompareRectangle(kp.Value.Rect, ExifInfo.Faces[kp.Key].Rect))
               {
                  if (_RegionMismatch.ContainsKey(kp.Key))
                  {
                     _RegionMismatch.Add(kp.Key, kp.Value);
                  }
                  else
                  {
                     _WriteData.Add(kp.Key, kp.Value);
                  }
               }
               else
               { // is the same, so add to "write data" (otherwise we loose this info)
                  _WriteData.Add(kp.Key, kp.Value);
               }
            }
         }
         foreach (KeyValuePair<string, Face> kp in ExifInfo.Faces)
         {
            if (!PicasaInfo.Faces.ContainsKey(kp.Key))
            {  // Name in Exif but not in Picasa. As picasa has the higher priority,
               // we have to check whether the region is already used or not
               bool found = false;
               foreach (KeyValuePair<string, Face> alreadyHere in _WriteData)
               {
                  if (CompareRectangle(alreadyHere.Value.Rect, kp.Value.Rect, 10))
                  { // yes, it is here! Ignore this one
                     found = true;
                     break;
                  }
               }
               if (!found)
               {
                  _DeltaList.Add(kp.Key, kp.Value);
                  _OnlyInExif.Add(kp.Key, kp.Value);
                  _WriteData.Add(kp.Key, kp.Value);
               }
               else
               {
                  _DeltaList.Add(kp.Key, kp.Value);
               }
            }
            else
            { // region?
               if (!CompareRectangle(kp.Value.Rect, PicasaInfo.Faces[kp.Key].Rect))
               {
                  if (_RegionMismatch.ContainsKey(kp.Key))
                  {
                     _RegionMismatch.Add(kp.Key, kp.Value);
                  }
                  else
                  {
                     _WriteData.Add(kp.Key, kp.Value);
                  }
               }
               else
               { // is the same, so add to "write data" (otherwise we loose this info)
                  if (!_WriteData.ContainsKey(kp.Key))
                  {
                     _WriteData.Add(kp.Key, kp.Value);
                  }
               }
            }
         }
         return _WriteData.Count > 0;
      }
      /// <summary>
      /// Compares two rectangles
      /// </summary>
      /// <param name="r1">Rectangle 1</param>
      /// <param name="r2">Rectangle 2</param>
      /// <param name="tolerance">Tolerance in 0/00 (promille)</param>
      /// <returns>true if the rectangles fit, otherwise false</returns>
      private bool CompareRectangle(RectangleF r1, RectangleF r2, ulong tolerance)
      {
         ulong factor = 100000000;

         // Due to debugging and statistic purposes, all values are held as variables.
         // I know there are "better" solutions, but the JIT makes the best of it.
         ulong x1 = (ulong)(r1.X * factor);
         ulong x1Min = x1 * (1000UL - tolerance);
         ulong x1Max = x1 * (1000UL + tolerance);
         ulong y1 = (ulong)(r1.Y * factor);
         ulong y1Min = y1 * (1000UL - tolerance);
         ulong y1Max = y1 * (1000UL + tolerance);
         ulong w1 = (ulong)(r1.Width * factor);
         ulong w1Min = w1 * (1000UL - tolerance);
         ulong w1Max = w1 * (1000UL + tolerance);
         ulong h1 = (ulong)(r1.Height * factor);
         ulong h1Min = h1 * (1000UL - tolerance);
         ulong h1Max = h1 * (1000UL + tolerance);

         ulong x2 = (ulong)(r2.X * factor);
         ulong x2Ref = x2 * 1000;
         ulong y2 = (ulong)(r2.Y * factor);
         ulong y2Ref = y2 * 1000;
         ulong w2 = (ulong)(r2.Width * factor);
         ulong w2Ref = w2 * 1000;
         ulong h2 = (ulong)(r2.Height * factor);
         ulong h2Ref = h2 * 1000;

         if (!(x1Max > x2Ref) && (x1Min < x2Ref))
         {
            Debug.WriteLine(string.Format("Mismatch in X for {0}: {1} vs {2}, difference {3}%",this.FileName, r1.X,r2.X,r1.X / r2.X * 100));
            return false;
         }

         if (!(y1Max > y2Ref) && (y1Min < y2Ref))
         {
            Debug.WriteLine(string.Format("Mismatch in Y for {0}: {1} vs {2}, difference {3}%", this.FileName, r1.Y, r2.Y, r1.Y / r2.Y * 100));
            return false;
         }

         if (!(h1Max > h2Ref) && (h1Min < h2Ref))
         {
            Debug.WriteLine(string.Format("Mismatch in Height for {0}: {1} vs {2}, difference {3}%", this.FileName, r1.Height, r2.Height, r1.Height / r2.Height * 100));
            return false;
         }

         if (!(w1Max > w2Ref) && (w1Min < w2Ref))
         {
            Debug.WriteLine(string.Format("Mismatch in Width for {0}: {1} vs {2}, difference {3}%", this.FileName, r1.Width, r2.Width, r1.Width / r2.Width * 100));
            return false;
         }
         return true;
      }
      /// <summary>
      /// Compares two rectangles with default tolerance
      /// </summary>
      /// <param name="r1">rectangle 1</param>
      /// <param name="r2">rectangle 2</param>
      /// <returns>true if the rectangles are the same (with a certain tolerance)</returns>
      private bool CompareRectangle(RectangleF r1, RectangleF r2)
      {
         return CompareRectangle(r1, r2, 5);
      }
      /// <summary>
      /// Saves the data
      /// </summary>
      /// <returns></returns>
      public bool Save()
      {
         if (ExifToolChangeString.Length == 0)
         {
            Debug.WriteLine("Nothing to save", this.ToString());
            return false;
         }

         string cmd = "-preserve" + Environment.NewLine;
         cmd += "-xmp-mp:ALL= " + Environment.NewLine;
         cmd += ExifToolChangeString + Environment.NewLine;
        
         ExifToolThread exifTool = new ExifToolThread(cmd , FullFileName);
         exifTool.Finished += new ExifToolThread.OnFinished(exifTool_Finished);
         exifTool.Start();
        
         Debug.WriteLine(this.FileName + ": " + cmd);
         return true;
      }
      /// <summary>
      /// One exiftool finished, shot event when registerd
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void exifTool_Finished(object sender, FinishedEventArgs args)
      {
         if (Saved != null)
         {
            Saved(this, new OnSavedEventArgs(args.ToolOutput + Environment.NewLine +
               args.ErrorOutput + Environment.NewLine));
         }
      }
   }
}

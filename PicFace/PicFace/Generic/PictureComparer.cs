using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;
using System.Drawing;
using System.Diagnostics;

namespace PicFace.Generic
{
   /// <summary>
   /// This class contains the information of picasa and exiftool and compares them
   /// </summary>
   internal class PictureComparer
   {
      /// <summary>
      /// The delta between Picasa and exif
      /// </summary>
      private FaceList _DeltaList;
      private FaceList _OnlyInPicasa;
      private FaceList _OnlyInExif;
      private FaceList _RegionMismatch;
      /// <summary>
      /// The Picasa Part of the Information
      /// </summary>
      public PicasaPictureInfo PicasaInfo {get; set;}
      /// <summary>
      /// The Exif Part of the Information
      /// </summary>
      public ExifPictureInfo ExifInfo {get; set;}
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
            }
            return true;
         }
         // 2)
         if (PicasaInfoMissing && !ExifInfoMissing)
         {
            foreach (KeyValuePair<string, Face> kp in ExifInfo.Faces)
            {
               _OnlyInExif.Add(kp.Key, kp.Value);
            }
            return false;
         }
         // 3) Compare: not only the name, also the region
         foreach (KeyValuePair<string, Face> kp in PicasaInfo.Faces)
         {
            if (!ExifInfo.Faces.ContainsKey(kp.Key))
            { // in Picasa but not in exif
               _DeltaList.Add(kp.Key, kp.Value);
               _OnlyInPicasa.Add(kp.Key, kp.Value);
            }
            else
            { // how about the region?
               if (!CompareRectangle(kp.Value.Rect, ExifInfo.Faces[kp.Key].Rect))
               {
                  _RegionMismatch.Add(kp.Key, kp.Value);
               }
            }
         }
         foreach (KeyValuePair<string, Face> kp in ExifInfo.Faces)
         {
            if (!PicasaInfo.Faces.ContainsKey(kp.Key))
            { // in Picasa but not in exif
               _DeltaList.Add(kp.Key, kp.Value);
               _OnlyInExif.Add(kp.Key, kp.Value);
            }
            else
            { // region?
               if (!CompareRectangle(kp.Value.Rect, PicasaInfo.Faces[kp.Key].Rect))
               {
                  _RegionMismatch.Add(kp.Key, kp.Value);
               }
            }
         }
         return _DeltaList.Count > 0;
      }
      /// <summary>
      /// Compares two rectangles
      /// </summary>
      /// <param name="r1">rectangle 1</param>
      /// <param name="r2">rectangle 2</param>
      /// <returns>true if the rectangles are the same (with a certain tolerance)</returns>
      private bool CompareRectangle(RectangleF r1, RectangleF r2)
      {
         int factor = 100000000;
         int tolerance = 1; // in promille

         int x1 = (int)(r1.X * factor);
         int y1 = (int)(r1.Y * factor);
         int w1 = (int)(r1.Width * factor);
         int h1 = (int)(r1.Height * factor);


         int x2 = (int)(r2.X * factor);
         int y2 = (int)(r2.Y * factor);
         int w2 = (int)(r2.Width * factor);
         int h2 = (int)(r2.Height * factor);

         if (!((x1 * (1000 + tolerance) > x2 * 1000) && (x1 * (1000 - tolerance)) < (x2 * 1000)))
         {
            Debug.WriteLine("Mismatch in X", this.ToString());
            return false;
         }

         if (!((y1 * (1000 + tolerance) > y2 * 1000) && (y1 * (1000 - tolerance)) < (y2 * 1000)))
         {
            Debug.WriteLine("Mismatch in Y", this.ToString());
            return false;
         }

         if (!((h1 * (1000 + tolerance) > h2 * 1000) && (h1 * (1000 - tolerance)) < (h2 * 1000)))
         {
            Debug.WriteLine("Mismatch in H", this.ToString());
            return false;
         }

         if (!((w1 * (1000 + tolerance) > w2 * 1000) && (w1 * (1000 - tolerance)) < (w2 * 1000)))
         {
            Debug.WriteLine("Mismatch in W", this.ToString());
            return false;
         }
         return true;
      }
   }
}

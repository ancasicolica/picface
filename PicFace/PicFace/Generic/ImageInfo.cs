/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2013 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

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
using Kusti.PicFaceLib.ExifTool;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kusti.PicFaceLib.Generic
{
   /// <summary>
   /// This class contains all information about an image. It is the successor of PictureInfo which is not used
   /// anymore in PicFace V2.
   /// The data is primary the one read out with the exiftool, found in ExifToolPictureData, but in a more
   /// readable and comparable way.
   /// </summary>
   public class ImageInfo
   {
      /// <summary>
      /// How many digits after the point have to be considered? Exiftool returns with 6 digits, so 
      /// this should be the default value. 
      /// I realised this as a property (and not a const) so this could be configurable in future, 
      /// even I don't have any plans so far for this.
      /// </summary>
      internal int Precision
      {
         get
         {
            return 6;
         }
      }
      #region Fields
      /// <summary>
      /// The data read out with exiftool
      /// </summary>
      private ExifToolPictureData _ExifToolPictureData;
      /// <summary>
      /// List with all the XMP Faces
      /// </summary>
      private FaceList _XmpFaces;
      /// <summary>
      /// List with all the Picasa Faces
      /// </summary>
      private FaceList _PicasaFaces;
      #endregion
      /// <summary>
      /// The dimensions of the image in pixels.
      /// </summary>
      public Size Dimensions
      {
         get
         {
            return new Size(_ExifToolPictureData.ImageWidth, _ExifToolPictureData.ImageHeight);
         }
      }
      /// <summary>
      /// Name of the file
      /// </summary>
      public string FileName
      {
         get
         {
            return _ExifToolPictureData.SourceFile;
         }
      }
      /// <summary>
      /// The directory where the picture is located in
      /// </summary>
      public string Directory
      {
         get
         {
            return _ExifToolPictureData.Directory;
         }
      }

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="data">The exiftool data which is needed to build this object</param>
      internal ImageInfo(ExifToolPictureData data)
      {
         _ExifToolPictureData = data;

         // Create the face list with all XMP faces
         _XmpFaces = new FaceList();
         if (data.RegionInfoMp != null && data.RegionInfoMp.Regions != null)
         {
            foreach (RegionMp region in data.RegionInfoMp.Regions)
            {
               string[] rect = region.Rectangle.Split(new char[] { ',' });
               float x, y, w, h;
               x = (float)Math.Round(Convert.ToSingle(rect[0]), Precision);
               y = (float)Math.Round(Convert.ToSingle(rect[1]), Precision);
               w = (float)Math.Round(Convert.ToSingle(rect[2]), Precision);
               h = (float)Math.Round(Convert.ToSingle(rect[3]), Precision);
               Face f = new Face(region.PersonConvertedName, new RectangleF(x, y, w, h));
               _XmpFaces.Add(f);
            }
         }

         // Create the face list with all Picasa faces
         _PicasaFaces = new FaceList();
         if (data.RegionInfo.RegionList != null)
         {
            foreach (ExifTool.Region region in data.RegionInfo.RegionList)
            {

               float x, y, w, h;

               x = (float)Math.Round(region.Area.X - (region.Area.W / 2), Precision);
               y = (float)Math.Round(region.Area.Y - (region.Area.H / 2), Precision);
               w = (float)Math.Round(region.Area.W, Precision);
               h = (float)Math.Round(region.Area.H, Precision);
               Face f = new Face(region.PersonConvertedName, new RectangleF(x, y, w, h));
               _PicasaFaces.Add(f);
            }
         }
      }
      /// <summary>
      /// The ToString override returns simply the name of the file
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Path.GetFileName(this.FileName);
      }
      /// <summary>
      /// Mark the faces on the picture box
      /// </summary>
      /// <param name="picturebox"></param>
      public void MarkFaces(PictureBox picturebox)
      {
         FaceToPictureBox fpb = new FaceToPictureBox(picturebox);

         Pen p = new Pen(Color.Red, 2);
         foreach (Face f in _PicasaFaces.Values)
         {
            fpb.DrawFace(f);
         }
      }
   }
}

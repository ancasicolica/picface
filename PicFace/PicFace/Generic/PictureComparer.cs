using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;

namespace PicFace.Generic
{
   /// <summary>
   /// This class contains the information of picasa and exiftool and compares them
   /// </summary>
   internal class PictureComparer
   {
      PicasaPictureInfo _PicasaInfo;
      ExifPictureInfo _ExifInfo;
      /// <summary>
      /// The Picasa Part of the Information
      /// </summary>
      public PicasaPictureInfo PicasaInfo
      {
         get
         {
            return _PicasaInfo;
         }
      }
      /// <summary>
      /// The Exif Part of the Information
      /// </summary>
      public ExifPictureInfo ExifInfo
      {
         get
         {
            return _ExifInfo;
         }
      }

      public PictureComparer(PicasaPictureInfo picasaInfo, ExifPictureInfo exifInfo)
      {
         _PicasaInfo = picasaInfo;
         _ExifInfo = exifInfo;
      }
   }
}

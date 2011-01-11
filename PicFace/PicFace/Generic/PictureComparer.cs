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
      public PictureComparer()
      {
  
      }
      /// <summary>
      /// ToString override
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return FileName;
      }
   }
}

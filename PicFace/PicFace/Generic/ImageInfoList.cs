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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kusti.PicFaceLib.Generic
{
   /// <summary>
   /// This list (dictionary) contains all images found in the directory
   /// </summary>
   public class ImageInfoList : Dictionary<string, ImageInfo>
   {
      /// <summary>
      /// Public constructor, load the list out of a directory
      /// </summary>
      /// <param name="directory">Directory</param>
      public ImageInfoList(string directory)
      {
         ExifToolPictureData[] data = ExifToolPictureData.Collect(directory);
         foreach (ExifToolPictureData d in data)
         {
            this.Add(d.SourceFile, new ImageInfo(d));
         }
      }
      /// <summary>
      /// Internal constructor
      /// </summary>
      /// <param name="data">Data read out of the exiftool</param>
      internal ImageInfoList(ExifToolPictureData[] data)
      {
         foreach (ExifToolPictureData d in data)
         {
            this.Add(d.SourceFile, new ImageInfo(d));
         }
      }
   }
}

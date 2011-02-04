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
using System.Text;
using PicFace.Generic;

namespace PicFace.ExifTool
{
   /// <summary>
   /// List containing all images read out with exiftool
   /// </summary>
   internal class ExifPictureInfoList : PictureInfoList
   {
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="path">Path where the data is collected</param>
      public ExifPictureInfoList(string path) : base(path)
      {
         ExifToolPictureData.Collect(path, this);
      }
      /// <summary>
      /// Converts a string in default coding to utf8
      /// </summary>
      /// <param name="sourceString"></param>
      /// <returns></returns>
      private string ConvertDefaultToUtf8(string sourceString)
      {
         if (sourceString == null)
         {
            return "";
         }

         // Create two different encodings.
         Encoding source = Encoding.Default;

         // Convert the string into a byte[].
         byte[] unicodeBytes = source.GetBytes(sourceString);

         Console.WriteLine("1: {0}", Encoding.UTF8.GetString(unicodeBytes));


         return Encoding.UTF8.GetString(unicodeBytes);
      }
   }
}

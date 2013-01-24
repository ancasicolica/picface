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
using System;
using System.Text;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Region for a person information (Picasa). Naming after Exif Tool terms (JSON Format)
   /// </summary>
   public class Region
   {
      /// <summary>
      /// Display name, as read in JSON
      /// </summary>
      public string Name { get; set; }
      /// <summary>
      /// Display name, converted
      /// </summary>
      public string PersonConvertedName
      {
         get
         {
            return ConvertDefaultToUtf8(Name);
         }
      }
      /// <summary>
      /// Rectangle read from JSON
      /// </summary>
      public PicFace.ExifTool.AreaData Area { get; set; }
      public string Type { get; set; }
      /// <summary>
      /// Region
      /// </summary>
      public Region()
      {

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
      /// <summary>
      /// Debuggable name
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return PersonConvertedName;
      }
   }
}

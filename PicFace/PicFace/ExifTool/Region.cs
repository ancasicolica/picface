using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Region for a person information. Naming after Exif Tool terms (JSON Format)
   /// </summary>
   public class Region
   {
      /// <summary>
      /// Display name, as read in JSON
      /// </summary>
      public string PersonDisplayName { get; set; }
      /// <summary>
      /// Display name, converted
      /// </summary>
      public string PersonConvertedName
      {
         get
         {
            return ConvertDefaultToUtf8(PersonDisplayName);
         }
      }
      /// <summary>
      /// Rectangle read from JSON
      /// </summary>
      public string Rectangle { get; set; }
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
   }
}

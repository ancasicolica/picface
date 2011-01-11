using System;
using System.Collections.Generic;
using System.Linq;
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

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
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PicFace.Framework
{
   /// <summary>
   /// Class handling temporary files: get new name, write them, delete them
   /// </summary>
   public class TemporaryFileManager
   {
      private static List<string> _Files;
      /// <summary>
      /// Creates a temporary file with a given content
      /// </summary>
      /// <param name="contents">content to write</param>
      /// <returns>name of the temporary file</returns>
      public static string CreateNextFile(string contents)
      {
         string tempFile = TemporaryFileManager.GetNextFile();

         try
         {
            StreamWriter sw = new StreamWriter(tempFile, false, Encoding.UTF8);
            sw.Write(contents);
            sw.WriteLine();
            sw.Close();
         }
         catch
         {
         }
         return tempFile;  

      }
      /// <summary>
      /// Returns the next temporary file
      /// </summary>
      public static string GetNextFile()
      {
         string file = Path.GetTempFileName();

         if (_Files == null)
         {
            _Files = new List<string>();
         }
         _Files.Add(file);
         return file;
      }
      /// <summary>
      /// Creates a cleanup, deleting all created files. Call this best in your
      /// application closing routine
      /// </summary>
      public static void Cleanup()
      {
         if (_Files != null)
         {
            foreach (string file in _Files)
            {
               if (File.Exists(file))
               {
                  try
                  {
                     File.Delete(file);
                  }
                  catch
                  { }
               }
            }
         }
      }
   }
}

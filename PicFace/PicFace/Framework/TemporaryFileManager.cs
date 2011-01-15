using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace PicFace.Framework
{
   /// <summary>
   /// Class handling temporary files
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
      /// Creates a cleanup, deleting all created files
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

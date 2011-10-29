using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is a list with directories containig picasa information. It
   /// is used for recursive scans
   /// </summary>
   public class PicasaDirectoryList : List<string>
   {
      public PicasaDirectoryList(string rootDir)
      {
         ScanPath(rootDir);
      }
      private void ScanPath(string path)
      {
         DirectoryInfo info = new DirectoryInfo(path);
         DirectoryInfo[] dirs = info.GetDirectories();
         foreach (DirectoryInfo dir in dirs)
         {
            if (File.Exists(Path.Combine(dir.FullName, ".picasa.ini")) ||
               File.Exists(Path.Combine(dir.FullName, "picasa.ini")))
            {
               this.Add(dir.FullName);
               Debug.WriteLine("Dir found: " + dir.FullName);
            }
            ScanPath(dir.FullName);        
         }
      }
   }
}

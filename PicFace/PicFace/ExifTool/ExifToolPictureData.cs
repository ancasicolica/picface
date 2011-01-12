using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using PicFace.Generic;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Read out data from Exif Tool
   /// </summary>
   internal class ExifToolPictureData
   {
      public string SourceFile { get; set; }
      public double ExifToolVersion { get; set; }
      public string Directory { get; set; }
      public RegionInfoContainer RegionInfo { get; set; }


      /// <summary>
      /// Collects all ExifToolPictureData (raw data) in a path and returns an array with it
      /// </summary>
      /// <param name="path">Path where to collect</param>
      public static void Collect(string path, ExifPictureInfoList list)
      {

         // Read General properties using UTF8
         ProcessStartInfo procStartInfo;
         procStartInfo = new ProcessStartInfo(Path.Combine(Application.StartupPath, "exiftool.exe"));
         procStartInfo.RedirectStandardInput = true;
         procStartInfo.RedirectStandardOutput = true;
         procStartInfo.RedirectStandardError = true;
         procStartInfo.UseShellExecute = false;
         procStartInfo.Arguments = " \"" + path + "\\*.jpg\" -struct -json ";
         procStartInfo.Arguments += "-SourceFile -Directory -RegionInfo";

         procStartInfo.CreateNoWindow = true;
         procStartInfo.StandardOutputEncoding = Encoding.Default;
         Process p = Process.Start(procStartInfo);
         StreamReader streamReader = p.StandardOutput;

         string jsonData = "";
         while (!streamReader.EndOfStream)
         {
            string line = streamReader.ReadToEnd();
            jsonData += line;
            // Debug.WriteLine(line);
            Thread.Sleep(20);
         }
         streamReader.Close();

         ExifToolPictureData[] imageData = JsonConvert.DeserializeObject<ExifToolPictureData[]>(jsonData);

         foreach (ExifToolPictureData etp in imageData)
         {
            if (etp.RegionInfo != null)
            {
               ExifPictureInfo info = new ExifPictureInfo(etp);
               if (info.Faces != null && info.Faces.Count > 0)
               {  // add only pictures with faces in it!
                  list.Add(info.FileName.ToUpper(), info);
               }
            }
         }
      }
   }
}

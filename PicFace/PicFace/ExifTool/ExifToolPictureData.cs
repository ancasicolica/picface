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
/*
      This source code uses the JSON.NET library found on http://json.codeplex.com
      Following the code licence of this library:
 
      Copyright (c) 2007 James Newton-King

      Permission is hereby granted, free of charge, to any person obtaining a 
      copy of this software and associated documentation files (the "Software"), 
      to deal in the Software without restriction, including without limitation the 
      rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
      copies of the Software, and to permit persons to whom the Software is furnished 
      to do so, subject to the following conditions:

      The above copyright notice and this permission notice shall be included in 
      all copies or substantial portions of the Software.

      THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
      IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS 
      FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR 
      COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
      IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION 
      WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
/************************************************************************************/

using Newtonsoft.Json;
using PicFace.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PicFace.ExifTool
{
   /// <summary>
   /// This class contains all data read out using exiftool. The names of the parameters have to fit
   /// the names which are retourned by exiftool, otherwise the JSON class can not map them.
   /// </summary>
   internal class ExifToolPictureData
   {
      /// <summary>
      /// Name of the source file
      /// </summary>
      public string SourceFile { get; set; }
      /// <summary>
      /// Exif Tool Version, not all versions are compatible with this code!
      /// </summary>
      public double ExifToolVersion { get; set; }
      /// <summary>
      /// Directory where the picture resides
      /// </summary>
      public string Directory { get; set; }
      /// <summary>
      /// A container with all the XMP (Microsoft) face regions
      /// </summary>
      public RegionInfoMpContainer RegionInfoMp { get; set; }
      /// <summary>
      /// A container with all the Picasa face regions
      /// </summary>
      public RegionInfoContainer RegionInfo { get; set; }
      /// <summary>
      /// Height of the image, needed to calculate the face rectangles in pixels
      /// </summary>
      public int ImageHeight { get; set; }
      /// <summary>
      /// Width of the image
      /// </summary>
      public int ImageWidth { get; set; }
      /// <summary>
      /// Collects all ExifToolPictureData (raw data) in a path and returns an array with it
      /// </summary>
      /// <param name="path">Path where to collect</param>
      public static ExifToolPictureData[] Collect(string path)
      {

         // Read General properties using UTF8
         ProcessStartInfo procStartInfo;
         procStartInfo = new ProcessStartInfo(Path.Combine(Application.StartupPath, "exiftool.exe"));
         procStartInfo.RedirectStandardInput = true;
         procStartInfo.RedirectStandardOutput = true;
         procStartInfo.RedirectStandardError = true;
         procStartInfo.UseShellExecute = false;
         procStartInfo.Arguments = " \"" + path + "\\*.jpg\" -struct -json ";
         procStartInfo.Arguments += "-SourceFile -Directory -ImageHeight -ImageWidth -RegionInfo -ExifToolVersion -RegionInfoMP";
         // RegionInfo: this is the information written by tools like Microsoft Photo Gallery
         // RegionInfoMP: this is the picasa information

         procStartInfo.CreateNoWindow = true;
         procStartInfo.StandardOutputEncoding = Encoding.Default;
         Process p = Process.Start(procStartInfo);
         StreamReader streamReader = p.StandardOutput;

         string jsonData = "";
         while (!streamReader.EndOfStream)
         {
            string line = streamReader.ReadToEnd();
            jsonData += line;
            Debug.WriteLine(line);
            Thread.Sleep(20);
         }
         streamReader.Close();

         // Deserialise the JSON Data into an array
         ExifToolPictureData[] imageData = JsonConvert.DeserializeObject<ExifToolPictureData[]>(jsonData);

         return imageData;
      }

   }
}

using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Kusti.PicFaceLib.Framework;
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

namespace Kusti.PicFaceLib.ExifTool
{
   #region FinishedEventArgs
   /// <summary>
   /// Finished event args
   /// </summary>
   internal class FinishedEventArgs
   {
      /// <summary>
      /// Output from ExifTool
      /// </summary>
      public string ToolOutput { get; private set; }
      /// <summary>
      /// The error output from ExifTool
      /// </summary>
      public string ErrorOutput { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="output">Normal output</param>
      /// <param name="error">Error Output</param>
      public FinishedEventArgs(string output, string error)
      {
         ToolOutput = output;
         ErrorOutput = error;
      }
   }
   #endregion
   /// <summary>
   /// Runs exif tool in an own thread
   /// </summary>
   internal class ExifToolThread
   {

      /// <summary>
      /// Delegate for finished thread
      /// </summary>
      /// <param name="sender">sender object</param>
      /// <param name="args">arguments</param>
      public delegate void OnFinished(object sender, FinishedEventArgs args);
      /// <summary>
      /// Finished event
      /// </summary>
      public event OnFinished Finished;

      #region Fields
      private Thread _ExifToolThread;
      private string _Arguments;
      private string _ArgumentsFile;
      private string _FileName;
      #endregion

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="arguments">ExifTool arguments</param>
      /// <param name="fileName">Name of the file, including path</param>
      public ExifToolThread(string arguments, string filename)
      {
         // safe arguments in file
         _Arguments = arguments;
         _ArgumentsFile = TemporaryFileManager.CreateNextFile(arguments);
         _FileName = filename;
         Debug.WriteLine("File: " + filename + ", TempFileName: " + _ArgumentsFile, "ExifToolThread");
      }
      /// <summary>
      /// Start exif tool
      /// </summary>
      public void Start()
      {
         if (_ExifToolThread == null)
         {
            _ExifToolThread = new Thread(new ThreadStart(ToolThread));
            _ExifToolThread.IsBackground = true;
            _ExifToolThread.Name = "ExifTool Thread";
            _ExifToolThread.Start();
         }
      }
      /// <summary>
      /// the thread the tool is running in 
      /// </summary>
      private void ToolThread()
      {
         // Read General properties using UTF8
         ProcessStartInfo procStartInfo;
         procStartInfo = new ProcessStartInfo(Path.Combine(Application.StartupPath, "exiftool.exe"));
         procStartInfo.RedirectStandardInput = true;
         procStartInfo.RedirectStandardOutput = true;
         procStartInfo.RedirectStandardError = true;
         procStartInfo.UseShellExecute = false;
         procStartInfo.Arguments = "-@ \"" + _ArgumentsFile + "\"  \"" + _FileName + "\"";
         procStartInfo.CreateNoWindow = true;
         procStartInfo.StandardOutputEncoding = Encoding.ASCII;
         Process p = Process.Start(procStartInfo);

         string toolOutput = "";
         string errorOutput = "";

         StreamReader streamReader = p.StandardOutput;
         StreamReader errorReader = p.StandardError;
         do
         {
            errorOutput += errorReader.ReadToEnd();
            toolOutput += streamReader.ReadToEnd();
            Debug.WriteLine(errorOutput);
            // give other processes a chance
            Thread.Sleep(20);
         }
         while (!streamReader.EndOfStream && !errorReader.EndOfStream);
         streamReader.Close();
         errorReader.Close();

         Debug.WriteLine("ExifTool Result for " + this._FileName);
         Debug.WriteLine(toolOutput);
         Debug.WriteLine(errorOutput);

         if (Finished != null)
         {
            Finished(this, new FinishedEventArgs(toolOutput, errorOutput));
         }
      }
   }
}

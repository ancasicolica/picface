using System;
using System.Threading;
using Kusti.PicFaceLib.Generic;

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
namespace PicFace
{
   /// <summary>
   /// This is the form for loading data, it is derived from the FormWait
   /// </summary>
   class FormWaitLoading : FormWait
   {
      /// <summary>
      /// The picture list, available afterwards
      /// </summary>
      public PictureList Pictures { get; private set; }
      /// <summary>
      /// Directory to scan
      /// </summary>
      public string Directory { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="directory">Directory where the pictures reside</param>
      public FormWaitLoading(string directory) : base()
      {
         Directory = directory;
      }
      /// <summary>
      /// Loading the form
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      internal override void FormWait_Load(object sender, EventArgs e)
      {
         base.FormWait_Load(sender, e);
         progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         labelAction.Text = "Please wait... Loading faces from pictures";
         labelInfo.Text = Directory;
         // start a new thread to give the control enough time to display the nice 
         // progress bar
         Thread collector = new Thread(new ThreadStart(CollectionStarter));
         collector.Name = "Collector Starter";
         collector.IsBackground = true;
         collector.Start();
         this.TaskFinished += new TaskFinishedHandler(OnTaskFinished);
      }
      /// <summary>
      /// Thread collecting data
      /// </summary>
      private void CollectionStarter()
      {
         Pictures = new PictureList(Directory);
         FireTaskFinishedEvent();
      }
   }
}

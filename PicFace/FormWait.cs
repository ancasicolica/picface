using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
   public partial class FormWait : Form
   {
      /// <summary>
      /// The delegate for finishing a task
      /// </summary>
      protected delegate void TaskFinishedHandler();
      /// <summary>
      /// The event for a finished task
      /// </summary>
      protected event TaskFinishedHandler TaskFinished;
      /// <summary>
      /// The constructor
      /// </summary>
      public FormWait()
      {
         InitializeComponent();
      }
      /// <summary>
      /// Form Loading
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      internal virtual void FormWait_Load(object sender, EventArgs e)
      {

      }
      protected void FireTaskFinishedEvent()
      {
         if (TaskFinished != null)
         {
            TaskFinished();
         }
      }
      /// <summary>
      /// Closes the form when the task is finished
      /// </summary>
      protected void OnTaskFinished()
      {
         if (this.InvokeRequired)
         {// Make sure we run on UI thread
            // Create a delegate to self 
            TaskFinishedHandler safeEvent = new TaskFinishedHandler(OnTaskFinished);
            // Roll arguments in an Object array
            Object[] arguments = new Object[] { };

            // "Recurse once, onto another thread"
            this.Invoke(safeEvent, arguments);
            return;
         }
         this.Close();
      }
   }
}

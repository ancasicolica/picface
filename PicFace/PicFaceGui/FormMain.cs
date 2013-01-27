/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2013 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kusti.PicFaceLib.Generic;
using System.Collections;

namespace PicFaceGui
{
   public partial class FormMain : Form
   {
      #region Properties
      /// <summary>
      /// The current directory
      /// </summary>
      internal string CurrentDirectory { get; set; }
      #endregion
      public FormMain()
      {
         InitializeComponent();
      }
      /// <summary>
      /// Loading the Form, do some initialisation
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void FormMain_Load(object sender, EventArgs e)
      {
#if DEBUG
         //// ###############
         CurrentDirectory = @"D:\Users\Christian.CPC\Pictures\Tests";

         ImageInfoList list = new ImageInfoList(CurrentDirectory);
         foreach (KeyValuePair<string, ImageInfo> entry in list)
         {
            listBoxImages.Items.Add(entry.Value);
         }
         //// ###############
#endif
      }
      /// <summary>
      /// A different image was selected in the list
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
      {
         ImageInfo info = listBoxImages.SelectedItem as ImageInfo;
         if (info != null)
         {
            pictureBoxPreview.LoadAsync(info.FileName);
            info.MarkFaces(pictureBoxPreview);
         }
         else
         {
            // todo: delete pic
         }
      }
   }
}

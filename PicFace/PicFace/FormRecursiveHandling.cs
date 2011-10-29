using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PicFace.Picasa;
using System.IO;
using PicFace.Generic;
using PicFace.Framework;

namespace PicFace
{
   public partial class FormRecursiveHandling : Form
   {
      /// <summary>
      /// RootPath of the form
      /// </summary>
      public string RootPath { get; set; }
      /// <summary>
      /// The List with Picasa Directories
      /// </summary>
      public PicasaDirectoryList Directories { get; set; }
      /// <summary>
      /// The contacts
      /// </summary>
      internal ContactTable Contacts { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="path"></param>
      internal FormRecursiveHandling(string path, ContactTable contacts)
      {
         InitializeComponent();
         RootPath = path;
         Contacts = contacts;
      }
      /// <summary>
      /// Loading the form
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void FormRecursiveHandling_Load(object sender, EventArgs e)
      {
         new WindowProperties(this);

         toolStripStatusLabelRootPath.Text = RootPath;

      }
      /// <summary>
      /// Scan!
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonScanDirectories_Click(object sender, EventArgs e)
      {
         listBoxDirectories.Items.Clear();
         Directories = new PicasaDirectoryList(RootPath);
         foreach (string s in Directories)
         {
            listBoxDirectories.Items.Add(s);
         }
         toolStripStatusLabelNumberOfDirs.Text  = Directories.Count.ToString() + " Directories";
      }
      /// <summary>
      /// Go through
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonStart_Click(object sender, EventArgs e)
      {
         int picsSaved = 0;
         foreach (string s in Directories)
         {
            // show the "please wait dialog" and get the results from it
            FormWaitLoading fwl = new FormWaitLoading(s, Contacts);
            fwl.ShowDialog();
            picsSaved += fwl.Pictures.ChangesPendingList.Count;
            FormWaitSaving fws = new FormWaitSaving(fwl.Pictures);
            fws.ShowDialog();

         }
         toolStripStatusLabelSaved.Text = picsSaved.ToString() + " Pictures saved";
      }

   }
}

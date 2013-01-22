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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PicFace.Generic;
using PicFace.Picasa;
using PicFace.Framework;

namespace PicFace
{
   /// <summary>
   /// The main form of the tool
   /// </summary>
   public partial class FormMain : Form
   {
      #region Fields
      /// <summary>
      /// All contacts
      /// </summary>
      private ContactTable _Contacts;
      /// <summary>
      /// Name of the current directory
      /// </summary>
      private string _CurrentDirectory;
      /// <summary>
      /// Picture List
      /// </summary>
      private PictureList _PictureList;
      /// <summary>
      /// The object to visualise a face
      /// </summary>
      private FaceToPictureBox _FaceVisualiser;
      #endregion
      /// <summary>
      /// Constructor
      /// </summary>
      public FormMain()
      {
         InitializeComponent();
      }
      /// <summary>
      /// Form is being loaded
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void FormMain_Load(object sender, EventArgs e)
      {
         // save states
         new WindowProperties(this);

         // Refresh contacts first
         buttonRefreshContacts_Click(sender, e);
         _FaceVisualiser = new FaceToPictureBox(pictureBoxPreview);
         toolStripStatusLabelInfo.Text = "";

         // update the file list settings
         bool onlyChanged = (PicFaceConfig.FileView == PicFaceConfig.FileViewSettings.OnlyChanged);
         allFilesToolStripMenuItem.Checked = !onlyChanged;
         filesWithChangedFaceInformationToolStripMenuItem.Checked = onlyChanged;

#if DEBUG
         //// ###############
         _CurrentDirectory = @"D:\Users\Christian.CPC\Pictures\Tests";
         textBoxDirectory.Text = _CurrentDirectory;

         LoadPictureIndex();
         //// ###############
#endif
      }
      /// <summary>
      /// Refresh the contacts
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonRefreshContacts_Click(object sender, EventArgs e)
      {
         labelContactsFile.Text = ContactReader.PicasaDefaultPersonFile;

         _Contacts = ContactReader.Read(ContactReader.PicasaDefaultPersonFile);
         listBoxContacts.Items.Clear();

         foreach (KeyValuePair<string, Contact> c in _Contacts)
         {
            listBoxContacts.Items.Add(c.Value);
         }
         labelContactNb.Text = listBoxContacts.Items.Count.ToString() + " Contacts";
      }
      /// <summary>
      /// Show info about the contact when selecting a new one
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
      {
         Contact c = listBoxContacts.SelectedItem as Contact;
         if (c != null)
         {
            labelContactInfo.Text = c.Name;
            if (c.Display.Length > 0)
            {
               labelContactInfo.Text += " (\"" + c.Display + "\")";
            }
            labelContactInfo.Text += " " + c.Modified.ToShortDateString() + " " + c.Modified.ToShortTimeString();
            labelContactInfo.Text += " id:" + c.Id;
         }
         else
         {
            labelContactInfo.Text = "";
         }
      }
      /// <summary>
      /// Select Directory in "My Pictures"
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void selectDirectoryInMyPicturesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyPictures;
         DialogResult res = folderBrowserDialog1.ShowDialog();
         if (res == DialogResult.OK)
         {
            _CurrentDirectory = folderBrowserDialog1.SelectedPath;
            textBoxDirectory.Text = _CurrentDirectory;

            LoadPictureIndex();
         }
      }
      /// <summary>
      /// Change the directory
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonChangeDirectory_Click(object sender, EventArgs e)
      {
         if (textBoxDirectory.Text.Length > 0)
         {  // name is here, use this one
            folderBrowserDialog1.SelectedPath = textBoxDirectory.Text;
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
               _CurrentDirectory = folderBrowserDialog1.SelectedPath;
               textBoxDirectory.Text = _CurrentDirectory;

               LoadPictureIndex();
            }
         }
         else
         {  // go to myPictures
            selectDirectoryInMyPicturesToolStripMenuItem_Click(this, e);
         }
      }
      /// <summary>
      /// Select any Directory
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
      {
         folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
         DialogResult res = folderBrowserDialog1.ShowDialog();
         if (res == DialogResult.OK)
         {
            _CurrentDirectory = folderBrowserDialog1.SelectedPath;
            textBoxDirectory.Text = _CurrentDirectory;

            LoadPictureIndex();
         }
      }
      /// <summary>
      /// Load the Picture Index
      /// </summary>
      private void LoadPictureIndex()
      {
         // toolStripStatusLabelInfo.Text = "Loading pictures";
         // show the "please wait dialog" and get the results from it
         FormWaitLoading fwl = new FormWaitLoading(_CurrentDirectory, _Contacts);
         fwl.ShowDialog();
         _PictureList = fwl.Pictures;
         _PictureList.Saved += new PictureList.OnSaved(_PictureList_Saved);
         FillListBoxFiles();
      }
      /// <summary>
      /// Event when Picture List was saved
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void _PictureList_Saved(object sender, OnPictureListSavedEventArgs args)
      {
         if (this.InvokeRequired)
         {// Make sure we run on UI thread
            // Create a delegate to self 
            PictureList.OnSaved safeEvent = new PictureList.OnSaved(_PictureList_Saved);
            // Roll arguments in an Object array
            Object[] arguments = new Object[] {sender, args };

            // "Recurse once, onto another thread"
            this.Invoke(safeEvent, arguments);
            return;
         }
         textBoxLog.Text = args.Result;
         toolStripStatusLabelInfo.Text = "Data saved";
         LoadPictureIndex();
         this.Cursor = Cursors.Default;
      }
      /// <summary>
      /// Selected Index changed: load the picture and show who is on it
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
      {
         PictureComparer p = listBoxFilesChanged.SelectedItem as PictureComparer;
         if (p != null)
         {
            _FaceVisualiser.FileName = Path.Combine(_CurrentDirectory, p.FileName);
            // Add all faces to the found faces list boxes
            listBoxPersonsFound.Items.Clear();
            listBoxPersonsFoundXmp.Items.Clear();
            listBoxResult.Items.Clear();

            if (p.PicasaInfo != null)
            {
               foreach (KeyValuePair<string, Face> kp in p.PicasaInfo.Faces)
               {
                  listBoxPersonsFound.Items.Add(kp.Value);
               }
            }
            if (p.ExifInfo != null)
            {
               foreach (KeyValuePair<string, Face> kp in p.ExifInfo.Faces)
               {
                  listBoxPersonsFoundXmp.Items.Add(kp.Value);
               }
            }
            if (p.WriteData != null)
            {
               foreach (KeyValuePair<string, Face> kp in p.WriteData)
               {
                  listBoxResult.Items.Add(kp.Value);
               }
            }
         }
      }
      /// <summary>
      /// Debug: double click on an changed item can do somthing
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxFilesChanged_DoubleClick(object sender, EventArgs e)
      {
         PictureComparer p = listBoxFilesChanged.SelectedItem as PictureComparer;
         if (p != null)
         {
       
         }
      }
      /// <summary>
      /// Index of the list changed
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxPersonsFound_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox listbox = sender as ListBox;
         if (listbox != null)
         {
            Face f = listbox.SelectedItem as Face;
            if (f != null)
            {
               _FaceVisualiser.DrawFace(f);
            }
         }
      }
      /// <summary>
      /// Mouse moves over picture
      /// </summary>
      /// <param name="sender">The picture box the mouse is moving on</param>
      /// <param name="e">Event args</param>
      private void pictureBoxPreview_MouseMove(object sender, MouseEventArgs e)
      {

      }
      /// <summary>
      /// Save changed Data
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonSaveChangedData_Click(object sender, EventArgs e)
      {
         this.Cursor = Cursors.WaitCursor;
         _FaceVisualiser.ReleasePicture();
         FormWaitSaving fws = new FormWaitSaving(_PictureList);
         fws.ShowDialog();
      }
      /// <summary>
      /// Refresh view (reload picasa and xmp data)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonRefresh_Click(object sender, EventArgs e)
      {
         LoadPictureIndex();
      }
      /// <summary>
      /// Menu: show all files with face information
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void allFilesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         allFilesToolStripMenuItem.Checked = true;
         filesWithChangedFaceInformationToolStripMenuItem.Checked = false;
         PicFaceConfig.FileView = PicFaceConfig.FileViewSettings.All;
         FillListBoxFiles();
      }
      /// <summary>
      /// Menu: show only changed files
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void filesWithChangedFaceInformationToolStripMenuItem_Click(object sender, EventArgs e)
      {
         allFilesToolStripMenuItem.Checked = false;
         filesWithChangedFaceInformationToolStripMenuItem.Checked = true;
         PicFaceConfig.FileView = PicFaceConfig.FileViewSettings.OnlyChanged;
         FillListBoxFiles();
      }
      /// <summary>
      /// Fills the listbox with the files
      /// </summary>
      private void FillListBoxFiles()
      {
         int allPicsWithFacesNb = 0;
         int updateNeededNb = 0;

         // clear list
         listBoxFilesChanged.Items.Clear();

         // all changed files
         listBoxFilesChanged.Items.Clear();
         foreach (KeyValuePair<string, PictureComparer> p in _PictureList.ConsolidatedList)
         {
            allPicsWithFacesNb++;

            if (allFilesToolStripMenuItem.Checked)
            {
               listBoxFilesChanged.Items.Add(p.Value);
            }
            if (p.Value.ExifUpdateNeeded)
            {
               updateNeededNb++;
               if (filesWithChangedFaceInformationToolStripMenuItem.Checked)
               {
                  listBoxFilesChanged.Items.Add(p.Value);
                  Debug.WriteLine(p.Value.ExifToolChangeString);
               }
            }
         }
         labelPicsWithFaceInfoNb.Text = allPicsWithFacesNb.ToString();
         labelPicturesWithChangedInformationNb.Text = updateNeededNb.ToString();

         DirectoryInfo dirInfo = new DirectoryInfo(_PictureList.Path);
         labelTotalPicsNb.Text = dirInfo.GetFiles("*.jpg").Length.ToString();
      }
      /// <summary>
      /// Show the about form
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void aboutPicFaceToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new FormAboutPicface().ShowDialog();
      }
      /// <summary>
      /// Saves Data recursive
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonSaveRecursive_Click(object sender, EventArgs e)
      {
         new FormRecursiveHandling(_CurrentDirectory, _Contacts).Show();
      }

   }
}

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

namespace PicFace
{
   public partial class FormMain : Form
   {
      #region Fields
      private ContactTable _Contacts;
      private string _CurrentDirectory;
      private PictureList _PictureList;
      #endregion
      public FormMain()
      {
         InitializeComponent();
      }

      private void FormMain_Load(object sender, EventArgs e)
      {
         // Refresh contacts first
         buttonRefreshContacts_Click(sender, e);
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
      /// Show info about the contact
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
         _PictureList = new PictureList(_CurrentDirectory, _Contacts);
         listBoxFiles.Items.Clear();
         foreach (Picture p in _PictureList)
         {
            listBoxFiles.Items.Add(p);
         }
      }
      /// <summary>
      /// Selected Index changed
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
      {
         Picture p = listBoxFiles.SelectedItem as Picture;
         if (p != null)
         {
            pictureBoxPreview.Load (Path.Combine(_CurrentDirectory, p.FileName));
            listBoxPersonsFound.Items.Clear();
            foreach (Face f in p.Faces)
            {
               listBoxPersonsFound.Items.Add(f);
            }
         }
      }
   }
}

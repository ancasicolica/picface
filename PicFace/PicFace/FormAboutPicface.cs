using System;
using System.Reflection;
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
   partial class FormAboutPicface : Form
   {
      public FormAboutPicface()
      {
         InitializeComponent();
         this.Text = String.Format("About {0}", AssemblyTitle);
         this.labelProductName.Text = AssemblyProduct;
         this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
         this.labelCopyright.Text = AssemblyCopyright;
         this.labelCompanyName.Text = "Visit www.kusti.ch for more information";
         this.textBoxDescription.Text = "This is open source and freeware";
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += "Using this tool on your own risk, any damaged or lost data is only in YOUR responsibility!";
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += "Used components:";
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += "ExifTool by Phil Harvey";
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += "Json.NET by James Newton-King";
         this.textBoxDescription.Text += Environment.NewLine;
         this.textBoxDescription.Text += "Thanks to their great work!!";
      }

      #region Assembly Attribute Accessors

      public string AssemblyTitle
      {
         get
         {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0)
            {
               AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
               if (titleAttribute.Title != "")
               {
                  return titleAttribute.Title;
               }
            }
            return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
         }
      }

      public string AssemblyVersion
      {
         get
         {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
         }
      }

      public string AssemblyDescription
      {
         get
         {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (attributes.Length == 0)
            {
               return "";
            }
            return ((AssemblyDescriptionAttribute)attributes[0]).Description;
         }
      }

      public string AssemblyProduct
      {
         get
         {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
               return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
         }
      }

      public string AssemblyCopyright
      {
         get
         {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
            {
               return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
         }
      }

      public string AssemblyCompany
      {
         get
         {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (attributes.Length == 0)
            {
               return "";
            }
            return ((AssemblyCompanyAttribute)attributes[0]).Company;
         }
      }
      #endregion

      private void AboutBox1_Load(object sender, EventArgs e)
      {

      }

      private void logoPictureBox_Click(object sender, EventArgs e)
      {

      }
   }
}

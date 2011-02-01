using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
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
namespace PicFace.Framework
{
   /// <summary>
   /// This class saves the properties of the Sim-Windows in the registry
   /// </summary>
   public class WindowProperties
   {
      /// <summary>
      /// The form
      /// </summary>
      private System.Windows.Forms.Form _WorkingForm;
      /// <summary>
      /// The registry key
      /// </summary>
      private string _RegistryKey;
      /// <summary>
      /// The registry object
      /// </summary>
      private RegistryKey _Registry;
      /// <summary>
      /// The size of the Window
      /// </summary>
      public Size WindowSize
      {
         get
         {
            if (_Registry.GetValue("Height") != null)
            { // the value exits
               return new Size((int)_Registry.GetValue("Width"), (int)_Registry.GetValue("Height"));
            }
            else
            { // set to minimal size
               return _WorkingForm.MinimumSize;
            }
         }
         set
         {
            if (value.Width >= _WorkingForm.MinimumSize.Width)
            {
               _Registry.SetValue("Width", value.Width);
            }
            if (value.Height >= _WorkingForm.MinimumSize.Height)
            {
               _Registry.SetValue("Height", value.Height);
            }
         }
      }
      /// <summary>
      /// Coordinates of the window
      /// </summary>
      public Point Location
      {
         get
         {
            if (_Registry.GetValue("X") != null)
            {
               // The value exists; move the form to the coordinates stored in the
               // registry.
               return new Point((int)_Registry.GetValue("X"), (int)_Registry.GetValue("Y"));
            }
            else
            { // set to center screen and store in the registry
               this.Location = new Point(_WorkingForm.Location.X, _WorkingForm.Location.Y);
            }
            return this.Location;
         }
         set
         {
            if (value.X > 0 && value.Y < Screen.PrimaryScreen.Bounds.Right)
            {
               _Registry.SetValue("X", value.X);
            }
            else
            { // Check, if default values must be set
               if (_Registry.GetValue("X") == null)
               {
                  _Registry.SetValue("X", 0);
               }
            }
            if (value.X > 0 && value.Y < Screen.PrimaryScreen.Bounds.Bottom)
            {
               _Registry.SetValue("Y", value.Y);
            }
            else
            {  // Check, if default values must be set
               if (_Registry.GetValue("Y") == null)
               {
                  _Registry.SetValue("Y", 0);
               }
            }
         }
      }
      /// <summary>
      /// The window state
      /// </summary>
      public FormWindowState WindowState
      {
         get
         {
            if (_Registry.GetValue("WindowState") != null)
            {
               // The value exists; move the form to the coordinates stored in the
               // registry.
               return (FormWindowState)Enum.Parse(typeof(FormWindowState), (string)_Registry.GetValue("WindowState"));
            }
            else
            { // set to center screen and store in the registry
               this.WindowState = FormWindowState.Normal;
            }
            return this.WindowState;
         }
         set
         {
            _Registry.SetValue("WindowState", value);
         }
      }
      /// <summary>
      /// The default constructor
      /// </summary>
      /// <param name="form">Pointer to the form</param>
      public WindowProperties(System.Windows.Forms.Form form)
      {
         _WorkingForm = form;

         _RegistryKey = RegistryAccess._RegistryKeyRoot + "Forms\\" + form.Name;
         _Registry = Registry.CurrentUser.OpenSubKey(_RegistryKey, true);
         if (_Registry == null)
         {
            // The key doesn't exist; create it / open it
            _Registry = Registry.CurrentUser.CreateSubKey(_RegistryKey);
         }

         _WorkingForm.Location = this.Location;
         _WorkingForm.WindowState = this.WindowState;
         _WorkingForm.Size = this.WindowSize;
         _WorkingForm.LocationChanged += new EventHandler(m_Form_LocationChanged);
         _WorkingForm.SizeChanged += new EventHandler(m_Form_SizeChanged);

      }
      /// <summary>
      /// The location of the form changed
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void m_Form_LocationChanged(object sender, EventArgs e)
      {
         this.Location = _WorkingForm.Location;
      }
      /// <summary>
      /// Sets the window state
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void m_Form_SizeChanged(object sender, EventArgs e)
      {
         this.WindowSize = _WorkingForm.Size;
         this.WindowState = _WorkingForm.WindowState;
      }
   }
}

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
using System.Drawing;
using System.Windows.Forms;
using PicFace.Generic;

namespace PicFace
{
   /// <summary>
   /// This class does everything to mark a file on a picture box
   /// </summary>
   internal class FaceToPictureBox
   {
      #region Fields
      private PictureBox _PictureBox;
      private string _FileName;
      private Image _Image;
      private Graphics _Graphics;
      private Pen _RectanglePen;
      #endregion
      /// <summary>
      /// File name (including path)
      /// </summary>
      public string FileName
      {
         get
         {
            return _FileName;
         }
         set
         {
            try
            {
               if (_Image != null)
               {
                  _Image.Dispose();
               }
               if (_Graphics != null)
               {
                  _Graphics.Dispose();
               }
            }
            catch
            { }
            _FileName = value;
            _Image = Image.FromFile(_FileName);
            _PictureBox.Image = _Image;
            _Graphics = Graphics.FromImage(_Image);
         }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="pictureBox">Picturebox to use</param>
      public FaceToPictureBox(PictureBox pictureBox)
      {
         _PictureBox = pictureBox;
         _RectanglePen = new Pen(Color.Red, 5);
      }
      /// <summary>
      /// Draw the face
      /// </summary>
      /// <param name="face">face to draw</param>
      public void DrawFace(Face face)
      {
         _Graphics = Graphics.FromImage(_Image);
         int x = (int)(face.Rect.X * _Image.Width);
         int w = (int)(face.Rect.Width * _Image.Width);
         int y = (int)(face.Rect.Y * _Image.Height);
         int h = (int)(face.Rect.Height * _Image.Height);

         _Graphics.DrawRectangle(_RectanglePen, x,y,w,h);
         _PictureBox.Refresh();
      }
      /// <summary>
      /// Releases all picture Data so the file is free for saving data
      /// </summary>
      public void ReleasePicture()
      {
         if (_Image != null)
         {
            _Image.Dispose();
         }
         if (_Graphics != null)
         {
            _Graphics.Dispose();
         }
         _PictureBox.Image = null;
      }
   }
}

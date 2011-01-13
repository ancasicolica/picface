using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
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
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using System.Drawing;
using System.Windows.Forms;

namespace PicFace.Generic
{
   /// <summary>
   /// This class shows the faces and compares them
   /// </summary>
   internal class FaceViewer : FaceMerger
   {
      private Image _Photo;
      private Pen _Pen;
      private SolidBrush _Brush;
      private Graphics _Graphic;
      /// <summary>
      /// The photo data belonging to this faces
      /// </summary>
      public Image Photo
      {
         get
         {
            return _Photo;
         }
      }
      /// <summary>
      /// Constructor: the ExifTool data is loaded when creating this picture
      /// </summary>
      /// <param name="pic">Picture</param>
      public FaceViewer(Picture pic): base(pic)
      {
         _Photo = Image.FromFile(pic.FullFileName);
        
         _Pen = new Pen(Color.Red, 12);
         _Brush  = new SolidBrush(Color.Red);  
      }
      /// <summary>
      /// Mouse is moving over the picture
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      internal void OnMouseMove(PictureBox sender, MouseEventArgs args)
      {
         // Paint Rectangle for persons

        // _Graphic = sender.CreateGraphics();
         _Graphic = Graphics.FromImage(_Photo);
         foreach (Face f in base.PicasaFaces)
         {

            _Graphic.DrawRectangle(_Pen, f.Rect.X * _Photo.Width,
               f.Rect.Y * _Photo.Height,
               (f.Rect.Width - f.Rect.X) * _Photo.Width,
               (f.Rect.Height - f.Rect.Y) * _Photo.Height);

            _Graphic.DrawString(f.Name, new Font("Arial", 12), _Brush, f.Rect.X * _Photo.Width, f.Rect.Y * _Photo.Height);
         }
         sender.Refresh();
      }
   }
}

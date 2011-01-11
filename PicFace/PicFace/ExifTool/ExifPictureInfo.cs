using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Generic;
using System.Drawing;
using System.Diagnostics;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Picture Info read out from Exif Tool
   /// </summary>
   internal class ExifPictureInfo : PictureInfo
   {
      /// <summary>
      /// default constructor
      /// </summary>
      public ExifPictureInfo() : base()
      {

      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="etp">source file where data was read out</param>
      public ExifPictureInfo(ExifToolPictureData etp) : base(etp.SourceFile)
      {
         foreach (Region r in etp.RegionInfo.Regions)
         {
            try
            {
               string[] rect = r.Rectangle.Split(new char[] { ',' });
               float x, y, w, h;
               x = Convert.ToSingle(rect[0]);
               y = Convert.ToSingle(rect[1]);
               w = Convert.ToSingle(rect[2]);
               h = Convert.ToSingle(rect[3]);
               Face f = new Face(r.PersonDisplayName, new RectangleF(x,y,w,h));
               Faces.Add(f);
            }
            catch
            {
               Debug.WriteLine(etp.SourceFile + " not added to ExifPictureInfo");
            }
         }
      }
   }
}

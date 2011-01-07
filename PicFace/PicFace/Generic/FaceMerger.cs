using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;

namespace PicFace.Generic
{
   /// <summary>
   /// This class compares two faces, one from picasa and one from exiftool
   /// </summary>
   internal class FaceMerger
   {
      private FaceList _PicasaFaces;
      private FaceList _ExifToolFaces;
      /// <summary>
      /// Faces found with Picasa
      /// </summary>
      public FaceList PicasaFaces
      {
         get
         {
            return _PicasaFaces;
         }
      }
      /// <summary>
      /// Faces found with ExifTool
      /// </summary>
      public FaceList ExifToolFaces
      {
         get
         {
            return _ExifToolFaces;
         }
      }
      /// <summary>
      /// Constructor: the ExifTool data is loaded when creating this picture
      /// </summary>
      /// <param name="pic"></param>
      public FaceMerger(Picture pic)
      {
         _PicasaFaces = new FaceList(pic.Faces);
      }
   }
}

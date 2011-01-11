using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PicFace.Generic
{
   /// <summary>
   /// Picture Information
   /// </summary>
   abstract internal class PictureInfo
   {
      /// <summary>
      /// Name of the file
      /// </summary>
      public string FileName { get; set; }
      /// <summary>
      /// Name of the file including the path
      /// </summary>
      public string FullFileName { get; set; }
      /// <summary>
      /// Faces of the Picture
      /// </summary>
      public FaceList Faces { get; set; }
      /// <summary>
      /// Default constructor
      /// </summary>
      public PictureInfo()
      {
         Faces = new FaceList();
      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="path">Full path and name</param>
      public PictureInfo(string path)
      {
         FileName = Path.GetFileName(path);
         FullFileName = path;
         Faces = new FaceList();
      }
      /// <summary>
      /// File Name
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return FileName;
      }
   }
}

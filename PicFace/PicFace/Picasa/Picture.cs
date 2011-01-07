using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is the class for one picture (file) with all its information read out
   /// from .picasa.ini
   /// </summary>
   internal class Picture
   {
      #region Fields
      /// <summary>
      /// Faces we do not know
      /// </summary>
      private int _UnknownFaces;
      #endregion
      /// <summary>
      /// The faces found
      /// </summary>
      public PicasaFaceList Faces { get; set; }
      /// <summary>
      /// Name of the file
      /// </summary>
      public string FileName { get; set; }
      /// <summary>
      /// Name of the file including the path
      /// </summary>
      public string FullFileName { get; set; }
      /// <summary>
      /// How many faces are there we do not know?
      /// </summary>
      public int UnkownFaces
      {
         get
         {
            return _UnknownFaces;
         }
      }
      /// <summary>
      /// Default constructor
      /// </summary>
      public Picture()
      {
         Faces = new PicasaFaceList();
         FileName = "";
         _UnknownFaces = 0;
      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="path">Full path and name</param>
      public Picture(string path)
      {
         FileName = Path.GetFileName(path);
         FullFileName = path;
         _UnknownFaces = 0;
         Faces = new PicasaFaceList();
      }
      /// <summary>
      /// File Name
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return FileName;
      }
      /// <summary>
      /// We found a face not known
      /// </summary>
      public void UnkownFaceFound()
      {
         _UnknownFaces++;
      }
   }
}

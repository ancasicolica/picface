using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
      public List<Face> Faces { get; set; }
      /// <summary>
      /// Name of the file
      /// </summary>
      public string FileName { get; set; }
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
         Faces = new List<Face>();
         FileName = "";
         _UnknownFaces = 0;
      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="fileName">File name, no path</param>
      public Picture(string fileName)
      {
         FileName = fileName;
         _UnknownFaces = 0;
         Faces = new List<Face>();
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

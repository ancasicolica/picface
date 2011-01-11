using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using PicFace.Generic;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is the class for one picture (file) with all its information read out
   /// from .picasa.ini
   /// </summary>
   internal class PicasaPictureInfo : PictureInfo
   {
      #region Fields
      /// <summary>
      /// Faces we do not know
      /// </summary>
      private int _UnknownFaces;
      #endregion
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
      public PicasaPictureInfo() : base()
      {
         _UnknownFaces = 0;
      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="path">Full path and name</param>
      public PicasaPictureInfo(string path) : base(path)
      {
         _UnknownFaces = 0;
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

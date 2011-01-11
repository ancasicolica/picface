using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicFace.Generic
{
   /// <summary>
   /// Base Class for all PictureInfo Lists
   /// </summary>
   internal class PictureInfoList:List<PictureInfo>
   {
      #region Fields
      private string _Path;
      #endregion

      #region Properties
      /// <summary>
      /// Path where the files reside
      /// </summary>
      public string Directory
      {
         get
         {
            return _Path;
         }
      }
      #endregion
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="path">Path where the picutures reside</param>
      public PictureInfoList(string path)
      {
         _Path = path;
      }
      /// <summary>
      /// Contains the list an image file with a given name?
      /// </summary>
      /// <param name="file">file name</param>
      /// <returns>true: the answer is yes!</returns>
      public bool Contains(string file)
      {
         foreach (PictureInfo info in this)
         {
            if (info.FileName.ToUpper().Equals(file.ToUpper()))
            {
               return true;
            }
         }
         return false;
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicFace.Generic
{
   /// <summary>
   /// Base Class for all PictureInfo Lists
   /// </summary>
   internal class PictureInfoList:Dictionary<string, PictureInfo>
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
   }
}

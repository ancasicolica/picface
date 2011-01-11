using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;

namespace PicFace.Generic
{
   /// <summary>
   /// This class contains all pictures of a directory 
   /// </summary>
   internal class PictureList
   {
      private PicasaPictureInfoList _PicasaPictures;
      private ExifPictureInfoList _ExifPictures;
      private List<PictureComparer> _ConsolidatedList;
      private string _Path;
      /// <summary>
      /// Path where the pictures were found
      /// </summary>
      public string Path
      {
         get
         {
            return _Path;
         }
      }
      /// <summary>
      /// Picasa Pictures
      /// </summary>
      public PicasaPictureInfoList PicasaPictures 
      { 
         get
         {
            return _PicasaPictures;
         }
      }
      /// <summary>
      /// Exif Pictures
      /// </summary>
      public ExifPictureInfoList ExifPictures
      {
         get
         {
            return _ExifPictures;
         }
      }
      /// <summary>
      /// List containing every picture with a face in it, not depending if the source was picasa or exif
      /// </summary>
      public List<PictureComparer> ConsolidatedList
      {
         get
         {
            return _ConsolidatedList;
         }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="path">Path where the pictures are</param>
      public PictureList(string path, ContactTable contacts)
      {
         _Path = path;
         _PicasaPictures = new PicasaPictureInfoList(path, contacts);
         _ExifPictures = new ExifPictureInfoList(path);
         _ConsolidatedList = new List<PictureComparer>();


      }
   }
}

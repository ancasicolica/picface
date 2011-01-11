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
      private Dictionary<string, PictureComparer> _ConsolidatedList;
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
      public Dictionary<string, PictureComparer> ConsolidatedList
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
         _ConsolidatedList = new Dictionary<string, PictureComparer>();

         // add first all picasa pictures
         foreach (KeyValuePair<string, PictureInfo> entry in _PicasaPictures)
         {
            PictureComparer pc = new PictureComparer();
            pc.PicasaInfo = entry.Value as PicasaPictureInfo;
            _ConsolidatedList.Add(entry.Key, pc);
         }
         // now add all pictures having exiftool information
         foreach (KeyValuePair<string, PictureInfo> entry in _ExifPictures)
         {
            if (_ConsolidatedList.ContainsKey(entry.Key))
            {
               _ConsolidatedList[entry.Key].ExifInfo = entry.Value as ExifPictureInfo;
            }
            else
            {
               PictureComparer pc = new PictureComparer();
               pc.ExifInfo = entry.Value as ExifPictureInfo;
               _ConsolidatedList.Add(entry.Key, pc);
            }
         }
      }
   }
}

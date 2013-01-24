/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2011 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

      LICENSE TERMS

       The redistribution and use of this software (with or without changes)
       is allowed without the payment of fees or royalties provided that:

        1. source code distributions include the above copyright notice, this
           list of conditions and the following disclaimer; 

        2. binary distributions include the above copyright notice, this list
           of conditions and the following disclaimer in their documentation;

        3. the name of the copyright holder is not used to endorse products
           built using this software without specific written permission.

       DISCLAIMER

       This software is provided 'as is' with no explicit or implied warranties
       in respect of its properties, including, but not limited to, correctness
       and/or fitness for purpose. 
*/
/************************************************************************************/
using System.IO;

namespace PicFace.Generic
{
   /// <summary>
   /// Picture Information
   /// </summary>
   internal class PictureInfo
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
      /// Faces of the Picture read out from Picasa
      /// </summary>
      public FaceList PicasaFaces { get; set; }
      /// <summary>
      /// Faces of the Picture read out from XMP
      /// </summary>
      public FaceList XmpFaces { get; set; }
      /// <summary>
      /// Default constructor
      /// </summary>
      public PictureInfo()
      {
         XmpFaces = new FaceList();
         PicasaFaces = new FaceList();
      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="path">Full path and name</param>
      public PictureInfo(string path)
      {
         FileName = Path.GetFileName(path);
         FullFileName = path;
         XmpFaces = new FaceList();
         PicasaFaces = new FaceList();
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

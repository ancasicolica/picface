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

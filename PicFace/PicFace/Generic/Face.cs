using PicFace.ExifTool;
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
using System;
using System.Drawing;

namespace PicFace.Generic
{
   /// <summary>
   /// This class is defining a face: a name belongig to it and where it is found
   /// </summary>
   internal class Face : IComparable
   {
      /// <summary>
      /// Rectangle where the face is found. This rectangle is defined by relative values
      /// in the range from 0 to 1. This allows to draw the rectangle on every resized image.
      /// </summary>
      public RectangleF Rect { get; set; }
      /// <summary>
      /// Name of the person
      /// </summary>
      public string Name { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      public Face()
      {
         Name = "";
         Rect = new RectangleF();
      }
      /// <summary>
      /// Specialised constructor for a face read out with exiftool and written by Picasa
      /// </summary>
      /// <param name="region">Face information, including area and name</param>
      /// <param name="dimensions">Dimensions of the complete image</param>
      public Face(ExifTool.Region region, RegionInfoDimensions dimensions)
      {
      }
      /// <summary>
      /// Specialised constructor for a face read out with exiftool and written in XMP (eg with Microsoft tools)
      /// </summary>
      /// <param name="region">Face information, including area and name</param>
      public Face(RegionMp region)
      {
      }

      /// <summary>
      /// Specialised Constructor
      /// </summary>
      /// <param name="name">Name</param>
      /// <param name="rect">Rectangle</param>
      public Face(string name, RectangleF rect)
      {
         Name = name;
         Rect = rect;
      }
      /// <summary>
      /// ToString Override
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Name;
      }
      #region IComparable Members
      /// <summary>
      /// IComparable
      /// </summary>
      /// <param name="obj">Other face</param>
      /// <returns>According to CompareTo</returns>
      int IComparable.CompareTo(object obj)
      {
         Face f = obj as Face;
         if (f != null)
         {
            return Name.CompareTo(f.Name);
         }
         return 0;
      }

      #endregion
   }
}

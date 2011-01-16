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
using System.Diagnostics;
using System.Drawing;
using PicFace.Generic;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Picture Info read out from Exif Tool
   /// </summary>
   internal class ExifPictureInfo : PictureInfo
   {
      /// <summary>
      /// default constructor
      /// </summary>
      public ExifPictureInfo() : base()
      {

      }
      /// <summary>
      /// Specialised constructor
      /// </summary>
      /// <param name="etp">source file where data was read out</param>
      public ExifPictureInfo(ExifToolPictureData etp) : base(etp.SourceFile)
      {
         foreach (Region r in etp.RegionInfo.Regions)
         {
            try
            {
               string[] rect = r.Rectangle.Split(new char[] { ',' });
               float x, y, w, h;
               x = Convert.ToSingle(rect[0]);
               y = Convert.ToSingle(rect[1]);
               w = Convert.ToSingle(rect[2]);
               h = Convert.ToSingle(rect[3]);
               Face f = new Face(r.PersonConvertedName, new RectangleF(x, y, w, h));
               if (f.Name != null && !f.Name.Equals("ffffffffffffffff"))
               {
                  Faces.Add(f.Name, f);
               }
            }
            catch
            {
               Debug.WriteLine(etp.SourceFile + " not added to ExifPictureInfo");
            }
         }
      }
   }
}

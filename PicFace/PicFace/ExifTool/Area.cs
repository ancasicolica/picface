/************************************************************************************/
/*
      PicFace - Writes Picasa face information to XMP 
      Copyright (C) 2013 Christian Kuster, CH-8342 Wernetshausen, www.kusti.ch

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

namespace Kusti.PicFaceLib.ExifTool
{
   /// <summary>
   /// This is an AREA written in the Picasa Tag "RegionInfo / RegionList"
   /// 
   /// The rectangle is defined in a rather special way: X and Y define the center
   /// of the rectangle, W and H width and heigth
   /// </summary>
   public class AreaData
   {
      /// <summary>
      /// The HEIGHT of the rectangle
      /// </summary>
      public float H { get; set; }
      /// <summary>
      /// The UNIT, we expect so far only the value "NORMALIZED"
      /// </summary>
      public string Unit { get; set; }
      /// <summary>
      /// The WIDTH of the rectangle
      /// </summary>
      public float W { get; set; }
      /// <summary>
      /// The X center point of the rectangle
      /// </summary>
      public float X { get; set; }
      /// <summary>
      /// The Y center point of the rectangle
      /// </summary>
      public float Y { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      public AreaData()
      {

      }
   }
}

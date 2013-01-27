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
using System.Collections.Generic;

namespace Kusti.PicFaceLib.Generic
{
   /// <summary>
   /// A Dictionary for faces. The Key is the name
   /// </summary>
   internal class FaceList:Dictionary<string, Face>
   {
      /// <summary>
      /// Default constructor
      /// </summary>
      public FaceList()
      {
        
      }
      /// <summary>
      /// Override to simplify adding faces
      /// </summary>
      /// <param name="face">Face to add</param>
      public void Add(Face face)
      {
         base.Add(face.Name, face);
      }
      /// <summary>
      /// Builds a list where all Elements are listed beeing different as in "two" (would be
      /// written into "two")
      /// </summary>
      /// <param name="two"></param>
      /// <returns></returns>
      public FaceList BuildDeltaList(FaceList two)
      {
         return null;
      }
 
   }
}

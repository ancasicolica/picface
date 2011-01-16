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
using System.Drawing;
using PicFace.Generic;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is one face found on a picture
   /// </summary>
   internal class PicasaFace : Face
   {
      private Contact _Person;
      /// <summary>
      /// Person found, must never be null
      /// </summary>
      public Contact Person
      {
         get
         {
            return _Person;
         }
         set
         {
            _Person = value;
            base.Name = _Person.Name;
         }
      }
      /// <summary>
      /// Default Constructor
      /// </summary>
      public PicasaFace():base("", new RectangleF())
      {
         Person = new Contact("", "no name", "", null);
      }
      /// <summary>
      /// Specialised Constructor
      /// </summary>
      /// <param name="person">Contact</param>
      /// <param name="rect">Rectangle</param>
      public PicasaFace(Contact person, RectangleF rect) : base(person.Name, rect)
      {
         Rect = rect;
         Person = person;
      }
      /// <summary>
      /// ToString Override for a face - use Person
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Person.Name;
      }
   }
}

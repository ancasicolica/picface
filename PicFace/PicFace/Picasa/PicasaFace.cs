using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

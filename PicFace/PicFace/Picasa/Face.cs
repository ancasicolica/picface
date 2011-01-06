using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is one face found on a picture
   /// </summary>
   internal class Face
   {
      /// <summary>
      /// Rectangle where the face is found
      /// </summary>
      public RectangleF Rect { get; set; }
      /// <summary>
      /// Person found
      /// </summary>
      public Contact Person { get; set; }
      /// <summary>
      /// Default Constructor
      /// </summary>
      public Face()
      {
         Rect = new RectangleF((float)0.0, (float)0.0, (float)0.0, (float)0.0);
         Person = new Contact("", "no name", "", null);
      }
      /// <summary>
      /// Specialised Constructor
      /// </summary>
      /// <param name="person"></param>
      /// <param name="rect"></param>
      public Face(Contact person, RectangleF rect)
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

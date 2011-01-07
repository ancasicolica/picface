using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PicFace.Generic
{
   /// <summary>
   /// This class is defining a face: a name belongig to it and where it is found
   /// </summary>
   internal class Face
   {
      /// <summary>
      /// Rectangle where the face is found
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
      public Face(string name, RectangleF rect)
      {
         Name = name;
         Rect = rect;
      }
   }
}

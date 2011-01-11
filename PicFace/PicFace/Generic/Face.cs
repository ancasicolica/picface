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
   internal class Face : IComparable
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

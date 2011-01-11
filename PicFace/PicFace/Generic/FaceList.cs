using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;

namespace PicFace.Generic
{
   /// <summary>
   /// A list for faces
   /// </summary>
   internal class FaceList:List<Face>
   {
      /// <summary>
      /// Default constructor
      /// </summary>
      public FaceList()
      {

      }
      /// <summary>
      /// Constructor for picasa faces
      /// </summary>
      /// <param name="faces">Faces found from picasa</param>
      public FaceList(PicasaFaceList faces)
      {
         foreach (Face face in faces)
         {
            this.Add(face);
         }
      }
 
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Picasa;
using PicFace.ExifTool;

namespace PicFace.Generic
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
      /// Constructor for picasa faces
      /// </summary>
      /// <param name="faces">Faces found from picasa</param>
      public FaceList(PicasaFaceList faces)
      {
         foreach (Face face in faces)
         {
            this.Add(face.Name, face);
         }
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

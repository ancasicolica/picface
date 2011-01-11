using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicFace.ExifTool
{
   /// <summary>
   /// Region for a person information. Naming after Exif Tool terms (JSON Format)
   /// </summary>
   public class Region
   {
      public string PersonDisplayName { get; set; }
      public string Rectangle { get; set; }
      public Region()
      {

      }
   }
}

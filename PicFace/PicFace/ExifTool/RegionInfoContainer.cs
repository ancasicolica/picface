using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicFace.ExifTool
{
   /// <summary>
   /// RegionInfo Container, needed by JSON format
   /// </summary>
   public class RegionInfoContainer
   {
      public Region[] Regions { get; set; }
      public RegionInfoContainer()
      {

      }
   }
}

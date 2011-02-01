using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Framework;
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
namespace PicFace
{
   /// <summary>
   /// The configuration which is saved in the registry
   /// </summary>
   internal class PicFaceConfig
   {
      private static RegistryAccess _Registry;
      /// <summary>
      /// The registry object, created the first time needed
      /// </summary>
      public static RegistryAccess Registry
      {
         get
         {
            if (_Registry == null)
            {
               _Registry = new RegistryAccess("Configuration");
            }
            return _Registry;
         }
      }
      /// <summary>
      /// Enum for the file view
      /// </summary>
      public enum FileViewSettings
      {
         // Show all
         All,
         // show changed
         OnlyChanged
      };
      /// <summary>
      /// Settings about the file view: all or only changed?
      /// </summary>
      public static FileViewSettings FileView
      {
         get
         {
            try
            {
               return (FileViewSettings)Enum.Parse(typeof(FileViewSettings),
                  Registry.Read<string>("FileView", FileViewSettings.OnlyChanged.ToString()));
            }
            catch
            {
               return FileViewSettings.OnlyChanged;
            }
         }
         set
         {
            Registry.Write<string>("FileView", value.ToString());
         }
      }
   }
}

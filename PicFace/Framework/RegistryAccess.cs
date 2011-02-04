using Microsoft.Win32;
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
namespace PicFace.Framework
{
   /// <summary>
   /// Class providing registry access
   /// </summary>
   internal class RegistryAccess
   {
      /// <summary>
      /// The registry key
      /// </summary>
      private string _RegistryKey;
      /// <summary>
      /// The registry object
      /// </summary>
      private RegistryKey _Registry;
      /// <summary>
      /// The registry key used from the SmartClient
      /// </summary>
      public static string _RegistryKeyRoot = "Software\\kusti.ch\\PicFace\\";
      /// <summary>
      /// The registry key used from the SmartClient
      /// </summary>
      internal static string RegistryKeyRoot
      {
         get
         {
            return _RegistryKeyRoot;
         }
      }
      /// <summary>
      /// Default constructor for data in the root of the key
      /// </summary>
      public RegistryAccess() : this(null)
      {

      }
      /// <summary>
      /// Default constructor
      /// </summary>
      /// <param name="subkey">Subkey to the rootkey, null if none</param>
      public RegistryAccess(string subkey)
      {
         if (subkey != null)
         {
            _RegistryKey = _RegistryKeyRoot + subkey;
         }
         else
         {
            _RegistryKey = _RegistryKeyRoot;
         }

         _Registry = Registry.CurrentUser.OpenSubKey(_RegistryKey, true);
         if (_Registry == null)
         {
            // The key doesn't exist; create it / open it
            _Registry = Registry.CurrentUser.CreateSubKey(_RegistryKey);
         }
      }
      /// <summary>
      /// Write a value
      /// </summary>
      /// <param name="valueName">Name of the value</param>
      /// <param name="value">value</param>
      public void Write<T>(string valueName, T value)
      {
         _Registry.SetValue(valueName, value);
      }
      /// <summary>
      /// Reads a value
      /// </summary>
      /// <param name="valueName">Name of the value (key)</param>
      /// <param name="defaultValue">Value to use if not present</param>
      /// <returns>value</returns>
      public T Read<T>(string valueName, T defaultValue)
      {
         object val = _Registry.GetValue(valueName);
         if (val == null)
         {
            _Registry.SetValue(valueName, defaultValue);
            return defaultValue;
         }
         return (T)val;
      }
   }
}

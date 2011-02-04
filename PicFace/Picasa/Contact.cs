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
using System;

namespace PicFace.Picasa
{
   /// <summary>
   /// This is a contact read out from Picasa
   /// </summary>
   internal class Contact
   {
      #region Fields
      private string _Name;
      private string _Display;
      private string _Id;
      private DateTime _Modified;
      #endregion
      /// <summary>
      /// Name of the contact
      /// </summary>
      public string Name
      {
         get
         {
            return _Name;
         }
      }
      /// <summary>
      /// Display name (nick name)
      /// </summary>
      public string Display
      {
         get
         {
            return _Display;
         }
      }
      /// <summary>
      /// ID of the contact, used as identifier in ContactTable
      /// </summary>
      public string Id
      {
         get
         {
            return _Id;
         }
      }
      /// <summary>
      /// Modification Date
      /// </summary>
      public DateTime Modified
      {
         get
         {
            return _Modified;
         }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="id">ID</param>
      /// <param name="name">Name</param>
      /// <param name="display">Display Name</param>
      /// <param name="modified_time">Modified time as read out from the picasa XML</param>
      public Contact(string id, string name, string display, string modified_time)
      {
         _Id = id;
         _Name = name;
         _Display = display;
         
         try
         {
            // format: 2011-01-01T20:55:14+01:00
            if (modified_time != null)
            {
               _Modified = DateTime.Parse(modified_time);
            }
            else
            {
               _Modified = DateTime.MinValue;
            }
         }
         catch
         {
            _Modified = DateTime.MinValue;
         }
      }
      /// <summary>
      /// ToString override, primary for debugging
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Name;
      }
   }
}

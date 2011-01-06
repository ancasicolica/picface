using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

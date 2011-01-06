using System.Collections.Generic;

namespace PicFace.Picasa
{
   /// <summary>
   /// The contact table is a dictionary, nothing else...
   /// </summary>
   internal class ContactTable : Dictionary<string, Contact>
   {
      /// <summary>
      /// Constructor
      /// </summary>
      public ContactTable()
      {

      }
      /// <summary>
      /// Add a Contact
      /// </summary>
      /// <param name="contact">contact</param>
      public void Add(Contact contact)
      {
         base.Add(contact.Id, contact);
      }
   }
}

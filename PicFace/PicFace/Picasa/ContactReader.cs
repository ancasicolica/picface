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
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace PicFace.Picasa
{
   /// <summary>
   /// Reader (or fabrication) for person data from picasa
   /// </summary>
   internal class ContactReader
   {
      /// <summary>
      /// The default file where the picasa contact xml resides
      /// </summary>
      static public string PicasaDefaultPersonFile
      {
         get
         {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
               @"Google\Picasa2\contacts\contacts.xml");
         }
      }
      /// <summary>
      /// Read the whole file
      /// </summary>
      /// <param name="file">Complete file name to read out</param>
      /// <returns>The table with all contacts</returns>
      static public ContactTable Read(string file)
      {
         XmlDocument doc = new XmlDocument();
         ContactTable contacts = new ContactTable();

         try
         {
            doc.Load(file);
         }
         catch (Exception ex)
         {
            Debug.WriteLine(ex.Message);
            return null;
         }

         XmlElement root = doc.DocumentElement;
         foreach (XmlNode @daten in root.ChildNodes)
         {
            // the read out attributes
            string id, name, modified_time, display;
            
            // try to assign every attribute
            try
            {
               id = @daten.Attributes["id"].InnerText;
            }
            catch
            {
               id = null;
            }
            try
            {
               name = @daten.Attributes["name"].InnerText;
            }
            catch
            {
               name = "";
            }
            try
            {
             //  display = @daten.Attributes["display"].InnerText;
               display = "";
            }
            catch
            {
               display = "";
            }
            try
            {
               modified_time = @daten.Attributes["modified_time"].InnerText;
            }
            catch
            {
               modified_time = "";
            }

            // filter out invalid values. the "ffffffffffffffff" seems to be an ignored
            // entry in picasa, but it is not a name anyway!
            if (id != null && name.Length > 0 && !name.Equals("ffffffffffffffff"))
            {
               contacts.Add(new Contact(id, name, display, modified_time));
            }
         }
         return contacts;   
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Diagnostics;

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
               display = @daten.Attributes["display"].InnerText;
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

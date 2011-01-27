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
using System.Drawing;
using System.IO;
using PicFace.Generic;

namespace PicFace.Picasa
{
   /// <summary>
   /// List with all Pictures read out from .picasa.ini. Only real existing files
   /// are included in the list, no orphans.
   /// </summary>
   internal class PicasaPictureInfoList:PictureInfoList
   {
      /// <summary>
      /// Builds a picture list for a given path
      /// </summary>
      /// <param name="path">Path of the picture, must contain the .picasa.ini file</param>
      public PicasaPictureInfoList(string path, ContactTable contacts):base(path)
      {
         ReadPicasaIniFile(path, contacts);
      }
      /// <summary>
      /// Read the .picasa.ini File and set up the list
      /// </summary>
      /// <param name="path">path where the pictures are</param>
      /// <param name="contacts">contact table</param>
      private void ReadPicasaIniFile(string path, ContactTable contacts)
      {
         try
         {
            string picasaFileName = @".picasa.ini"; // this is the default
            if (!File.Exists(Path.Combine(path, picasaFileName)))
            { // is there an older one?
               if (File.Exists(Path.Combine(path, @"Picasa.ini")))
               {
                  picasaFileName = @"Picasa.ini";
               }
               else
               {
                  Debug.WriteLine("No Picasa INI File found in " + path);
                  return;
               }
            }
            // Read Picasa File
            using (StreamReader sr = new StreamReader(Path.Combine(path, picasaFileName)))
            {
               PicasaPictureInfo currentPic = null;
               string line;
               string name;
               bool lookForFaces = false;
               while ((line = sr.ReadLine()) != null)
               {
                  if (line.StartsWith("[") && line.ToUpper().EndsWith("JPG]"))
                  { // this is a new jpg found, remember name
                     name = line.Trim(new char[] { ' ', '[', ']' });

                     if (File.Exists(Path.Combine(path, name)))
                     { // yes, the file exists, check for faces
                        lookForFaces = true;
                        currentPic = new PicasaPictureInfo(Path.Combine(path, name));
                        this.Add(currentPic.FileName.ToUpper(), currentPic);
                     }
                     else
                     { // no, this one is not here anymore
                        lookForFaces = false;
                        currentPic = null;
                     }

                  }
                  else if (lookForFaces)
                  { // one line to check
                     if (line.StartsWith("faces"))
                     { // yeah, got it!
                        string faceInfo = line.Substring(line.IndexOf('=') + 1);
                        string[] faces = faceInfo.Split(new char[] { ';' });

                        // now we have this: rect64(88a863f492dd7678),9118590a35b8e7c0
                        foreach (string face in faces)
                        {
                           string[] p = face.Split(new char[] { ',' });
                           string id = p[1];
                           if (contacts.ContainsKey(id) && (currentPic != null))
                           {
                              string rectInfo = p[0].Remove(0, 6);
                              rectInfo = rectInfo.Trim(new char[] { '(', ')' });
                              while (rectInfo.Length < 16)
                              {
                                 rectInfo = "0" + rectInfo;
                              }
                              float x = (float)Convert.ToInt32(rectInfo.Substring(0, 4), 16) / 0xffff;
                              float y = (float)Convert.ToInt32(rectInfo.Substring(4, 4), 16) / 0xffff;

                              float w = (float)Convert.ToInt32(rectInfo.Substring(8, 4), 16) / 0xffff;
                              float h = (float)Convert.ToInt32(rectInfo.Substring(12, 4), 16) / 0xffff;

                              // Picasa stores not witdh and height, it stores the corners!
                              w = w - x;
                              h = h - y;

                              RectangleF rect = new RectangleF(x, y, w, h);

                              PicasaFace f = new PicasaFace(contacts[id], rect);
                              if (!currentPic.Faces.ContainsKey(f.Name))
                              {
                                 currentPic.Faces.Add(f.Name, f);
                                 Debug.WriteLine(currentPic.FileName + ", Known one: " + f.Name, "PicasaPictureInfoList");
                              }
                              else
                              {
                                 Debug.WriteLine(currentPic.FileName + ", Name found twice: " + f.Name);
                              }
                           }
                           else
                           {  // we don't know this one!
                              Debug.WriteLine(currentPic.FileName + ", Unkown one: " + id, "PicasaPictureInfoList");
                              currentPic.UnkownFaceFound();
                           }
                        }
                     }
                  }
               }
            }
         

         }
         catch (Exception ex)
         {
            Debug.WriteLine(ex.Message, "PictureList");
            // rather no items than an invalid list!
            this.Clear();
         }
      }
   }
}

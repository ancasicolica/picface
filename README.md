If you use the face feature in Picasa, all your information is stored in the .picasa.ini file - not in your picture.
This tool reads the .picasa.ini file and writes the data into your picture using XMP.

Naming a baby is always a dificult thing and there is (nearly) no difference in giving a new tool a name. So I decided to concatenate "Pic" (for Picasa or Picture if you like) and "Face" for this purpose. And because it sounds a bit like the front of a little lovely animal, the icon was defined too ;-)

The code was previously hosted in Google Code. As this service is shutting down, and I have some downloads over the time, I decided to 
move the code to GitHub even I have no plans to work on it.

##Development status
I stopped the development in lack of time. The tool remains available "as it is".

PicFace is written in C# and .NET 3.5 (Visual Studio 2008)

##Licence
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

##3rd party code
There are two parts of the tool not programmed by myself:

 * ExifTool by Phil Harvey: http://www.sno.phy.queensu.ca/~phil/exiftool/
 * Json.NET by James Newton-King: http://json.codeplex.com

Both authors allow the restribution of their distributables in their licence. 

## UPDATE Jan 2013
I intend to do some additional work, using .NET 4.5 and the tags written by Picasa. Please do not download the source code now as it is "work in progress"... :-)

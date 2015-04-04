# Updating face information #

When faces are edited in Picasa, the data is stored immediately in the file .picasa.ini. But when a file containing XMP information is imported in Picasa, then the information about persons is **NOT** found in .picasa.ini, it seems that this information is stored directly in the database.

**Conclusion**: PicFace has to read both sources, Picasa XML and XMP information and merge them. Otherwise original XMP data (the one before importing the picture in Picasa) would be lost.

# Directories & Files #
## .picasa.ini ##
In every directory scanned by Picasa a file named .picasa.ini is found. Apart from other information, the face data is stored in this file.
One entry looks like this:
```
[sample.jpg]
faces=rect64(8fff3b55aaff6655),e4ba239ff4d9c754;rect64(31803000490055aa),5e4bfd2dda491a06
```
The file sample.jpg contains two faces, identified by a rectangle (rect64, see section below) and an indentifier which is found in contacts.xml again.

An ignored face has the identifier ffffffffffffffff which says Picasa not to ask about this face again. There are other tools saving this FF-value in the XMP data (what I do honestly not understand...) while PicFace ignores these faces.
Sample for an image with ignored faces:
```
[DSC_4237.JPG]
backuphash=45464
faces=rect64(a57b50c6af19587a),ffffffffffffffff;rect64(54c346916baf58c6),e858f49763540226;
```

## contacts.xml ##
An XML file mapping the IDs found in .picasa.ini to real names is found in the users local application data directory.
Currently, PicFace has a fix implementation for this path.
```
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
```
If any problems occur with this fix implementation, let me know.

The XML file has a quite simple structure, see one example entry:
```
 <contact id="7ee0fdd21564ad63" name="Fidelis Custor" display="Fidelis" modified_time="2011-01-09T13:07:46+01:00" sync_enabled="0"/>
```
PicFace interprets only the "id" (which is the same as in .picasa.ini) and the "name", all others are not needed for XMP tagging.
# Data formats #
This section is about special data handling of Picasa data structures.
## rect64 ##
The rect64 structure conists of 16 characters in the range of {0-9a-f} to be interpreted as four unsigned 16 bit integers. As the rectangle of a face is saved as relative value (range 0...1), the value has to be divided by 0xffff to get the position.
While a rectangle in XMP (and C# as well) is defined by upper left corner X/Y the rectangles height and weight, Picasa choosed another format: upper left corner X/Y and lower right corner X/Y.

See the implementation for details:
```
string rectInfo = "8fff3b55aaff6655";
float x = (float)Convert.ToInt32(rectInfo.Substring(0, 4), 16) / 0xffff;
float y = (float)Convert.ToInt32(rectInfo.Substring(4, 4), 16) / 0xffff;

float w = (float)Convert.ToInt32(rectInfo.Substring(8, 4), 16) / 0xffff;
float h = (float)Convert.ToInt32(rectInfo.Substring(12, 4), 16) / 0xffff;

w = w - x;
h = h - y;

RectangleF rect = new RectangleF(x, y, w, h);
```

Don't count on 16 characters in rect64 - there are no leading zeros for the first value if it is less than 0x1000.
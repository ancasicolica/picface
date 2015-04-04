# A little help for a self explaining tool (at least so far...)

# Installation #

Download the latest MSI Installer file from the Downloads page and follow the instructions.


# Using PicFace #

  * After starting the tool, select a folder with pictures in it using either the menu bar ("File"...) or the button "Change Directory").
  * On the left you see all files having face information, either read from Picasa or ExifTool (XMP data). The files marked with (`*`) are not up to date and would be changed when pressing the button "Save Data".
  * To verify the faces read from Picasa and XMP, select an entry in the file list and change to the tab "Image".
  * If you agree with the changes, press "Save Data" to write the XMP information. If there are any changes in Picasa, press "Refresh" to read the data again.
  * All read contacts are found in the "Contacts" tab.
  * The log of ExifTool is found in the "Log" tab. If you have any problems saving data, this log data is a good debugging source in your trouble ticket.

# Some nice things to know #
  * Picasa is always considered as master. If a face has not the same name in Picasa and XMP, the data from Picasa will overwrite the XMP data.
  * Some older versions of Picasa did not write the face information in the .picasa.ini file. In this case **no face information can be read from Picasa**. You have to reset the face information in Picasa and tag the faces again, otherwise PicFace won't be able to read any Picasa Information.
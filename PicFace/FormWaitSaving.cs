using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicFace.Generic;
using System.Threading;

namespace PicFace
{
   /// <summary>
   /// This is the form showed when saving data
   /// </summary>
   class FormWaitSaving : FormWait
   {
      /// <summary>
      /// The picture list to save
      /// </summary>
      public PictureList Pictures { get; private set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="pictures"></param>
      public FormWaitSaving(PictureList pictures)
      {
         Pictures = pictures;
      }
      /// <summary>
      /// Loading the form: start saving data
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      internal override void FormWait_Load(object sender, EventArgs e)
      {
         base.FormWait_Load(sender, e);
         progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         labelAction.Text = "Please wait... Saving faces to pictures";

         Pictures.Saved += new PictureList.OnSaved(Pictures_Saved);
         Pictures.PictureSaved += new PictureList.OnPictureSaved(Pictures_PictureSaved);
         // start a new thread to give the control enough time to display the nice 
         // progress bar
         Thread savingThread = new Thread(new ThreadStart(CollectionSaver));
         savingThread.Name = "Collector Saver";
         savingThread.IsBackground = true;
         savingThread.Start();
         this.TaskFinished += new TaskFinishedHandler(OnTaskFinished);
      }
      /// <summary>
      /// One picture was saved
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void Pictures_PictureSaved(object sender, OnPictureSavedEventArgs args)
      {
         if (this.InvokeRequired)
         {// Make sure we run on UI thread
            // Create a delegate to self 
            PictureList.OnPictureSaved safeEvent = new PictureList.OnPictureSaved(Pictures_PictureSaved);
            // Roll arguments in an Object array
            Object[] arguments = new Object[] {sender, args };

            // "Recurse once, onto another thread"
            this.Invoke(safeEvent, arguments);
            return;
         }
         progressBar1.Value = args.PercentDone;
         labelInfo.Text = args.FileName;
      }
      /// <summary>
      /// All pictures are saved
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void Pictures_Saved(object sender, OnPictureListSavedEventArgs args)
      {
         FireTaskFinishedEvent();
      }
      /// <summary>
      /// Thread saving data
      /// </summary>
      private void CollectionSaver()
      {
         Pictures.SaveChangedData();
      }
   }
}

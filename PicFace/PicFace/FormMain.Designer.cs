namespace PicFace
{
   partial class FormMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryInMyPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutPicFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tabControlContacts = new System.Windows.Forms.TabControl();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.listBoxFiles = new System.Windows.Forms.ListBox();
         this.textBoxDirectory = new System.Windows.Forms.TextBox();
         this.labelDirectory = new System.Windows.Forms.Label();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.listBoxPersonsFoundXmp = new System.Windows.Forms.ListBox();
         this.groupBoxPicasa = new System.Windows.Forms.GroupBox();
         this.listBoxPersonsFound = new System.Windows.Forms.ListBox();
         this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
         this.tabPageContacts = new System.Windows.Forms.TabPage();
         this.labelContactNb = new System.Windows.Forms.Label();
         this.labelContactInfo = new System.Windows.Forms.Label();
         this.listBoxContacts = new System.Windows.Forms.ListBox();
         this.buttonRefreshContacts = new System.Windows.Forms.Button();
         this.labelContactsFile = new System.Windows.Forms.Label();
         this.listBoxFilesChanged = new System.Windows.Forms.ListBox();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         this.groupBoxFilesWithFaces = new System.Windows.Forms.GroupBox();
         this.groupBoxAllFiles = new System.Windows.Forms.GroupBox();
         this.listBoxAllFiles = new System.Windows.Forms.ListBox();
         this.buttonSaveChangedData = new System.Windows.Forms.Button();
         this.tabPageLog = new System.Windows.Forms.TabPage();
         this.textBoxLog = new System.Windows.Forms.TextBox();
         this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
         this.buttonRefresh = new System.Windows.Forms.Button();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.tabControlContacts.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBoxPicasa.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
         this.tabPageContacts.SuspendLayout();
         this.groupBoxFilesWithFaces.SuspendLayout();
         this.groupBoxAllFiles.SuspendLayout();
         this.tabPageLog.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
         this.statusStrip1.Location = new System.Drawing.Point(0, 480);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(670, 22);
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(670, 24);
         this.menuStrip1.TabIndex = 2;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDirectoryInMyPicturesToolStripMenuItem,
            this.selectDirectoryToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // selectDirectoryInMyPicturesToolStripMenuItem
         // 
         this.selectDirectoryInMyPicturesToolStripMenuItem.Name = "selectDirectoryInMyPicturesToolStripMenuItem";
         this.selectDirectoryInMyPicturesToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
         this.selectDirectoryInMyPicturesToolStripMenuItem.Text = "Select Directory in \"My Pictures\"";
         this.selectDirectoryInMyPicturesToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryInMyPicturesToolStripMenuItem_Click);
         // 
         // selectDirectoryToolStripMenuItem
         // 
         this.selectDirectoryToolStripMenuItem.Name = "selectDirectoryToolStripMenuItem";
         this.selectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
         this.selectDirectoryToolStripMenuItem.Text = "Select Directory";
         this.selectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryToolStripMenuItem_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPicFaceToolStripMenuItem});
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
         this.toolStripMenuItem1.Text = "?";
         // 
         // aboutPicFaceToolStripMenuItem
         // 
         this.aboutPicFaceToolStripMenuItem.Name = "aboutPicFaceToolStripMenuItem";
         this.aboutPicFaceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
         this.aboutPicFaceToolStripMenuItem.Text = "About PicFace";
         // 
         // tabControlContacts
         // 
         this.tabControlContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControlContacts.Controls.Add(this.tabPage2);
         this.tabControlContacts.Controls.Add(this.tabPage1);
         this.tabControlContacts.Controls.Add(this.tabPageContacts);
         this.tabControlContacts.Controls.Add(this.tabPageLog);
         this.tabControlContacts.Location = new System.Drawing.Point(168, 24);
         this.tabControlContacts.Name = "tabControlContacts";
         this.tabControlContacts.SelectedIndex = 0;
         this.tabControlContacts.Size = new System.Drawing.Size(502, 456);
         this.tabControlContacts.TabIndex = 3;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.buttonRefresh);
         this.tabPage2.Controls.Add(this.buttonSaveChangedData);
         this.tabPage2.Controls.Add(this.groupBoxAllFiles);
         this.tabPage2.Controls.Add(this.groupBoxFilesWithFaces);
         this.tabPage2.Controls.Add(this.textBoxDirectory);
         this.tabPage2.Controls.Add(this.labelDirectory);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Size = new System.Drawing.Size(494, 430);
         this.tabPage2.TabIndex = 2;
         this.tabPage2.Text = "Info";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // listBoxFiles
         // 
         this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBoxFiles.FormattingEnabled = true;
         this.listBoxFiles.Location = new System.Drawing.Point(3, 16);
         this.listBoxFiles.Name = "listBoxFiles";
         this.listBoxFiles.Size = new System.Drawing.Size(233, 342);
         this.listBoxFiles.Sorted = true;
         this.listBoxFiles.TabIndex = 4;
         // 
         // textBoxDirectory
         // 
         this.textBoxDirectory.Location = new System.Drawing.Point(62, 3);
         this.textBoxDirectory.Name = "textBoxDirectory";
         this.textBoxDirectory.ReadOnly = true;
         this.textBoxDirectory.Size = new System.Drawing.Size(418, 20);
         this.textBoxDirectory.TabIndex = 3;
         // 
         // labelDirectory
         // 
         this.labelDirectory.AutoSize = true;
         this.labelDirectory.Location = new System.Drawing.Point(4, 6);
         this.labelDirectory.Name = "labelDirectory";
         this.labelDirectory.Size = new System.Drawing.Size(52, 13);
         this.labelDirectory.TabIndex = 2;
         this.labelDirectory.Text = "Directory:";
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.groupBox1);
         this.tabPage1.Controls.Add(this.groupBoxPicasa);
         this.tabPage1.Controls.Add(this.pictureBoxPreview);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(494, 430);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Image";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.listBoxPersonsFoundXmp);
         this.groupBox1.Location = new System.Drawing.Point(263, 339);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(223, 100);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "XMP Faces";
         // 
         // listBoxPersonsFoundXmp
         // 
         this.listBoxPersonsFoundXmp.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBoxPersonsFoundXmp.FormattingEnabled = true;
         this.listBoxPersonsFoundXmp.Location = new System.Drawing.Point(3, 16);
         this.listBoxPersonsFoundXmp.MultiColumn = true;
         this.listBoxPersonsFoundXmp.Name = "listBoxPersonsFoundXmp";
         this.listBoxPersonsFoundXmp.Size = new System.Drawing.Size(217, 69);
         this.listBoxPersonsFoundXmp.Sorted = true;
         this.listBoxPersonsFoundXmp.TabIndex = 4;
         this.listBoxPersonsFoundXmp.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonsFound_SelectedIndexChanged);
         // 
         // groupBoxPicasa
         // 
         this.groupBoxPicasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxPicasa.Controls.Add(this.listBoxPersonsFound);
         this.groupBoxPicasa.Location = new System.Drawing.Point(10, 339);
         this.groupBoxPicasa.Name = "groupBoxPicasa";
         this.groupBoxPicasa.Size = new System.Drawing.Size(247, 100);
         this.groupBoxPicasa.TabIndex = 5;
         this.groupBoxPicasa.TabStop = false;
         this.groupBoxPicasa.Text = "Picasa Faces";
         // 
         // listBoxPersonsFound
         // 
         this.listBoxPersonsFound.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBoxPersonsFound.FormattingEnabled = true;
         this.listBoxPersonsFound.Location = new System.Drawing.Point(3, 16);
         this.listBoxPersonsFound.MultiColumn = true;
         this.listBoxPersonsFound.Name = "listBoxPersonsFound";
         this.listBoxPersonsFound.Size = new System.Drawing.Size(241, 69);
         this.listBoxPersonsFound.Sorted = true;
         this.listBoxPersonsFound.TabIndex = 4;
         this.listBoxPersonsFound.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonsFound_SelectedIndexChanged);
         // 
         // pictureBoxPreview
         // 
         this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBoxPreview.Location = new System.Drawing.Point(10, 6);
         this.pictureBoxPreview.Name = "pictureBoxPreview";
         this.pictureBoxPreview.Size = new System.Drawing.Size(470, 327);
         this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBoxPreview.TabIndex = 3;
         this.pictureBoxPreview.TabStop = false;
         this.pictureBoxPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPreview_MouseMove);
         // 
         // tabPageContacts
         // 
         this.tabPageContacts.Controls.Add(this.labelContactNb);
         this.tabPageContacts.Controls.Add(this.labelContactInfo);
         this.tabPageContacts.Controls.Add(this.listBoxContacts);
         this.tabPageContacts.Controls.Add(this.buttonRefreshContacts);
         this.tabPageContacts.Controls.Add(this.labelContactsFile);
         this.tabPageContacts.Location = new System.Drawing.Point(4, 22);
         this.tabPageContacts.Name = "tabPageContacts";
         this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageContacts.Size = new System.Drawing.Size(494, 430);
         this.tabPageContacts.TabIndex = 1;
         this.tabPageContacts.Text = "Contacts";
         this.tabPageContacts.UseVisualStyleBackColor = true;
         // 
         // labelContactNb
         // 
         this.labelContactNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.labelContactNb.Location = new System.Drawing.Point(377, 407);
         this.labelContactNb.Name = "labelContactNb";
         this.labelContactNb.Size = new System.Drawing.Size(100, 23);
         this.labelContactNb.TabIndex = 4;
         this.labelContactNb.Text = "0 Contacts";
         this.labelContactNb.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // labelContactInfo
         // 
         this.labelContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.labelContactInfo.AutoSize = true;
         this.labelContactInfo.Location = new System.Drawing.Point(8, 407);
         this.labelContactInfo.Name = "labelContactInfo";
         this.labelContactInfo.Size = new System.Drawing.Size(10, 13);
         this.labelContactInfo.TabIndex = 3;
         this.labelContactInfo.Text = "-";
         // 
         // listBoxContacts
         // 
         this.listBoxContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listBoxContacts.FormattingEnabled = true;
         this.listBoxContacts.Location = new System.Drawing.Point(8, 36);
         this.listBoxContacts.MultiColumn = true;
         this.listBoxContacts.Name = "listBoxContacts";
         this.listBoxContacts.Size = new System.Drawing.Size(469, 368);
         this.listBoxContacts.Sorted = true;
         this.listBoxContacts.TabIndex = 2;
         this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
         // 
         // buttonRefreshContacts
         // 
         this.buttonRefreshContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonRefreshContacts.Location = new System.Drawing.Point(405, 7);
         this.buttonRefreshContacts.Name = "buttonRefreshContacts";
         this.buttonRefreshContacts.Size = new System.Drawing.Size(75, 23);
         this.buttonRefreshContacts.TabIndex = 1;
         this.buttonRefreshContacts.Text = "refresh";
         this.buttonRefreshContacts.UseVisualStyleBackColor = true;
         this.buttonRefreshContacts.Click += new System.EventHandler(this.buttonRefreshContacts_Click);
         // 
         // labelContactsFile
         // 
         this.labelContactsFile.AutoSize = true;
         this.labelContactsFile.Location = new System.Drawing.Point(8, 12);
         this.labelContactsFile.Name = "labelContactsFile";
         this.labelContactsFile.Size = new System.Drawing.Size(35, 13);
         this.labelContactsFile.TabIndex = 0;
         this.labelContactsFile.Text = "label1";
         // 
         // listBoxFilesChanged
         // 
         this.listBoxFilesChanged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.listBoxFilesChanged.FormattingEnabled = true;
         this.listBoxFilesChanged.Location = new System.Drawing.Point(0, 27);
         this.listBoxFilesChanged.Name = "listBoxFilesChanged";
         this.listBoxFilesChanged.Size = new System.Drawing.Size(162, 446);
         this.listBoxFilesChanged.Sorted = true;
         this.listBoxFilesChanged.TabIndex = 2;
         this.listBoxFilesChanged.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
         this.listBoxFilesChanged.DoubleClick += new System.EventHandler(this.listBoxFilesChanged_DoubleClick);
         // 
         // groupBoxFilesWithFaces
         // 
         this.groupBoxFilesWithFaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxFilesWithFaces.Controls.Add(this.listBoxFiles);
         this.groupBoxFilesWithFaces.Location = new System.Drawing.Point(7, 56);
         this.groupBoxFilesWithFaces.Name = "groupBoxFilesWithFaces";
         this.groupBoxFilesWithFaces.Size = new System.Drawing.Size(239, 371);
         this.groupBoxFilesWithFaces.TabIndex = 6;
         this.groupBoxFilesWithFaces.TabStop = false;
         this.groupBoxFilesWithFaces.Text = "Files with face information";
         // 
         // groupBoxAllFiles
         // 
         this.groupBoxAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxAllFiles.Controls.Add(this.listBoxAllFiles);
         this.groupBoxAllFiles.Location = new System.Drawing.Point(247, 56);
         this.groupBoxAllFiles.Name = "groupBoxAllFiles";
         this.groupBoxAllFiles.Size = new System.Drawing.Size(239, 371);
         this.groupBoxAllFiles.TabIndex = 7;
         this.groupBoxAllFiles.TabStop = false;
         this.groupBoxAllFiles.Text = "All JPG files found in directory";
         // 
         // listBoxAllFiles
         // 
         this.listBoxAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
         this.listBoxAllFiles.FormattingEnabled = true;
         this.listBoxAllFiles.Location = new System.Drawing.Point(3, 16);
         this.listBoxAllFiles.Name = "listBoxAllFiles";
         this.listBoxAllFiles.Size = new System.Drawing.Size(233, 342);
         this.listBoxAllFiles.Sorted = true;
         this.listBoxAllFiles.TabIndex = 4;
         // 
         // buttonSaveChangedData
         // 
         this.buttonSaveChangedData.Location = new System.Drawing.Point(62, 29);
         this.buttonSaveChangedData.Name = "buttonSaveChangedData";
         this.buttonSaveChangedData.Size = new System.Drawing.Size(75, 23);
         this.buttonSaveChangedData.TabIndex = 8;
         this.buttonSaveChangedData.Text = "Save Data";
         this.buttonSaveChangedData.UseVisualStyleBackColor = true;
         this.buttonSaveChangedData.Click += new System.EventHandler(this.buttonSaveChangedData_Click);
         // 
         // tabPageLog
         // 
         this.tabPageLog.Controls.Add(this.textBoxLog);
         this.tabPageLog.Location = new System.Drawing.Point(4, 22);
         this.tabPageLog.Name = "tabPageLog";
         this.tabPageLog.Size = new System.Drawing.Size(494, 430);
         this.tabPageLog.TabIndex = 3;
         this.tabPageLog.Text = "Log";
         this.tabPageLog.UseVisualStyleBackColor = true;
         // 
         // textBoxLog
         // 
         this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxLog.Location = new System.Drawing.Point(0, 0);
         this.textBoxLog.MaxLength = 327670;
         this.textBoxLog.Multiline = true;
         this.textBoxLog.Name = "textBoxLog";
         this.textBoxLog.Size = new System.Drawing.Size(494, 430);
         this.textBoxLog.TabIndex = 0;
         // 
         // toolStripStatusLabelInfo
         // 
         this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
         this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabelInfo.Text = "toolStripStatusLabel1";
         // 
         // buttonRefresh
         // 
         this.buttonRefresh.Location = new System.Drawing.Point(143, 29);
         this.buttonRefresh.Name = "buttonRefresh";
         this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
         this.buttonRefresh.TabIndex = 9;
         this.buttonRefresh.Text = "Refresh";
         this.buttonRefresh.UseVisualStyleBackColor = true;
         this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(670, 502);
         this.Controls.Add(this.tabControlContacts);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.listBoxFilesChanged);
         this.MainMenuStrip = this.menuStrip1;
         this.MinimumSize = new System.Drawing.Size(680, 540);
         this.Name = "FormMain";
         this.Text = "PicFace";
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.tabControlContacts.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.tabPage1.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBoxPicasa.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
         this.tabPageContacts.ResumeLayout(false);
         this.tabPageContacts.PerformLayout();
         this.groupBoxFilesWithFaces.ResumeLayout(false);
         this.groupBoxAllFiles.ResumeLayout(false);
         this.tabPageLog.ResumeLayout(false);
         this.tabPageLog.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem aboutPicFaceToolStripMenuItem;
      private System.Windows.Forms.TabControl tabControlContacts;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPageContacts;
      private System.Windows.Forms.Button buttonRefreshContacts;
      private System.Windows.Forms.Label labelContactsFile;
      private System.Windows.Forms.Label labelContactInfo;
      private System.Windows.Forms.ListBox listBoxContacts;
      private System.Windows.Forms.Label labelContactNb;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem selectDirectoryInMyPicturesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem selectDirectoryToolStripMenuItem;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
      private System.Windows.Forms.PictureBox pictureBoxPreview;
      private System.Windows.Forms.ListBox listBoxFilesChanged;
      private System.Windows.Forms.ListBox listBoxPersonsFound;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ListBox listBoxPersonsFoundXmp;
      private System.Windows.Forms.GroupBox groupBoxPicasa;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ListBox listBoxFiles;
      private System.Windows.Forms.TextBox textBoxDirectory;
      private System.Windows.Forms.Label labelDirectory;
      private System.Windows.Forms.GroupBox groupBoxAllFiles;
      private System.Windows.Forms.ListBox listBoxAllFiles;
      private System.Windows.Forms.GroupBox groupBoxFilesWithFaces;
      private System.Windows.Forms.Button buttonSaveChangedData;
      private System.Windows.Forms.TabPage tabPageLog;
      private System.Windows.Forms.TextBox textBoxLog;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
      private System.Windows.Forms.Button buttonRefresh;
   }
}


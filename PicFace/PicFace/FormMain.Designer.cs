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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryInMyPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.allFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.filesWithChangedFaceInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutPicFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tabControlContacts = new System.Windows.Forms.TabControl();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.buttonSaveRecursive = new System.Windows.Forms.Button();
         this.buttonChangeDirectory = new System.Windows.Forms.Button();
         this.labelPicturesWithChangedInformationNb = new System.Windows.Forms.Label();
         this.labelPicsWithFaceInfoNb = new System.Windows.Forms.Label();
         this.labelTotalPicsNb = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.buttonRefresh = new System.Windows.Forms.Button();
         this.buttonSaveChangedData = new System.Windows.Forms.Button();
         this.textBoxDirectory = new System.Windows.Forms.TextBox();
         this.labelDirectory = new System.Windows.Forms.Label();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.listBoxResult = new System.Windows.Forms.ListBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.listBoxPersonsFoundXmp = new System.Windows.Forms.ListBox();
         this.groupBoxPicasa = new System.Windows.Forms.GroupBox();
         this.listBoxPersonsFound = new System.Windows.Forms.ListBox();
         this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
         this.tabPageLog = new System.Windows.Forms.TabPage();
         this.textBoxLog = new System.Windows.Forms.TextBox();
         this.listBoxFilesChanged = new System.Windows.Forms.ListBox();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.tabControlContacts.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBoxPicasa.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
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
         // toolStripStatusLabelInfo
         // 
         this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
         this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabelInfo.Text = "toolStripStatusLabel1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
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
         // viewToolStripMenuItem
         // 
         this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFilesToolStripMenuItem,
            this.filesWithChangedFaceInformationToolStripMenuItem});
         this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
         this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.viewToolStripMenuItem.Text = "View";
         // 
         // allFilesToolStripMenuItem
         // 
         this.allFilesToolStripMenuItem.Name = "allFilesToolStripMenuItem";
         this.allFilesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
         this.allFilesToolStripMenuItem.Text = "all files with faces";
         this.allFilesToolStripMenuItem.Click += new System.EventHandler(this.allFilesToolStripMenuItem_Click);
         // 
         // filesWithChangedFaceInformationToolStripMenuItem
         // 
         this.filesWithChangedFaceInformationToolStripMenuItem.Checked = true;
         this.filesWithChangedFaceInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.filesWithChangedFaceInformationToolStripMenuItem.Name = "filesWithChangedFaceInformationToolStripMenuItem";
         this.filesWithChangedFaceInformationToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
         this.filesWithChangedFaceInformationToolStripMenuItem.Text = "files with changed face information";
         this.filesWithChangedFaceInformationToolStripMenuItem.Click += new System.EventHandler(this.filesWithChangedFaceInformationToolStripMenuItem_Click);
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
         this.aboutPicFaceToolStripMenuItem.Click += new System.EventHandler(this.aboutPicFaceToolStripMenuItem_Click);
         // 
         // tabControlContacts
         // 
         this.tabControlContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControlContacts.Controls.Add(this.tabPage2);
         this.tabControlContacts.Controls.Add(this.tabPage1);
         this.tabControlContacts.Controls.Add(this.tabPageLog);
         this.tabControlContacts.Location = new System.Drawing.Point(168, 24);
         this.tabControlContacts.Name = "tabControlContacts";
         this.tabControlContacts.SelectedIndex = 0;
         this.tabControlContacts.Size = new System.Drawing.Size(502, 456);
         this.tabControlContacts.TabIndex = 3;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.buttonSaveRecursive);
         this.tabPage2.Controls.Add(this.buttonChangeDirectory);
         this.tabPage2.Controls.Add(this.labelPicturesWithChangedInformationNb);
         this.tabPage2.Controls.Add(this.labelPicsWithFaceInfoNb);
         this.tabPage2.Controls.Add(this.labelTotalPicsNb);
         this.tabPage2.Controls.Add(this.label3);
         this.tabPage2.Controls.Add(this.label2);
         this.tabPage2.Controls.Add(this.label1);
         this.tabPage2.Controls.Add(this.buttonRefresh);
         this.tabPage2.Controls.Add(this.buttonSaveChangedData);
         this.tabPage2.Controls.Add(this.textBoxDirectory);
         this.tabPage2.Controls.Add(this.labelDirectory);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Size = new System.Drawing.Size(494, 430);
         this.tabPage2.TabIndex = 2;
         this.tabPage2.Text = "Info";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // buttonSaveRecursive
         // 
         this.buttonSaveRecursive.Location = new System.Drawing.Point(234, 28);
         this.buttonSaveRecursive.Name = "buttonSaveRecursive";
         this.buttonSaveRecursive.Size = new System.Drawing.Size(98, 23);
         this.buttonSaveRecursive.TabIndex = 17;
         this.buttonSaveRecursive.Text = "Save Recursive";
         this.buttonSaveRecursive.UseVisualStyleBackColor = true;
         this.buttonSaveRecursive.Click += new System.EventHandler(this.buttonSaveRecursive_Click);
         // 
         // buttonChangeDirectory
         // 
         this.buttonChangeDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonChangeDirectory.Location = new System.Drawing.Point(364, 29);
         this.buttonChangeDirectory.Name = "buttonChangeDirectory";
         this.buttonChangeDirectory.Size = new System.Drawing.Size(116, 23);
         this.buttonChangeDirectory.TabIndex = 16;
         this.buttonChangeDirectory.Text = "Change Directory";
         this.buttonChangeDirectory.UseVisualStyleBackColor = true;
         this.buttonChangeDirectory.Click += new System.EventHandler(this.buttonChangeDirectory_Click);
         // 
         // labelPicturesWithChangedInformationNb
         // 
         this.labelPicturesWithChangedInformationNb.AutoSize = true;
         this.labelPicturesWithChangedInformationNb.Location = new System.Drawing.Point(217, 131);
         this.labelPicturesWithChangedInformationNb.Name = "labelPicturesWithChangedInformationNb";
         this.labelPicturesWithChangedInformationNb.Size = new System.Drawing.Size(13, 13);
         this.labelPicturesWithChangedInformationNb.TabIndex = 15;
         this.labelPicturesWithChangedInformationNb.Text = "0";
         // 
         // labelPicsWithFaceInfoNb
         // 
         this.labelPicsWithFaceInfoNb.AutoSize = true;
         this.labelPicsWithFaceInfoNb.Location = new System.Drawing.Point(217, 107);
         this.labelPicsWithFaceInfoNb.Name = "labelPicsWithFaceInfoNb";
         this.labelPicsWithFaceInfoNb.Size = new System.Drawing.Size(13, 13);
         this.labelPicsWithFaceInfoNb.TabIndex = 14;
         this.labelPicsWithFaceInfoNb.Text = "0";
         // 
         // labelTotalPicsNb
         // 
         this.labelTotalPicsNb.AutoSize = true;
         this.labelTotalPicsNb.Location = new System.Drawing.Point(217, 82);
         this.labelTotalPicsNb.Name = "labelTotalPicsNb";
         this.labelTotalPicsNb.Size = new System.Drawing.Size(13, 13);
         this.labelTotalPicsNb.TabIndex = 13;
         this.labelTotalPicsNb.Text = "0";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(4, 131);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(169, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "Pictures with changed information:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(195, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "Pictures with Picasa or face information:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(4, 82);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(102, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "Pictures in directory:";
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
         // textBoxDirectory
         // 
         this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
         this.tabPage1.Controls.Add(this.groupBox2);
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
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.listBoxResult);
         this.groupBox2.Location = new System.Drawing.Point(354, 339);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(126, 100);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Result";
         // 
         // listBoxResult
         // 
         this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBoxResult.FormattingEnabled = true;
         this.listBoxResult.Location = new System.Drawing.Point(3, 16);
         this.listBoxResult.MultiColumn = true;
         this.listBoxResult.Name = "listBoxResult";
         this.listBoxResult.Size = new System.Drawing.Size(120, 81);
         this.listBoxResult.Sorted = true;
         this.listBoxResult.TabIndex = 4;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.listBoxPersonsFoundXmp);
         this.groupBox1.Location = new System.Drawing.Point(182, 339);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(166, 100);
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
         this.listBoxPersonsFoundXmp.Size = new System.Drawing.Size(160, 81);
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
         this.groupBoxPicasa.Size = new System.Drawing.Size(169, 100);
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
         this.listBoxPersonsFound.Size = new System.Drawing.Size(163, 81);
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
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(670, 502);
         this.Controls.Add(this.tabControlContacts);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.listBoxFilesChanged);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
         this.groupBox2.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBoxPicasa.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
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
      private System.Windows.Forms.TextBox textBoxDirectory;
      private System.Windows.Forms.Label labelDirectory;
      private System.Windows.Forms.Button buttonSaveChangedData;
      private System.Windows.Forms.TabPage tabPageLog;
      private System.Windows.Forms.TextBox textBoxLog;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
      private System.Windows.Forms.Button buttonRefresh;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.ListBox listBoxResult;
      private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem allFilesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem filesWithChangedFaceInformationToolStripMenuItem;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label labelPicturesWithChangedInformationNb;
      private System.Windows.Forms.Label labelPicsWithFaceInfoNb;
      private System.Windows.Forms.Label labelTotalPicsNb;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button buttonChangeDirectory;
      private System.Windows.Forms.Button buttonSaveRecursive;
   }
}


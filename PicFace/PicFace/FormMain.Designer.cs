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
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutPicFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tabControlContacts = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPageContacts = new System.Windows.Forms.TabPage();
         this.labelContactNb = new System.Windows.Forms.Label();
         this.labelContactInfo = new System.Windows.Forms.Label();
         this.listBoxContacts = new System.Windows.Forms.ListBox();
         this.buttonRefreshContacts = new System.Windows.Forms.Button();
         this.labelContactsFile = new System.Windows.Forms.Label();
         this.labelDirectory = new System.Windows.Forms.Label();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryInMyPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         this.textBoxDirectory = new System.Windows.Forms.TextBox();
         this.listBoxFiles = new System.Windows.Forms.ListBox();
         this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
         this.listBoxPersonsFound = new System.Windows.Forms.ListBox();
         this.menuStrip1.SuspendLayout();
         this.tabControlContacts.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPageContacts.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Location = new System.Drawing.Point(0, 480);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(664, 22);
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
         this.menuStrip1.Size = new System.Drawing.Size(664, 24);
         this.menuStrip1.TabIndex = 2;
         this.menuStrip1.Text = "menuStrip1";
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
         this.tabControlContacts.Controls.Add(this.tabPage1);
         this.tabControlContacts.Controls.Add(this.tabPageContacts);
         this.tabControlContacts.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControlContacts.Location = new System.Drawing.Point(0, 24);
         this.tabControlContacts.Name = "tabControlContacts";
         this.tabControlContacts.SelectedIndex = 0;
         this.tabControlContacts.Size = new System.Drawing.Size(664, 456);
         this.tabControlContacts.TabIndex = 3;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.listBoxPersonsFound);
         this.tabPage1.Controls.Add(this.pictureBoxPreview);
         this.tabPage1.Controls.Add(this.listBoxFiles);
         this.tabPage1.Controls.Add(this.textBoxDirectory);
         this.tabPage1.Controls.Add(this.labelDirectory);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(656, 430);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
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
         this.tabPageContacts.Size = new System.Drawing.Size(656, 430);
         this.tabPageContacts.TabIndex = 1;
         this.tabPageContacts.Text = "Contacts";
         this.tabPageContacts.UseVisualStyleBackColor = true;
         // 
         // labelContactNb
         // 
         this.labelContactNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.labelContactNb.Location = new System.Drawing.Point(545, 407);
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
         this.listBoxContacts.Size = new System.Drawing.Size(637, 368);
         this.listBoxContacts.Sorted = true;
         this.listBoxContacts.TabIndex = 2;
         this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
         // 
         // buttonRefreshContacts
         // 
         this.buttonRefreshContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonRefreshContacts.Location = new System.Drawing.Point(573, 7);
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
         // labelDirectory
         // 
         this.labelDirectory.AutoSize = true;
         this.labelDirectory.Location = new System.Drawing.Point(7, 16);
         this.labelDirectory.Name = "labelDirectory";
         this.labelDirectory.Size = new System.Drawing.Size(52, 13);
         this.labelDirectory.TabIndex = 0;
         this.labelDirectory.Text = "Directory:";
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
         // textBoxDirectory
         // 
         this.textBoxDirectory.Location = new System.Drawing.Point(65, 13);
         this.textBoxDirectory.Name = "textBoxDirectory";
         this.textBoxDirectory.ReadOnly = true;
         this.textBoxDirectory.Size = new System.Drawing.Size(583, 20);
         this.textBoxDirectory.TabIndex = 1;
         // 
         // listBoxFiles
         // 
         this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.listBoxFiles.FormattingEnabled = true;
         this.listBoxFiles.Location = new System.Drawing.Point(10, 39);
         this.listBoxFiles.Name = "listBoxFiles";
         this.listBoxFiles.Size = new System.Drawing.Size(162, 381);
         this.listBoxFiles.Sorted = true;
         this.listBoxFiles.TabIndex = 2;
         this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
         // 
         // pictureBoxPreview
         // 
         this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBoxPreview.Location = new System.Drawing.Point(178, 39);
         this.pictureBoxPreview.Name = "pictureBoxPreview";
         this.pictureBoxPreview.Size = new System.Drawing.Size(470, 316);
         this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBoxPreview.TabIndex = 3;
         this.pictureBoxPreview.TabStop = false;
         // 
         // listBoxPersonsFound
         // 
         this.listBoxPersonsFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listBoxPersonsFound.FormattingEnabled = true;
         this.listBoxPersonsFound.Location = new System.Drawing.Point(178, 361);
         this.listBoxPersonsFound.MultiColumn = true;
         this.listBoxPersonsFound.Name = "listBoxPersonsFound";
         this.listBoxPersonsFound.Size = new System.Drawing.Size(470, 56);
         this.listBoxPersonsFound.Sorted = true;
         this.listBoxPersonsFound.TabIndex = 4;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(664, 502);
         this.Controls.Add(this.tabControlContacts);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.MinimumSize = new System.Drawing.Size(680, 540);
         this.Name = "FormMain";
         this.Text = "PicFace";
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.tabControlContacts.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPageContacts.ResumeLayout(false);
         this.tabPageContacts.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
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
      private System.Windows.Forms.Label labelDirectory;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
      private System.Windows.Forms.TextBox textBoxDirectory;
      private System.Windows.Forms.PictureBox pictureBoxPreview;
      private System.Windows.Forms.ListBox listBoxFiles;
      private System.Windows.Forms.ListBox listBoxPersonsFound;
   }
}


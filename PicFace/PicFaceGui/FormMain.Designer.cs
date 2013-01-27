namespace PicFaceGui
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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPageFaces = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.listBoxImages = new System.Windows.Forms.ListBox();
         this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.tabControl1.SuspendLayout();
         this.tabPageFaces.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControl1.Controls.Add(this.tabPageFaces);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(0, 3);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(797, 477);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPageFaces
         // 
         this.tabPageFaces.Controls.Add(this.pictureBoxPreview);
         this.tabPageFaces.Controls.Add(this.listBoxImages);
         this.tabPageFaces.Location = new System.Drawing.Point(4, 22);
         this.tabPageFaces.Name = "tabPageFaces";
         this.tabPageFaces.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageFaces.Size = new System.Drawing.Size(789, 451);
         this.tabPageFaces.TabIndex = 0;
         this.tabPageFaces.Text = "Faces";
         this.tabPageFaces.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(603, 429);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 483);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(797, 22);
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // listBoxImages
         // 
         this.listBoxImages.Dock = System.Windows.Forms.DockStyle.Left;
         this.listBoxImages.FormattingEnabled = true;
         this.listBoxImages.Location = new System.Drawing.Point(3, 3);
         this.listBoxImages.Name = "listBoxImages";
         this.listBoxImages.Size = new System.Drawing.Size(247, 445);
         this.listBoxImages.TabIndex = 0;
         this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
         // 
         // pictureBoxPreview
         // 
         this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBoxPreview.Location = new System.Drawing.Point(250, 3);
         this.pictureBoxPreview.Name = "pictureBoxPreview";
         this.pictureBoxPreview.Size = new System.Drawing.Size(536, 445);
         this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBoxPreview.TabIndex = 1;
         this.pictureBoxPreview.TabStop = false;
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(797, 505);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.tabControl1);
         this.Name = "FormMain";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.tabControl1.ResumeLayout(false);
         this.tabPageFaces.ResumeLayout(false);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPageFaces;
      private System.Windows.Forms.ListBox listBoxImages;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.PictureBox pictureBoxPreview;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
   }
}


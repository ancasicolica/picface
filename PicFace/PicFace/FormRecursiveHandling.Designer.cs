namespace PicFace
{
   partial class FormRecursiveHandling
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
         this.listBoxDirectories = new System.Windows.Forms.ListBox();
         this.buttonScanDirectories = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelRootPath = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabelNumberOfDirs = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabelSaved = new System.Windows.Forms.ToolStripStatusLabel();
         this.buttonStart = new System.Windows.Forms.Button();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // listBoxDirectories
         // 
         this.listBoxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listBoxDirectories.FormattingEnabled = true;
         this.listBoxDirectories.Location = new System.Drawing.Point(2, 1);
         this.listBoxDirectories.Name = "listBoxDirectories";
         this.listBoxDirectories.Size = new System.Drawing.Size(417, 433);
         this.listBoxDirectories.Sorted = true;
         this.listBoxDirectories.TabIndex = 0;
         // 
         // buttonScanDirectories
         // 
         this.buttonScanDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonScanDirectories.Location = new System.Drawing.Point(448, 12);
         this.buttonScanDirectories.Name = "buttonScanDirectories";
         this.buttonScanDirectories.Size = new System.Drawing.Size(125, 23);
         this.buttonScanDirectories.TabIndex = 1;
         this.buttonScanDirectories.Text = "Scan Directories";
         this.buttonScanDirectories.UseVisualStyleBackColor = true;
         this.buttonScanDirectories.Click += new System.EventHandler(this.buttonScanDirectories_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRootPath,
            this.toolStripStatusLabelNumberOfDirs,
            this.toolStripStatusLabelSaved});
         this.statusStrip1.Location = new System.Drawing.Point(0, 442);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(585, 22);
         this.statusStrip1.TabIndex = 2;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabelRootPath
         // 
         this.toolStripStatusLabelRootPath.Name = "toolStripStatusLabelRootPath";
         this.toolStripStatusLabelRootPath.Size = new System.Drawing.Size(161, 17);
         this.toolStripStatusLabelRootPath.Text = "toolStripStatusLabelRootPath";
         // 
         // toolStripStatusLabelNumberOfDirs
         // 
         this.toolStripStatusLabelNumberOfDirs.Name = "toolStripStatusLabelNumberOfDirs";
         this.toolStripStatusLabelNumberOfDirs.Size = new System.Drawing.Size(12, 17);
         this.toolStripStatusLabelNumberOfDirs.Text = "-";
         // 
         // toolStripStatusLabelSaved
         // 
         this.toolStripStatusLabelSaved.Name = "toolStripStatusLabelSaved";
         this.toolStripStatusLabelSaved.Size = new System.Drawing.Size(12, 17);
         this.toolStripStatusLabelSaved.Text = "-";
         // 
         // buttonStart
         // 
         this.buttonStart.Location = new System.Drawing.Point(448, 42);
         this.buttonStart.Name = "buttonStart";
         this.buttonStart.Size = new System.Drawing.Size(125, 23);
         this.buttonStart.TabIndex = 3;
         this.buttonStart.Text = "Start";
         this.buttonStart.UseVisualStyleBackColor = true;
         this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
         // 
         // FormRecursiveHandling
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(585, 464);
         this.Controls.Add(this.buttonStart);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.buttonScanDirectories);
         this.Controls.Add(this.listBoxDirectories);
         this.Name = "FormRecursiveHandling";
         this.Text = "Recursive Handling";
         this.Load += new System.EventHandler(this.FormRecursiveHandling_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox listBoxDirectories;
      private System.Windows.Forms.Button buttonScanDirectories;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRootPath;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumberOfDirs;
      private System.Windows.Forms.Button buttonStart;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSaved;
   }
}
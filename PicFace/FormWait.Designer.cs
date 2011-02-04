namespace PicFace
{
   partial class FormWait
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
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.labelAction = new System.Windows.Forms.Label();
         this.labelInfo = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(10, 35);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(343, 23);
         this.progressBar1.TabIndex = 0;
         // 
         // labelAction
         // 
         this.labelAction.Location = new System.Drawing.Point(12, 9);
         this.labelAction.Name = "labelAction";
         this.labelAction.Size = new System.Drawing.Size(343, 23);
         this.labelAction.TabIndex = 1;
         this.labelAction.Text = "Please wait...";
         this.labelAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // labelInfo
         // 
         this.labelInfo.AutoSize = true;
         this.labelInfo.Location = new System.Drawing.Point(10, 65);
         this.labelInfo.Name = "labelInfo";
         this.labelInfo.Size = new System.Drawing.Size(10, 13);
         this.labelInfo.TabIndex = 2;
         this.labelInfo.Text = "-";
         // 
         // FormWait
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(365, 109);
         this.ControlBox = false;
         this.Controls.Add(this.labelInfo);
         this.Controls.Add(this.labelAction);
         this.Controls.Add(this.progressBar1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "FormWait";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "I\'m working...";
         this.Load += new System.EventHandler(this.FormWait_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      protected System.Windows.Forms.ProgressBar progressBar1;
      protected System.Windows.Forms.Label labelInfo;
      protected System.Windows.Forms.Label labelAction;
   }
}
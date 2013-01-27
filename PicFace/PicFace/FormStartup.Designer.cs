namespace PicFace
{
   partial class FormStartup
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.buttonOk = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.checkBoxDontShowAgain = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Kusti.Kusti.PicFaceLib.Properties.Resources.picface1;
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(131, 261);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(137, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(150, 39);
         this.label1.TabIndex = 1;
         this.label1.Text = "PicFace";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(141, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(235, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Writes the Picasa face information into your files.";
         // 
         // textBox1
         // 
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox1.Enabled = false;
         this.textBox1.Location = new System.Drawing.Point(144, 65);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(349, 160);
         this.textBox1.TabIndex = 3;
         // 
         // buttonOk
         // 
         this.buttonOk.Location = new System.Drawing.Point(337, 227);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 4;
         this.buttonOk.Text = "continue";
         this.buttonOk.UseVisualStyleBackColor = true;
         this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.Location = new System.Drawing.Point(418, 228);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 5;
         this.buttonCancel.Text = "oh no! quit!";
         this.buttonCancel.UseVisualStyleBackColor = true;
         this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
         // 
         // checkBoxDontShowAgain
         // 
         this.checkBoxDontShowAgain.AutoSize = true;
         this.checkBoxDontShowAgain.Location = new System.Drawing.Point(144, 234);
         this.checkBoxDontShowAgain.Name = "checkBoxDontShowAgain";
         this.checkBoxDontShowAgain.Size = new System.Drawing.Size(125, 17);
         this.checkBoxDontShowAgain.TabIndex = 6;
         this.checkBoxDontShowAgain.Text = "don\'t show this again";
         this.checkBoxDontShowAgain.UseVisualStyleBackColor = true;
         // 
         // FormStartup
         // 
         this.AcceptButton = this.buttonOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
         this.CancelButton = this.buttonCancel;
         this.ClientSize = new System.Drawing.Size(505, 262);
         this.ControlBox = false;
         this.Controls.Add(this.checkBoxDontShowAgain);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "FormStartup";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FormStartup";
         this.Load += new System.EventHandler(this.FormStartup_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button buttonOk;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.CheckBox checkBoxDontShowAgain;
   }
}
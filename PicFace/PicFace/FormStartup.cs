using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicFace
{
   /// <summary>
   /// Form with the disclaimer
   /// </summary>
   public partial class FormStartup : Form
   {
      public FormStartup()
      {
         InitializeComponent();
      }
      /// <summary>
      /// show disclaimer
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void FormStartup_Load(object sender, EventArgs e)
      {
         textBox1.Text = "Disclaimer" + Environment.NewLine;
         textBox1.Text += "This is a freeware and open source tool developed in my spare time. Even I test the ";
         textBox1.Text += "functionality of this tool there is no guarantee against data loss, corrupt images or ";
         textBox1.Text += "all other nightmares you can think of. By clicking \"continue\" you agree that you use ";
         textBox1.Text += "this tool at your own risk and you confirm having a backup of the pictures you are ";
         textBox1.Text += "manipulating.";
         buttonCancel.Focus();
      }
      /// <summary>
      /// Forget it
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void button2_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
      /// <summary>
      /// OK, go on
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void buttonOk_Click(object sender, EventArgs e)
      {
         this.Visible = false;
         PicFaceConfig.ShowStartupDialog = !checkBoxDontShowAgain.Checked;
         new FormMain().ShowDialog();
         Application.Exit();
      }
   }
}

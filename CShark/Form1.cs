using System;
using System.Windows.Forms;
using System.IO;
using CShark.Properties;

namespace CShark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void carbonFiberButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carbonFiberButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
#region Just stuff
        private void carbonFiberTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void carbonFiberLabel3_Click(object sender, EventArgs e)
        {

        }

        private void carbonFiberLabel1_Click(object sender, EventArgs e)
        {

        }
#endregion
        private void carbonFiberButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //AppDomain.CurrentDomain.BaseDirectory = directory of the application

                DirectoryInfo dir = Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Media Encoder Crack");
                File.WriteAllBytes(dir.FullName + @"\amtlib.dll", Resources.amtlib); //extracts the dll file from the resources to the directory
                MessageBox.Show("File Location: " + dir.FullName);
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                carbonFiberButton3.Enabled = true;
            }
            else
            {
                carbonFiberButton3.Enabled = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC3Ll2xSAneDuK_GJcS-1D9A");
        }
#region RichTextBox
        private void wC_Linux_RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Theme_Click(object sender, EventArgs e)
        {

        }
#endregion
    }
}

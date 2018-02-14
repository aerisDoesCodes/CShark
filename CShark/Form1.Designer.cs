namespace CShark
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Theme = new CS_ClassLibraryTester.CarbonFiberTheme();
            this.carbonFiberButton2 = new CS_ClassLibraryTester.CarbonFiberButton();
            this.carbonFiberButton1 = new CS_ClassLibraryTester.CarbonFiberButton();
            this.tab1 = new CS_ClassLibraryTester.CarbonFiberTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wC_Linux_Label1 = new WC_Linux.WC_Linux_Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.carbonFiberButton3 = new CS_ClassLibraryTester.CarbonFiberButton();
            this.carbonFiberSeparatorHorizontal1 = new CS_ClassLibraryTester.CarbonFiberSeparatorHorizontal();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.carbonFiberLabel5 = new CS_ClassLibraryTester.CarbonFiberLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Theme.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Theme
            // 
            this.Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Theme.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.Theme.Controls.Add(this.carbonFiberButton2);
            this.Theme.Controls.Add(this.carbonFiberButton1);
            this.Theme.Controls.Add(this.tab1);
            this.Theme.Customization = "";
            this.Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.Theme.Icon = ((System.Drawing.Icon)(resources.GetObject("Theme.Icon")));
            this.Theme.Image = null;
            this.Theme.Location = new System.Drawing.Point(0, 0);
            this.Theme.Movable = true;
            this.Theme.Name = "Theme";
            this.Theme.NoRounding = false;
            this.Theme.ShowIcon = false;
            this.Theme.Sizable = false;
            this.Theme.Size = new System.Drawing.Size(608, 339);
            this.Theme.SmartBounds = true;
            this.Theme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Theme.TabIndex = 0;
            this.Theme.Text = "CShark Media Encoder";
            this.Theme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Theme.Transparent = false;
            this.Theme.Click += new System.EventHandler(this.Theme_Click);
            // 
            // carbonFiberButton2
            // 
            this.carbonFiberButton2.BackColor = System.Drawing.Color.Red;
            this.carbonFiberButton2.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberButton2.Customization = "";
            this.carbonFiberButton2.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberButton2.Image = null;
            this.carbonFiberButton2.Location = new System.Drawing.Point(548, 7);
            this.carbonFiberButton2.Name = "carbonFiberButton2";
            this.carbonFiberButton2.NoRounding = false;
            this.carbonFiberButton2.Size = new System.Drawing.Size(24, 16);
            this.carbonFiberButton2.TabIndex = 2;
            this.carbonFiberButton2.Text = "-";
            this.carbonFiberButton2.Transparent = false;
            this.carbonFiberButton2.Click += new System.EventHandler(this.carbonFiberButton2_Click);
            // 
            // carbonFiberButton1
            // 
            this.carbonFiberButton1.BackColor = System.Drawing.Color.Red;
            this.carbonFiberButton1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberButton1.Customization = "";
            this.carbonFiberButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberButton1.Image = null;
            this.carbonFiberButton1.Location = new System.Drawing.Point(578, 7);
            this.carbonFiberButton1.Name = "carbonFiberButton1";
            this.carbonFiberButton1.NoRounding = false;
            this.carbonFiberButton1.Size = new System.Drawing.Size(24, 16);
            this.carbonFiberButton1.TabIndex = 1;
            this.carbonFiberButton1.Text = "x";
            this.carbonFiberButton1.Transparent = false;
            this.carbonFiberButton1.Click += new System.EventHandler(this.carbonFiberButton1_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(0, 25);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(608, 314);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.wC_Linux_Label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.carbonFiberButton3);
            this.tabPage1.Controls.Add(this.carbonFiberSeparatorHorizontal1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dropper";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(5)))));
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(584, 155);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // wC_Linux_Label1
            // 
            this.wC_Linux_Label1.AutoSize = true;
            this.wC_Linux_Label1.BackColor = System.Drawing.Color.Transparent;
            this.wC_Linux_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.wC_Linux_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.wC_Linux_Label1.Location = new System.Drawing.Point(-885, 45);
            this.wC_Linux_Label1.MaximumSize = new System.Drawing.Size(700, 0);
            this.wC_Linux_Label1.Name = "wC_Linux_Label1";
            this.wC_Linux_Label1.Size = new System.Drawing.Size(698, 820);
            this.wC_Linux_Label1.TabIndex = 8;
            this.wC_Linux_Label1.Text = resources.GetString("wC_Linux_Label1.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(532, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Agree";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // carbonFiberButton3
            // 
            this.carbonFiberButton3.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberButton3.Customization = "";
            this.carbonFiberButton3.Enabled = false;
            this.carbonFiberButton3.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberButton3.Image = null;
            this.carbonFiberButton3.Location = new System.Drawing.Point(228, 206);
            this.carbonFiberButton3.Name = "carbonFiberButton3";
            this.carbonFiberButton3.NoRounding = false;
            this.carbonFiberButton3.Size = new System.Drawing.Size(142, 29);
            this.carbonFiberButton3.TabIndex = 6;
            this.carbonFiberButton3.Text = "Drop";
            this.carbonFiberButton3.Transparent = false;
            this.carbonFiberButton3.Click += new System.EventHandler(this.carbonFiberButton3_Click);
            // 
            // carbonFiberSeparatorHorizontal1
            // 
            this.carbonFiberSeparatorHorizontal1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberSeparatorHorizontal1.Customization = "";
            this.carbonFiberSeparatorHorizontal1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberSeparatorHorizontal1.Image = null;
            this.carbonFiberSeparatorHorizontal1.Location = new System.Drawing.Point(5, 185);
            this.carbonFiberSeparatorHorizontal1.Name = "carbonFiberSeparatorHorizontal1";
            this.carbonFiberSeparatorHorizontal1.NoRounding = false;
            this.carbonFiberSeparatorHorizontal1.Size = new System.Drawing.Size(589, 10);
            this.carbonFiberSeparatorHorizontal1.TabIndex = 4;
            this.carbonFiberSeparatorHorizontal1.Text = "carbonFiberSeparatorHorizontal1";
            this.carbonFiberSeparatorHorizontal1.Transparent = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.carbonFiberLabel5);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.ForeColor = System.Drawing.Color.Red;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(297, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "John Patrick";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(245, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Made by";
            // 
            // carbonFiberLabel5
            // 
            this.carbonFiberLabel5.BackColor = System.Drawing.Color.Transparent;
            this.carbonFiberLabel5.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.carbonFiberLabel5.Customization = "";
            this.carbonFiberLabel5.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonFiberLabel5.Image = null;
            this.carbonFiberLabel5.Location = new System.Drawing.Point(7, 7);
            this.carbonFiberLabel5.Name = "carbonFiberLabel5";
            this.carbonFiberLabel5.NoRounding = false;
            this.carbonFiberLabel5.Size = new System.Drawing.Size(5, 0);
            this.carbonFiberLabel5.TabIndex = 0;
            this.carbonFiberLabel5.Transparent = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CShark.Properties.Resources._0659001;
            this.pictureBox1.Location = new System.Drawing.Point(193, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 339);
            this.Controls.Add(this.Theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Theme.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.CarbonFiberTheme Theme;
        private CS_ClassLibraryTester.CarbonFiberTabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CS_ClassLibraryTester.CarbonFiberButton carbonFiberButton1;
        private CS_ClassLibraryTester.CarbonFiberButton carbonFiberButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CS_ClassLibraryTester.CarbonFiberLabel carbonFiberLabel5;
        private CS_ClassLibraryTester.CarbonFiberSeparatorHorizontal carbonFiberSeparatorHorizontal1;
        private CS_ClassLibraryTester.CarbonFiberButton carbonFiberButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private WC_Linux.WC_Linux_Label wC_Linux_Label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


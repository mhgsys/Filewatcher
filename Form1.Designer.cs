
namespace Filewatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BrowseButton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelMonitorFolder = new System.Windows.Forms.Label();
            this.ExitAdmin = new System.Windows.Forms.Button();
            this.labelCopyDestination = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelScriptLoc = new System.Windows.Forms.Label();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.labelFaketext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.AdminPic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InfoButton = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BackgroundHolder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.tdms";
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitoring Calibration Files";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.BackColor = System.Drawing.Color.Snow;
            this.BrowseButton1.Location = new System.Drawing.Point(235, 137);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(56, 20);
            this.BrowseButton1.TabIndex = 3;
            this.BrowseButton1.Text = "Browse";
            this.BrowseButton1.UseVisualStyleBackColor = false;
            this.BrowseButton1.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(75, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelMonitorFolder
            // 
            this.labelMonitorFolder.AutoSize = true;
            this.labelMonitorFolder.BackColor = System.Drawing.Color.Black;
            this.labelMonitorFolder.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelMonitorFolder.Location = new System.Drawing.Point(75, 124);
            this.labelMonitorFolder.Name = "labelMonitorFolder";
            this.labelMonitorFolder.Size = new System.Drawing.Size(74, 13);
            this.labelMonitorFolder.TabIndex = 6;
            this.labelMonitorFolder.Text = "Monitor Folder";
            // 
            // ExitAdmin
            // 
            this.ExitAdmin.Location = new System.Drawing.Point(257, 318);
            this.ExitAdmin.Name = "ExitAdmin";
            this.ExitAdmin.Size = new System.Drawing.Size(66, 27);
            this.ExitAdmin.TabIndex = 7;
            this.ExitAdmin.Text = "Exit Admin";
            this.ExitAdmin.UseVisualStyleBackColor = true;
            this.ExitAdmin.Click += new System.EventHandler(this.ExitAdmin_Click);
            // 
            // labelCopyDestination
            // 
            this.labelCopyDestination.AutoSize = true;
            this.labelCopyDestination.BackColor = System.Drawing.Color.Black;
            this.labelCopyDestination.ForeColor = System.Drawing.Color.Gray;
            this.labelCopyDestination.Location = new System.Drawing.Point(76, 236);
            this.labelCopyDestination.Name = "labelCopyDestination";
            this.labelCopyDestination.Size = new System.Drawing.Size(153, 13);
            this.labelCopyDestination.TabIndex = 6;
            this.labelCopyDestination.Text = "Copy Source/Copy Destination";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(75, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 4;
            // 
            // labelScriptLoc
            // 
            this.labelScriptLoc.AutoSize = true;
            this.labelScriptLoc.BackColor = System.Drawing.Color.Black;
            this.labelScriptLoc.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelScriptLoc.Location = new System.Drawing.Point(76, 175);
            this.labelScriptLoc.Name = "labelScriptLoc";
            this.labelScriptLoc.Size = new System.Drawing.Size(102, 13);
            this.labelScriptLoc.TabIndex = 6;
            this.labelScriptLoc.Text = "CopyScript Location";
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(235, 188);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(56, 20);
            this.BrowseButton2.TabIndex = 9;
            this.BrowseButton2.Text = "Browse";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            this.BrowseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // labelFaketext
            // 
            this.labelFaketext.BackColor = System.Drawing.Color.Gray;
            this.labelFaketext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaketext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFaketext.Location = new System.Drawing.Point(76, 250);
            this.labelFaketext.Name = "labelFaketext";
            this.labelFaketext.Size = new System.Drawing.Size(153, 18);
            this.labelFaketext.TabIndex = 6;
            this.labelFaketext.Text = "Controlled by CopyScript";
            this.labelFaketext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(74, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Options";
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Resetbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resetbutton.Location = new System.Drawing.Point(235, 250);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(56, 20);
            this.Resetbutton.TabIndex = 12;
            this.Resetbutton.Text = "X";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminPic
            // 
            this.AdminPic.BackgroundImage = global::Filewatcher.Properties.Resources.admin;
            this.AdminPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPic.Location = new System.Drawing.Point(4, 12);
            this.AdminPic.Name = "AdminPic";
            this.AdminPic.Size = new System.Drawing.Size(48, 47);
            this.AdminPic.TabIndex = 14;
            this.AdminPic.TabStop = false;
            this.AdminPic.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Filewatcher.Properties.Resources.warning;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 53);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Black;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.InfoButton.Image = global::Filewatcher.Properties.Resources.InfoButton;
            this.InfoButton.Location = new System.Drawing.Point(207, 168);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(22, 20);
            this.InfoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoButton.TabIndex = 10;
            this.InfoButton.TabStop = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Image = global::Filewatcher.Properties.Resources.settings;
            this.SettingsButton.Location = new System.Drawing.Point(305, 1);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(35, 31);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Filewatcher.Properties.Resources.checkprocess;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // BackgroundHolder
            // 
            this.BackgroundHolder.BackgroundImage = global::Filewatcher.Properties.Resources.bg;
            this.BackgroundHolder.Image = global::Filewatcher.Properties.Resources.bg;
            this.BackgroundHolder.Location = new System.Drawing.Point(-2, 72);
            this.BackgroundHolder.Name = "BackgroundHolder";
            this.BackgroundHolder.Size = new System.Drawing.Size(342, 237);
            this.BackgroundHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundHolder.TabIndex = 11;
            this.BackgroundHolder.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(343, 69);
            this.ControlBox = false;
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.BrowseButton2);
            this.Controls.Add(this.ExitAdmin);
            this.Controls.Add(this.labelFaketext);
            this.Controls.Add(this.labelCopyDestination);
            this.Controls.Add(this.labelScriptLoc);
            this.Controls.Add(this.labelMonitorFolder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.BrowseButton1);
            this.Controls.Add(this.BackgroundHolder);
            this.Controls.Add(this.AdminPic);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "FileWatcher V1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BrowseButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelMonitorFolder;
        private System.Windows.Forms.Button ExitAdmin;
        private System.Windows.Forms.Label labelCopyDestination;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.Label labelScriptLoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelFaketext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox InfoButton;
        private System.Windows.Forms.PictureBox BackgroundHolder;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox AdminPic;
    }
}


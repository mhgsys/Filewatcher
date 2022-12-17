using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Filewatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            //let's put this program in te upper right corner of the screen by default
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;


                }
            }
        }
        // declare a publing string so we can store our changes and load them by default on startup
        public string Watchpath; // for the watchpath
        public string ScriptSource; // to link our script

        // make a public bool so we can access settings after the correct password.
        public static bool Admin = false;


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Closing this program is forbidden!" + "\n" + "\n" + "-MHG-", "Blocked on purpose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer3.Stop(); // stop showing message that files are uploading , process is done.
            label1.Text = "Monitoring Calibration Files";
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // read our last configurations back and load it @default
            Watchpath = Filewatcher.Properties.Settings.Default.Watchpath;
            ScriptSource = Filewatcher.Properties.Settings.Default.ScriptSource;


            //let the FileWatcher know we want to read from our Public string Watchpath
            fileSystemWatcher1.Path = Watchpath;




            // let's show the path it is watching
            textBox1.Text = Watchpath;
            // let's show our default ScriptPath
            textBox2.Text = ScriptSource;
            // Sets the timer interval to 20seconds.
            timer1.Interval = 10000; // for changes in Files
            timer2.Interval = 30000; // to invoke our uploading powershell
            timer3.Interval = 1000; //for our upload to show it is busy


            ReloadForm();
            //quick check to see if all is right.

        }

        private void change()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label1.Text = "Detected new Calibration Files";
            timer1.Stop(); // stop first each time in case we are creating new files.
            timer1.Start(); //show it's changing
            timer2.Start(); // start to invoke our powershell after changes have been made.

        }

        private void upload()
        {

            timer1.Stop(); // stop showing processing
            timer3.Start(); // show upload instead


        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Do you want to change the monitoring directory to:" + "\n" + folderBrowserDialog1.SelectedPath, "Warning",
 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Watchpath = folderBrowserDialog1.SelectedPath;
                    fileSystemWatcher1.Path = Watchpath;
                    Filewatcher.Properties.Settings.Default.Watchpath = Watchpath;
                    Filewatcher.Properties.Settings.Default.Save(); // Important for saving
                    textBox1.Text = Watchpath;




                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Settings unchanged", "Warning",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }

        }
        /* /////////////////////////FILESYSTEMWATCHER-SETTINGS/////////////////////////
         */

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            LoadTreeViewData();
            fileSystemWatcher1.EnableRaisingEvents = true;
            change();
        }


        private void LoadTreeViewData()
        {
            throw new NotImplementedException();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {



            timer2.Stop(); // stop the powershell timer while we are still creating files

            change(); // call our change 


        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {

            //label2.Text = (string.Format("File Deleted {0} {1}", e.FullPath, e.Name));
            label1.Text = "Ignoring Deleted files";

            timer1.Start();

        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {

            // label2.Text = (string.Format("File Renamed {0} {1}", e.FullPath, e.Name));
            change();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form_Login Form2 = new Form_Login(); // Instantiate a Form object.
            Form2.ShowDialog();// Show Form2
            ReloadForm(); // invoking reloadform setting Admin = true from form2 if password is correct.

        }
        private void ReloadForm()
        {
            if (Watchpath == "" || ScriptSource == "")
            {
                label1.Text = "No Config!| Click the Gears>> ";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

            }

            if (Admin == true) // show our hidden things.
            {
                label1.Text = "Admin logged in";
                Opacity = .95;
                Size = new Size(351, 400);
                pictureBox3.Visible = false;
                AdminPic.Visible = true;

            }
            else if (Admin == false)
            {
                Opacity = .75;
                Size = new Size(351, 108);
                AdminPic.Visible = false;
                //show our things 


            }



        }

        private void Terminal()
        {

            var script = ScriptSource;
            //@"C:\scripts\myscript.ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-windowstyle hidden -NoProfile -ExecutionPolicy unrestricted \"{script}\"",
                UseShellExecute = false
            };
            upload();
            timer2.Stop(); // we only want to execute this powershell once, hence stopping the ticking of the timer.
            Process.Start(startInfo);
            timer1.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            Terminal();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label1.Text = "Running UploadScript";

        }



        private void BrowseButton2_Click(object sender, EventArgs e)
        {



            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Select A ScriptFile";

            openfile.Filter = "scriptFiles (*.ps1)|*.ps1";
            if (openfile.ShowDialog() == DialogResult.OK)
            {

                DialogResult result = MessageBox.Show("Do you want to change the Script File to:" + "\n" + openfile.FileName, "Warning",
 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    ScriptSource = openfile.FileName;// let's set our ScriptSource
                    Filewatcher.Properties.Settings.Default.ScriptSource = ScriptSource;
                    Filewatcher.Properties.Settings.Default.Save(); // Saves settings in application configuration file
                    textBox2.Text = ScriptSource;





                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Settings unchanged", "Warning",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The copy source and destination must be set by the script you're invoking \n \n \nFor a script example, kindly see the pre-written script in the Program Files folder " , "Developers Info",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Watchpath = "";
            Filewatcher.Properties.Settings.Default.Watchpath = Watchpath;
            Filewatcher.Properties.Settings.Default.Save(); // Important for saving
            textBox1.Text = Watchpath;
            ScriptSource = "";
            Filewatcher.Properties.Settings.Default.ScriptSource = ScriptSource;
            Filewatcher.Properties.Settings.Default.Save(); // Saves settings in application configuration file
            textBox2.Text = ScriptSource;
        }

        private void ExitAdmin_Click(object sender, EventArgs e)
        {
            Admin = false;

            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            label1.Text = "Monitoring Calibration Files";

            ReloadForm(); // Size = new Size(351, 108);


        }

       
    }
}





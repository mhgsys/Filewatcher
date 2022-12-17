using System;
using System.Windows.Forms;

namespace Filewatcher
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            // Set to no text.
            textBox1.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 14;
            textBox1.Select();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "System32!" && textBox1.Text == "Admin")
            {
                // The password is ok.
                this.DialogResult = DialogResult.OK;

                Form1.Admin = true;
                this.Close();



            }
            else
            {

                // The password is invalid.
                Form1.Admin = false;
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Wrong UserName And/Or Password.", "Acces Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.Admin = false;
            this.Close();

        }
    }
}

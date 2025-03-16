using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_International
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string originalpassword = "";
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string password = originalpassword;
            string username = usertxt.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login Success!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                StudentForm studentForm = new StudentForm();
                this.Hide();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials, plaese check username or password and try again", "Invalid login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (username != "admin" && password == "1234")
                {
                    usertxt.Clear();
                    label3.ForeColor = Color.Red;
                }
                else if (username == "admin" && password != "1234")
                {
                    passwordtxt.Clear();
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    usertxt.Clear();
                    passwordtxt.Clear();
                }
            }
        }
        private string Maskedtxt(string passwordtxt)
        {
            string maskedtxt= new string('*', passwordtxt.Length);
            return maskedtxt;
        }

        private void updatepassword(string currenttext)
        {
            if (currenttext.Length > originalpassword.Length)
            {
                originalpassword += currenttext.Substring(originalpassword.Length);

            }
            else if (currenttext.Length < originalpassword.Length)
            {
                originalpassword = originalpassword.Substring(0, currenttext.Length);
            }

            {

            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            string currenttext=passwordtxt.Text;
            updatepassword(currenttext);

            string maskedtxt = Maskedtxt(originalpassword);
            passwordtxt.Text = maskedtxt;
            passwordtxt.SelectionStart = passwordtxt.Text.Length;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult =MessageBox.Show("Are you really want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else if(dialogresult == DialogResult.No) 
            { 
            
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usertxt.Clear();
            passwordtxt.Clear();
        }
    }
}

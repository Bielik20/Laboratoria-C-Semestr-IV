using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class LoginForm : Form
    {
        string login;
        string password;

        public LoginForm()
        {
            InitializeComponent();
            //login = (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).login.ToString();
            //password = (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).password;
            using (StreamReader outfile = new StreamReader("user.txt"))
            {
                string temp = outfile.ReadLine();
                string[] tempTab = temp.Split('-');
                this.login = tempTab[0];
                this.password = tempTab[1];

            }        
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(loginBox.Text == login && passwordBox.Text == password)
            {
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).mainPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Złe dane");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).Close();
        }
    }
}

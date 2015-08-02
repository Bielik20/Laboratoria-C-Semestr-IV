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
    public partial class FirstRunForm : Form
    {
        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text == passwordBox2.Text)
            {
                using (StreamWriter outfile = new StreamWriter("user.txt"))
                {
                    outfile.Write(loginBox.Text + "-" + passwordBox.Text);
                }
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).mainPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hasła się nie zgadzają");
            }
        }

        private void FirstRunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).Close();
        }
    }
}

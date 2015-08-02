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
    public partial class MainForm : Form
    {
        public UserControl mainPage;
        public string login;
        public string password;
        Form firstRunForm;
        Form loginForm;

        public MainForm()
        {
            InitializeComponent();
            mainPage = new MainPage();
            this.Controls.Add(this.mainPage);
            mainPage.Hide();

            StartUp();
        }

        private void StartUp()
        {
            try
            {
                using (StreamReader outfile = new StreamReader("user.txt"))
                {
                    loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
            catch (FileNotFoundException) { firstRunForm = new FirstRunForm(); firstRunForm.Show(); }
        }
    }
}

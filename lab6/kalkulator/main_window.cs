using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grafika;

namespace kalkulator
{
    public partial class main_window : Grafika.FormK
    {
        public main_window()
        {
            InitializeComponent();
            Build_Board();
        }

        private void Build_Board()
        {
            //this.panel1.Controls.Add(this.buttonK1);

            //Numbers

            public ButtonK [] Numbers = new ButtonK[10];
            for (int i = 0 , i < 10 , i++)
            {
                Numbers[i] = new ButtonK();
                Numbers[i].Location = new System.Drawing.Point(i*110, 10);            }
        }
    }
}

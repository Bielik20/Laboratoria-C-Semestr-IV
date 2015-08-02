using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zad_2
{
    public partial class Form1 : Form
    {
        private Color kolor;

        public Form1()
        {
            InitializeComponent();
            kolor = panel1.BackColor;
            button1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = kolor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

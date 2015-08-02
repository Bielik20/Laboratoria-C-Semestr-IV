using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Edytor_Tekstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //saveFileDialog1.ShowDialog();
        }


        #region Menu - Plik
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void kopiujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            MessageBox.Show(Clipboard.GetText());
        }

        private void cofnijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void wklejToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
            MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath + "\\test.txt").ToString());
            sw.Write(richTextBox1.Text);
            sw.Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            richTextBox1.Clear();

            richTextBox1.Text = sr.ReadToEnd();
        }
    }
}

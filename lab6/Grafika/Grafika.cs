using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafika
{
    public class FormK : System.Windows.Forms.Form
    {
        public FormK()
        {
            //this.BackColor = System.Drawing.Color.Black;
        }
    }

    public class TextBoxK : System.Windows.Forms.TextBox
    {

    }

    public class ButtonK : System.Windows.Forms.Button
    {
        public ButtonK()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif" , 10 , 
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point , (byte)(230));
            this.Size = new System.Drawing.Size(100, 100);
        }
    }
}

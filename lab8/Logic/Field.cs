using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    class Field : Button
    {
        int owner;
        //// 
        //// button1
        //// 
        //this.button1.Location = new System.Drawing.Point(141, 78);
        //this.button1.Name = "button1";
        //this.button1.Size = new System.Drawing.Size(75, 23);
        //this.button1.TabIndex = 0;
        //this.button1.Text = "button1";
        //this.button1.UseVisualStyleBackColor = true;

        public Field() : base()
        {
            this.Size = new System.Drawing.Size(20, 20);
            this.Text = "";
        }



    }
}

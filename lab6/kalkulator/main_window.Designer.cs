namespace kalkulator
{
    partial class main_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxK1 = new Grafika.TextBoxK();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonK1 = new Grafika.ButtonK();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxK1
            // 
            this.textBoxK1.Location = new System.Drawing.Point(12, 12);
            this.textBoxK1.Name = "textBoxK1";
            this.textBoxK1.Size = new System.Drawing.Size(200, 26);
            this.textBoxK1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonK1);
            this.panel1.Location = new System.Drawing.Point(34, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 331);
            this.panel1.TabIndex = 2;
            // 
            // buttonK1
            // 
            this.buttonK1.BackColor = System.Drawing.Color.Green;
            this.buttonK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(230)));
            this.buttonK1.Location = new System.Drawing.Point(12, 17);
            this.buttonK1.Name = "buttonK1";
            this.buttonK1.Size = new System.Drawing.Size(84, 82);
            this.buttonK1.TabIndex = 0;
            this.buttonK1.Text = "buttonK1";
            this.buttonK1.UseVisualStyleBackColor = false;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxK1);
            this.Name = "main_window";
            this.Text = "Kalkulator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grafika.TextBoxK textBoxK1;
        private System.Windows.Forms.Panel panel1;
        private Grafika.ButtonK buttonK1;
    }
}


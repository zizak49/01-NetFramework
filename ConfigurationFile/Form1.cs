using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public class Form1 : Form
    {
        private Label label1;
        private TextBox textBoxCLR;
    
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.textBoxCLR.Text = Environment.Version.ToString();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCLR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&CLR Version:";
            // 
            // textBoxCLR
            // 
            this.textBoxCLR.Location = new System.Drawing.Point(87, 6);
            this.textBoxCLR.Name = "textBoxCLR";
            this.textBoxCLR.ReadOnly = true;
            this.textBoxCLR.Size = new System.Drawing.Size(193, 20);
            this.textBoxCLR.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.textBoxCLR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

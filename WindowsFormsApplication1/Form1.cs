using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBox1.Text = Environment.Version.ToString(3);
            System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient();
            sc.Send("pet", "a", "c", "d");
        }
    }
}

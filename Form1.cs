using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");
            double pi = 3.14159265;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("0.000") + "\n");
            richTextBox1.AppendText(pi.ToString("N5") + "\n");
            richTextBox1.AppendText(pi.ToString("N1") + "\n");
            richTextBox1.AppendText(pi.ToString("N15") + "\n");

            richTextBox1.AppendText(c.ToString("0,000,000") + "\n");
            richTextBox1.AppendText(c.ToString("0.0E0") + "\n");
            
        }
   

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

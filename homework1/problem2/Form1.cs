using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            double b = Double.Parse(a);
            a = textBox2.Text;
            double c = Double.Parse(a);
            double d = b * c;
            label4.Text = b + "和" + c + "的积为:" + d;
        }
    }
}

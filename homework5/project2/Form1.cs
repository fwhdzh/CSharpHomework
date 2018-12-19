using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
            th1 = double.Parse(textTh1.Text) * Math.PI / 180;
            th2 = double.Parse(textTh2.Text) * Math.PI / 180;
            per1 = double.Parse(textPer1.Text);
            per2 = double.Parse(textPer2.Text);
            k = double.Parse(textK.Text);
            wid = double.Parse(textWid.Text);
            if (rButtonBlue.Checked) pen = new Pen(Color.Blue);
            if (rButtonRed.Checked) pen = new Pen(Color.Red);
            if (rButtonYellow.Checked) pen = new Pen(Color.Yellow);
            pen.Width = (float)wid;
            drawCayLeyTree(10, 200, 310, 100, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k=1;
        double wid = 1;
        Pen pen;

        void  drawCayLeyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayLeyTree(n - 1, x1, y1, k*per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {

            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textTh1.Text=(random.NextDouble()*90).ToString();
            textTh2.Text = (random.NextDouble() * 90).ToString();
            textPer1.Text = random.NextDouble().ToString();
            textPer2.Text = random.NextDouble().ToString();
            textK.Text = (random.NextDouble() * 2).ToString();
            textWid.Text = (random.NextDouble() * 4).ToString();
            int i = random.Next(3);
            switch(i)
            {
                case 0:
                    rButtonRed.Checked = true;
                    break;
                case 1:
                    rButtonYellow.Checked = true;
                    break;
                case 2:
                    rButtonBlue.Checked = true;
                    break;
            }
        }
    }
}

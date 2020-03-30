using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7Homework_GH
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Color color = Color.Green;
        int width = 1;
        double leng = 100;
        int drawInterval = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panel1.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(14, panel1.Width/2, panel1.Height/1.05, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0,double y0,double leng, double th)
        {
            if (n == 0) return;

            timer1.Start();

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1,width);

            timer1.Stop();

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
        void drawLine(double x0,double y0,double x1,double y1,int width)
        {
            graphics.DrawLine(
                new Pen(color,width),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedColor = colors.SelectedItem.ToString();
            switch (SelectedColor)
            {
                case "Red":
                    color = Color.Red;                    
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                default:
                    break;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button2.Text = trackBar1.Value.ToString();
            width = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            button1.Text = trackBar2.Value.ToString();
            leng = (1 + (double)trackBar2.Value / 10) * 100;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            button3.Text = trackBar3.Value.ToString();
            drawInterval = 1100 - trackBar3.Value * 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = drawInterval;
            //在drawCayleyTree中调用start和stop，但是有问题，未解决
        }
    }
}

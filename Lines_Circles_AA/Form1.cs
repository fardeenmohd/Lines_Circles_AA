using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines_Circles_AA
{
    public partial class Form1 : Form
    {
        public Bitmap bitmap;
        public Graphics graphics;
        public int thickness = 1;
        public bool drawOn = false;
        public int clickCounter = 0 ;
        public Point a;
        public Point b;
        public void setClickCounter(int value)
        {
            clickCounter = value;
            clickIndicatorBox.Text = value.ToString();
            clickIndicatorLabel.Text = "You have " + (value) + " clicks left";
        }
        public void Init()
        {
            drawOn = true;
            setClickCounter(2);
            a = new Point();
            b = new Point();
            if (graphics != null) graphics.Dispose();
            pictureBox.Image = null;
            if (bitmap != null) bitmap.Dispose();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            graphics = pictureBox.CreateGraphics();
            

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void putPixel(int x, int y, Color color)
        {
            switch(thickness)
            {
                case 1:
                    break;
                case 3:
                    break;
                case 5:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }

    
        private void thicknessTextBox_TextChanged(object sender, EventArgs e)
        {
            thickness = (thicknessTextBox.Text == null ? Convert.ToInt32(thicknessTextBox.Text) : 1);
        }

        private void SymmetricLine(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int d = 2 * dy - dx;
            int dE = 2 * dy;
            int dNE = 2 * (dy - dx);
            int xf = x1, yf = y1;
            int xb = x2, yb = y2;
            //putPixel(xf, yf);
            //putPixel(xb, yb);
            while (xf < xb)
            {
                ++xf; --xb;
                if (d < 0)
                    d += dE;
                else
                {
                    d += dNE;
                    ++yf;
                    --yb;
                }
                //putPixel(xf, yf);
                //putPixel(xb, yb);
            }
        }

        private void symmetricMidPointLineButton_Click(object sender, EventArgs e)
        {
            SymmetricLine(a.X, a.Y, b.X, b.Y);
        }

        private void MidpointCircle(Point Center, int R)
        {

            int d = 1 - R;
            int x = 0 + Center.X;
            int y = R + Center.Y;
            //putPixel(x, y);
            while (y > x)
            {
                if (d < 0) //move to E
                    d += 2 * x + 3;
                else //move to SE
                {
                    d += 2 * x - 2 * y + 5;
                    --y;
                }
                ++x;
                //putPixel(x, y);
            }
        }


        private void midPointCircleButton_Click(object sender, EventArgs e)
        {
            MidpointCircle(a, 2);
            MidpointCircle(b, 4);

        }

        void WuLine(int x1, int y1, int x2, int y2)
        {
            Color L = Color.Black; /*Line color*/
            Color B = pictureBox.BackColor; /*Background Color*/
            int dx = x2 - x1;
            int dy = y2 - y1;
            float m = dy / dx;
            float y = y1;
            for (int x = x1; x <= x2; ++x)
            {
                //Color c1 = L * (1 - modf(y)) + B * modf(y);
                //Color c2 = L * modf(y) + B * (1 - modf(y));
                //putPixel(x, floor(y), c1);
                //putPixel(x, floor(y) + 1, c2);
                y += m;
            }
        }

        private void xiaolinLineButton_Click(object sender, EventArgs e)
        {
            WuLine(a.X, a.Y, b.X, b.Y);
        }
        private void WuCircle(Point Center,int R)
        {
            Color L = Color.Black; /*Line color*/
            Color B = pictureBox.BackColor; /*Background Color*/
            int x = R + Center.X;
            int y = 0 + Center.Y;
            //putPixel(x, y, L);
            while (x > y)
            {
                ++y;
                x = (int)Math.Ceiling(Math.Sqrt(R * R + y * y));
                float T = D(R, y);
                //Color c2 = L * (1 - T) + B * T;
                //Color c1 = L * T + B * (1 - T);
                //putPixel(x, y, c2);
                //putPixel(x - 1, y, c1);
            }
        }
        public float D(int R, int y)
        {
            return (float)(Math.Ceiling(Math.Sqrt(R*R - y*y)) - Math.Sqrt(R * R - y * y));
        }

        private void xiaolinCircleButton_Click(object sender, EventArgs e)
        {
            WuCircle(a, 2);
            WuCircle(b, 4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(drawOn)
            {
                MouseEventArgs me = (MouseEventArgs)e;

                if(clickCounter == 2)
                {
                    a = me.Location;
                    clickIndicatorLabel.Text = a.X + ":" + a.Y ;
                    clickCounter--;
                    setClickCounter(clickCounter);
                }
                else if(clickCounter == 1)
                {
                    b = me.Location;
                    clickCounter--;
                    setClickCounter(clickCounter);
                    drawOn = false;
                }
                
            }
        }

        private void pointRecordButton_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void clickIndicatorBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

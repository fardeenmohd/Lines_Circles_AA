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
        public List<List<int>> thicknessMatrix = new List<List<int>>
        {
            new List<int> {0 , 1 , 0 },
            new List<int> {1 , 1 , 1 },
            new List<int> {0 , 1 , 0 }
        };
        public void setClickCounter(int value)
        {
            clickCounter = value;
            clickIndicatorBox.Text = value.ToString();
            clickIndicatorLabel.Text = "You have " + (value) + " clicks left";
        }
        public void Init()
        {
            drawOn = true;
            bCoordinateLabel.Text = "Please Record Now";
            aCoordinateLabel.Text = "Please Record Now";
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

        class ColorPoint
        {
            int x;
            int y;
            int color;

            public ColorPoint(int x, int y, int color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }
            public int get_x()
            {
                return x;
            }
            public int get_y()
            {
                return y;
            }
            public int get_color()
            {
                return color;
            }
        };

        public static int wrap(int value)
        {
            return (value < 0) ? 0 : (value > 255) ? 255 : value;
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void loadThicknessMatrix(int thickness)
        {
            switch(thickness)
                {
                case 3:
                    thicknessMatrix = new List<List<int>>
                    {
                        new List<int> {0 , 1 , 0 },
                        new List<int> {1 , 1 , 1 },
                        new List<int> {0 , 1 , 0 }
                    };
                    break;
                case 5:
                    thicknessMatrix = new List<List<int>>
                    {
                        new List<int> {0 , 1 , 1 , 1, 0},
                        new List<int> {1 , 1 , 1 , 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1},
                        new List<int> {0 , 1 , 1,  1, 0 }
                    };
                    break;
                case 9:
                    thicknessMatrix = new List<List<int>>
                    {
                        new List<int> {0 , 1 , 1 , 1, 1, 1, 1, 1, 0},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {1 , 1 , 1 , 1, 1, 1, 1, 1, 1},
                        new List<int> {0 , 1 , 1 , 1, 1, 1, 1, 1, 0}
                    };

                    break;
                }
        }
        public void putPixel(int x, int y)
        {
            if (thickness == 1)
            {
                if (x < bitmap.Width && y < bitmap.Height && y >= 0 && x >= 0)
                {
                    bitmap.SetPixel(x, y, Color.Black);
                    pictureBox.Image = bitmap;
                }
            }
            else
            {
                loadThicknessMatrix(thickness);
                int filterX = (int)Math.Floor((double)thicknessMatrix.Count() / 2);
                int filterY = (int)Math.Floor((double)thicknessMatrix[0].Count() / 2);

                for (int i = -filterX; i <= filterX; i++)
                {
                    for (int j = -filterY; j <= filterY; j++)
                    {
                        int correspondingXIndex = x + i;
                        int correspondingXFilter = i + filterX;
                        int correspondingYIndex = y + j;
                        int correspondingYFilter = j + filterY;

                        if (thicknessMatrix[correspondingXFilter][correspondingYFilter] == 1 && correspondingXIndex>=0 && correspondingYIndex>=0 && correspondingXIndex < bitmap.Width && correspondingYIndex < bitmap.Height)
                        {

                            bitmap.SetPixel(correspondingXIndex, correspondingYIndex, Color.Black);
                            pictureBox.Image = bitmap;

                        }
                        
                    }

                }


              }
            
        }

    
        private void thicknessTextBox_TextChanged(object sender, EventArgs e)
        {
            thickness = (thicknessTextBox.Text != null ? Convert.ToInt32(thicknessTextBox.Text) : 1);
            thicknessLabel.Text = thickness.ToString();
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
            putPixel(xf, yf);
            putPixel(xb, yb);
            while (xf < xb)
            {
                ++xf;
                --xb;
                if (d < 0)
                    d += dE;
                else
                {
                    d += dNE;
                    ++yf;
                    --yb;
                }
                putPixel(xf, yf);
                putPixel(xb, yb);
            }
        }

        private void symmetricMidPointLineButton_Click(object sender, EventArgs e)
        {
            SymmetricLine(a.X, a.Y, b.X, b.Y);
        }
        public void allOctets(Point Center, int x, int y)
        {
            if (Center.X + x >= 0 && Center.X + x <= bitmap.Width - 1 && Center.Y + y >= 0 && Center.Y + y <= bitmap.Height - 1) putPixel(Center.X + x, Center.Y + y);
            if (Center.X + x >= 0 && Center.X + x <= bitmap.Width - 1 && Center.Y - y >= 0 && Center.Y - y <= bitmap.Height - 1) putPixel(Center.X + x, Center.Y - y);
            if (Center.X - x >= 0 && Center.X - x <= bitmap.Width - 1 && Center.Y + y >= 0 && Center.Y + y <= bitmap.Height - 1) putPixel(Center.X - x, Center.Y + y);
            if (Center.X - x >= 0 && Center.X - x <= bitmap.Width - 1 && Center.Y - y >= 0 && Center.Y - y <= bitmap.Height - 1) putPixel(Center.X - x, Center.Y - y);
            if (Center.X + y >= 0 && Center.X + y <= bitmap.Width - 1 && Center.Y + x >= 0 && Center.Y + x <= bitmap.Height - 1) putPixel(Center.X + y, Center.Y + x);
            if (Center.X + y >= 0 && Center.X + y <= bitmap.Width - 1 && Center.Y - x >= 0 && Center.Y - x <= bitmap.Height - 1) putPixel(Center.X + y, Center.Y - x);
            if (Center.X - y >= 0 && Center.X - y <= bitmap.Width - 1 && Center.Y + x >= 0 && Center.Y + x <= bitmap.Height - 1) putPixel(Center.X - y, Center.Y + x);
            if (Center.X - y >= 0 && Center.X - y <= bitmap.Width - 1 && Center.Y - x >= 0 && Center.Y - x <= bitmap.Height - 1) putPixel(Center.X - y, Center.Y - x);
        }

        private void MidpointCircle(Point Center, int R)
        {
            
            int d = 1 - R;
            int x = 0 ;
            int y = R ;
            while (y > x)
            {

                allOctets(Center,x,y);
                if (d < 0) //move to E
                    d += 2 * x + 3;
                else //move to SE
                {
                    d += 2 * x - 2 * y + 5;
                    y--;
                }
                x++;
            }
        }


        private void midPointCircleButton_Click(object sender, EventArgs e)
        {
            int xCenter = a.X + (b.X -a.X)/2;
            int yCenter = a.Y + (b.Y - a.Y) / 2;
            int radius = (int)Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2)) / 2;
            Point Center = new Point(xCenter, yCenter);
            MidpointCircle(Center, radius);
      
        }
        
        public void xiaolinWuLine(Point point1, Point point2)
        {
            List<ColorPoint> points = new List<ColorPoint>();
            bool direction = Math.Abs(point2.Y - point1.Y) > Math.Abs(point2.X - point1.X);
            if (direction)//replace x and y
            {
                Point tmp = new Point(point1.X, point1.Y);
                Point tmp2 = new Point(point2.X, point2.Y);
                point1 = new Point(tmp.Y, tmp.X);
                point2 = new Point(tmp2.Y, tmp2.X);
            }
            if (point1.X > point2.X)//replace points
            {
                Point tmp = new Point(point1.X, point1.Y);
                Point tmp2 = new Point(point2.X, point2.Y);
                point1 = new Point(tmp2.X, tmp2.Y);
                point2 = new Point(tmp.X, tmp.Y);
            }
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;
            double gradient = (double)((double)(dy) / (double)(dx));
            //first point
            int endX = round(point1.X);
            double endY = point1.Y + gradient * (endX - point1.X);
            double gapX = rfPart(point1.X + 0.5);
            int pxlX_1 = endX;
            int pxlY_1 = iPart(endY);
            if (direction)
            {
                Point a = new Point(pxlY_1, pxlX_1);
                ColorPoint b = new ColorPoint(pxlY_1, pxlX_1, (int)(rfPart(endY) * gapX * 255));
                points.Add(b);
                b = new ColorPoint(pxlY_1 + 1, pxlX_1, (int)(fPart(endY) * gapX * 255));
                points.Add(b);
            }
            else
            {
                Point a = new Point(pxlX_1, pxlY_1);
                ColorPoint b = new ColorPoint(pxlX_1, pxlY_1, (int)(rfPart(endY) * gapX * 255));
                points.Add(b);
                b = new ColorPoint(pxlX_1, pxlY_1 + 1, (int)(fPart(endY) * gapX * 255));
                points.Add(b);
            }
            double intery = endY + gradient;

            //second point
            endX = round(point2.X);
            endY = point2.Y + gradient * (endX - point2.X);
            gapX = fPart(point2.X + 0.5);
            int pxlX_2 = endX;
            int pxlY_2 = iPart(endY);
            if (direction)
            {
                Point a = new Point(pxlY_2, pxlX_2);
                ColorPoint b = new ColorPoint(pxlY_2, pxlX_2, (int)(rfPart(endY) * gapX * 255));
                points.Add(b);
                b = new ColorPoint(pxlY_2 + 1, pxlX_2, (int)(fPart(endY) * gapX * 255));
                points.Add(b);
            }
            else
            {
                Point a = new Point(pxlX_2, pxlY_2);
                ColorPoint b = new ColorPoint(pxlX_2, pxlY_2, (int)(rfPart(endY) * gapX * 255));
                points.Add(b);
                b = new ColorPoint(pxlX_2, pxlY_2 + 1, (int)(fPart(endY) * gapX * 255));
                points.Add(b);
            }

            //loop from all points
            for (double x = (pxlX_1 + 1); x <= (pxlX_2 - 1); x++)
            {
                if (direction)
                {
                    Point a = new Point(iPart(intery), (int)x);
                    ColorPoint b = new ColorPoint(iPart(intery), (int)x, (int)(rfPart(intery) * 255));
                    points.Add(b);
                    b = new ColorPoint((iPart(intery) + 1), (int)x, (int)(fPart(intery) * 255));
                    points.Add(b);
                }
                else
                {
                    Point a = new Point((int)x, iPart(intery));
                    ColorPoint b = new ColorPoint((int)x, iPart(intery), (int)(rfPart(intery) * 255));
                    points.Add(b);
                    b = new ColorPoint((int)x, iPart(intery) + 1, (int)(fPart(intery) * 255));
                    points.Add(b);
                }
                intery += gradient;
            }
            Color c1 = Color.Black;
            foreach (ColorPoint a in points) //draw each pixel
            {
                //take care for extremes - if mouse outside from picture-box
                int shade = 0;
                if (a.get_color() < 0)
                {
                    shade = 0;
                }
                else if (a.get_color() > 255)
                {
                    shade = 255;
                }
                else
                {
                    shade = a.get_color();
                }
                Color c2 = Color.FromArgb(shade, c1.R, c1.G, c1.B);
                bitmap.SetPixel(a.get_x(), a.get_y(), c2);
                pictureBox.Image = bitmap;
            }

        }
        private void xiaolinLineButton_Click(object sender, EventArgs e)
        {
            xiaolinWuLine(a, b);
        }
     
        private void xiaolinCircleButton_Click(object sender, EventArgs e)
        {
            
            xiaolinWuCircle(a, b);
        }

        public void xiaolinWuCircle(Point start_point,Point end_point)
        {
           
            int offset_x = start_point.X + (end_point.X - start_point.X) / 2;
            int offset_y = start_point.Y + (end_point.Y - start_point.Y) / 2;
            
            Color color = Color.Black;
            int r = (int)Math.Sqrt(Math.Pow((end_point.X - start_point.X), 2) + Math.Pow((end_point.Y - start_point.Y), 2)) / 2;
            
            int x = r;
            int y = -1;
            double t = 0;

            while (x - 1 > y)
            {
                y++;
                double current_distance = distance(r, y);
                if (current_distance < t)
                {
                    x--;
                }
       
                int transparency = new_color(current_distance);
                int alpha = transparency;
                int alpha2 = 127 - transparency;
                Color c2 = Color.FromArgb(255, color.R, color.G, color.B);
                Color c3 = Color.FromArgb(alpha2, color.R, color.G, color.B);
                Color c4 = Color.FromArgb(alpha, color.R, color.G, color.B);

                
                bitmap.SetPixel(x + offset_x, y + offset_y, c2);
                bitmap.SetPixel(x + offset_x - 1, y + offset_y, c4);
                bitmap.SetPixel(x + offset_x + 1, y + offset_y, c3);

                bitmap.SetPixel(y + offset_x, x + offset_y, c2);
                bitmap.SetPixel(y + offset_x, x + offset_y - 1, c4);
                bitmap.SetPixel(y + offset_x, x + offset_y + 1, c3);

   
                bitmap.SetPixel(offset_x - x, y + offset_y, c2);
                bitmap.SetPixel(offset_x - x + 1, y + offset_y - 1, c4);
                bitmap.SetPixel(offset_x - x - 1, y + offset_y + 1, c3);
         

                bitmap.SetPixel(offset_x - y, x + offset_y, c2);
                bitmap.SetPixel(offset_x - y, x + offset_y - 1, c4);
                bitmap.SetPixel(offset_x - y, x + offset_y + 1, c3);

                bitmap.SetPixel(x + offset_x,  offset_y - y, c2);
                bitmap.SetPixel(x + offset_x - 1,  offset_y - y, c4);
                bitmap.SetPixel(x + offset_x + 1, + offset_y - y, c3);
                
                bitmap.SetPixel(y + offset_x, offset_y - x , c2);
                bitmap.SetPixel(y + offset_x, offset_y - x - 1, c3);
                bitmap.SetPixel(y + offset_x, offset_y - x + 1, c4);

                bitmap.SetPixel(offset_x - y, offset_y - x, c2);
                bitmap.SetPixel(offset_x - y, offset_y - x - 1 , c3);
                bitmap.SetPixel(offset_x - y, offset_y - x + 1 , c4);

                bitmap.SetPixel(offset_x - x, offset_y - y, c2);
                bitmap.SetPixel(offset_x - x - 1, offset_y - y, c3);
                bitmap.SetPixel(offset_x - x + 1, offset_y - y, c4);
                pictureBox.Image = bitmap;


                t = current_distance;
            }
            
        }

        double distance(int x, int y)
        {
            double real_point = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(y, 2));
            return (Math.Ceiling(real_point) - real_point);
        }
        int new_color(double i)
        {
            return (int)Math.Round((i * 127));
        }

        //functions for calculating
        int iPart(double d)
        {
            return (int)d;
        }

        int round(double d)
        {
            return (int)(d + 0.50000);
        }

        double fPart(double d)
        {
            return (double)(d - (int)(d));
        }

        double rfPart(double d)
        {
            return (double)(1.00000 - (double)(d - (int)(d)));
        }
        
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(drawOn)
            {
                MouseEventArgs me = (MouseEventArgs)e;

                if(clickCounter == 2)
                {
                    a = me.Location;
                    aCoordinateLabel.Text = a.X + ":" + a.Y ;
                    clickCounter--;
                    setClickCounter(clickCounter);
                }
                else if(clickCounter == 1)
                {
                    b = me.Location;
                    bCoordinateLabel.Text = b.X + ":" + b.Y;
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

       
    }
}

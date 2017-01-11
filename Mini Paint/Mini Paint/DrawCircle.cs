using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mini_Paint
{
    class DrawCircle
    {
        mathMethod mm = new mathMethod();

        public void DrawPembangkitanLingkaran(Point p0, Point p1, Graphics g)
        {
            //create tools
            SolidBrush brush = new SolidBrush(Color.HotPink);

            //masukkan pusat lingkaran dan jari-jari
            int R = mm.getR(p0, p1);
            int pKeputusan = 0;
            int x = 0, y = R;// untuk increment

            //tentukan parameter keputusan
            if(R % 1 == 0)//jika jari-jari adalah integer
            {
                pKeputusan = 1 - R;
            }
            else
            {
                pKeputusan = 5 / 4 - R;
            }

            while(x < y)//hentikan ketika x >= y
            {
                x++;
                if (pKeputusan < 0)
                {                   
                    pKeputusan += 2 * x + 1;
                }
                else
                {
                    y--;
                    pKeputusan += 2 * (x - y) + 1;
                }

                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y + y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X + y, p0.Y + x), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X + y, p0.Y - x), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y - y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y - y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - y, p0.Y - x), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - y, p0.Y + x), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y + y), new Size(1, 1)));
            }
        }

        public void DrawEllipse(Point p0, Point p1, Graphics g)
        {
            //create tools
            SolidBrush brush = new SolidBrush(Color.Magenta);
            Pen pen = new Pen(Color.Magenta);

            //cari mayor minor
            int rx = (int)Math.Abs(mm.getDeltaX(p0, p1));
            int ry = (int)Math.Abs(mm.getDeltaY(p0, p1));
            int rx2 = rx * rx;
            int ry2 = ry * ry;

            int x = 0, y = ry;// increment

            //untuk kanan bawah dan kanan
            int P1 = (int) (ry2 - rx2 * ry + 0.25 * rx2);
            while(2*ry2*x < 2*rx2*y)
            {
                x++;
                if(P1 < 0)
                {
                    P1 += ry2 * ((2 * x) + 1);
                }
                else
                {
                    y--;
                    P1 += ry2 * ((2 * x) + 2) - rx2 * (2 * y - 1);
                }

                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y + y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y + y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y - y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y - y), new Size(1, 1)));

            }

            //untuk kanan bawah dan kanan
            int P2 = (int) (ry2 * ((x + 0.5) * (x + 0.5)) + rx2 * ((y - 1) * (y)) - rx2 * ry2);
            while (y > 0)
            {
                y--;
                if (P2 > 0)
                {
                    P2 += rx2 * (1 - 2 * y);
                }
                else
                {
                    x++;
                    P2 += 2 * ry2 * x - rx2 * (2 * y - 1);
                }

                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y + y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y + y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X + x, p0.Y - y), new Size(1, 1)));
                g.FillRectangle(brush, new Rectangle(new Point(p0.X - x, p0.Y - y), new Size(1, 1)));
            }

        }
    }
}
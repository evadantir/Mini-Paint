using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        //untuk inisialisasi area paint
        DrawLine dl = new DrawLine();
        DrawCircle dc = new DrawCircle();
        DrawNGon dg = new DrawNGon();

        private Point p0, p1;
        private Bitmap drawArea;
        private Graphics g;
        private Pen pen = new Pen(Color.Black);

        bool clicked = false;

        public Form1()
        {
            //set paint area
            InitializeComponent();

            drawArea = new Bitmap(pictureBoxPaint.Size.Width, pictureBoxPaint.Size.Height);
            pictureBoxPaint.Image = drawArea;
            g = Graphics.FromImage(drawArea);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxPaint_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            //titik awal
            p0 = e.Location;
            x0.Text = Convert.ToString(e.Location.X);
            y0.Text = Convert.ToString(e.Location.Y);
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            x1.Text = Convert.ToString(e.Location.X);
            y1.Text = Convert.ToString(e.Location.Y);


        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = true;
            p1 = e.Location;  //titik akhir
            //g.Clear(Color.White);
            Draw();
            x1.Text = Convert.ToString(e.Location.X);
            y1.Text = Convert.ToString(e.Location.Y);
            pictureBoxPaint.Invalidate();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(this.pictureBoxPaint.BackColor);
            pictureBoxPaint.Invalidate();

            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }

        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void nudNGon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Draw()
        {
            int n = (int)nudNGon.Value;
            if (rbtDDA.Checked && clicked == true)
            {
                dl.DrawDDA(p0,p1,pen,g);
            }
            else if (rbtNaive.Checked && clicked == true)
            {
                dl.DrawNaive(p0,p1,pen,g);
            }
            else if(rbtBresenham.Checked && clicked == true)
            {
                dl.DrawBresenham(p0,p1,pen,g);
            }
            else if(rbtCircle.Checked && clicked == true)
            {
                dc.DrawPembangkitanLingkaran(p0, p1, g);
            }
            else if(rbtEllipse.Checked && clicked == true)
            {
                dc.DrawEllipse(p0, p1, g);
            }
            else if (rbtPolygon.Checked && clicked == true)
            {
                dg.DrawPolygon(p0, p1, g, n);
            }
            else if (rbtStar.Checked && clicked == true)
            {
                dg.DrawStar(p0, p1, g, n);
            }
        }
    }
}

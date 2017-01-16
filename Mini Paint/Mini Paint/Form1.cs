using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        //untuk inisialisasi area paint
        DrawLine dl = new DrawLine();
        DrawCircle dc = new DrawCircle();
        DrawNGon dg = new DrawNGon();
        DrawTransformation dw = new DrawTransformation();

        private Point p0, p1;
        private Bitmap drawArea;
        private Graphics g;
        private Pen pen = new Pen(Color.Black);

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
            p1 = e.Location;  //titik akhir
            x1.Text = Convert.ToString(e.Location.X);
            y1.Text = Convert.ToString(e.Location.Y);
            DrawObject(p0, p1);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DrawObject(Point p0, Point p1)
        {
            int n = (int)nudNGon.Value;
            if (rbtDDA.Checked)
            {
                dl.DrawDDA(p0,p1,pen,g);
            }
            else if (rbtNaive.Checked)
            {
                dl.DrawNaive(p0,p1,pen,g);
            }
            else if(rbtBresenham.Checked)
            {
                dl.DrawBresenham(p0,p1,pen,g);
            }
            else if(rbtCircle.Checked)
            {
                dc.DrawPembangkitanLingkaran(p0, p1, g);
            }
            else if(rbtEllipse.Checked)
            {
                dc.DrawEllipse(p0, p1, g);
            }
            else if (rbtPolygon.Checked)
            {
                dg.DrawPolygon(p0, p1, g, n);
            }
            else if (rbtStar.Checked)
            {
                dg.DrawStar(p0, p1, g, n);
            }
        }

        private void rbtEllipse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtTranslasi_CheckedChanged(object sender, EventArgs e)
        {
            lblDxd.Visible = true;
            lblDyd.Visible = true;
            dXd.Visible = true;
            dYd.Visible = true;
        }

        private void rbtDilatasi_CheckedChanged(object sender, EventArgs e)
        {
            lblKx.Visible = true;
            lblKy.Visible = true;
            txtKx.Visible = true;
            txtKy.Visible = true;
        }

        private void rbtRotasi_CheckedChanged(object sender, EventArgs e)
        {
            lblSudut.Visible = true;
            txtSudut.Visible = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
        }

        private void cbxCartesian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (rbtTranslasi.Checked == true)
            {
                twoPoint pHasil = new twoPoint();
                pHasil = dw.Translasi(p0, p1,Convert.ToInt32(dXd.Text), Convert.ToInt32(dYd.Text));
                Point pStart = new Point(pHasil.x0,pHasil.y0);
                Point pEnd = new Point(pHasil.x1, pHasil.y1);

                DrawObject(pStart, pEnd);
            }
            else if(rbtDilatasi.Checked==true)
            {
                twoPoint pHasil = new twoPoint();
                pHasil = dw.Dilatasi(p0, p1, Convert.ToInt32(txtKx.Text), Convert.ToInt32(txtKy.Text));
                Point pStart = new Point(pHasil.x0, pHasil.y0);
                Point pEnd = new Point(pHasil.x1, pHasil.y1);

                DrawObject(pStart, pEnd);
            }
            else if (rbtRotasi.Checked == true)
            {
                twoPoint pHasil = new twoPoint();
                pHasil = dw.Rotasi(p0, p1, Convert.ToDouble(txtSudut.Text));
                Point pStart = new Point(pHasil.x0, pHasil.y0);
                Point pEnd = new Point(pHasil.x1, pHasil.y1);

                DrawObject(pStart, pEnd);
            }
             else if (rbtRefleksi.Checked == true)
             {
                 twoPoint pHasil = new twoPoint();
             }
            pictureBoxPaint.Invalidate();
        }
    }
}

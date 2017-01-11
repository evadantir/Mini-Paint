namespace Mini_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x0 = new System.Windows.Forms.TextBox();
            this.y0 = new System.Windows.Forms.TextBox();
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtDDA = new System.Windows.Forms.RadioButton();
            this.rbtNaive = new System.Windows.Forms.RadioButton();
            this.rbtBresenham = new System.Windows.Forms.RadioButton();
            this.rbtCircle = new System.Windows.Forms.RadioButton();
            this.rbtEllipse = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNGon = new System.Windows.Forms.NumericUpDown();
            this.rbtPolygon = new System.Windows.Forms.RadioButton();
            this.rbtStar = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dXd = new System.Windows.Forms.TextBox();
            this.dYd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTransform = new System.Windows.Forms.Button();
            this.rbtDilatasi = new System.Windows.Forms.RadioButton();
            this.rbtRefleksi = new System.Windows.Forms.RadioButton();
            this.rbtTranslasi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNGon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "y0";
            // 
            // x0
            // 
            this.x0.Enabled = false;
            this.x0.Location = new System.Drawing.Point(18, 673);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(64, 22);
            this.x0.TabIndex = 8;
            // 
            // y0
            // 
            this.y0.Enabled = false;
            this.y0.Location = new System.Drawing.Point(117, 675);
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(64, 22);
            this.y0.TabIndex = 9;
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.BackColor = System.Drawing.Color.White;
            this.pictureBoxPaint.Location = new System.Drawing.Point(12, 157);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(955, 488);
            this.pictureBoxPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPaint.TabIndex = 18;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.Click += new System.EventHandler(this.pictureBoxPaint_Click);
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "y1";
            // 
            // y1
            // 
            this.y1.Enabled = false;
            this.y1.Location = new System.Drawing.Point(903, 675);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(64, 22);
            this.y1.TabIndex = 11;
            // 
            // x1
            // 
            this.x1.Enabled = false;
            this.x1.Location = new System.Drawing.Point(821, 675);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(64, 22);
            this.x1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "x1";
            // 
            // rbtDDA
            // 
            this.rbtDDA.AutoSize = true;
            this.rbtDDA.Location = new System.Drawing.Point(223, 21);
            this.rbtDDA.Name = "rbtDDA";
            this.rbtDDA.Size = new System.Drawing.Size(58, 21);
            this.rbtDDA.TabIndex = 19;
            this.rbtDDA.TabStop = true;
            this.rbtDDA.Text = "DDA";
            this.rbtDDA.UseVisualStyleBackColor = true;
            // 
            // rbtNaive
            // 
            this.rbtNaive.AutoSize = true;
            this.rbtNaive.Location = new System.Drawing.Point(9, 48);
            this.rbtNaive.Name = "rbtNaive";
            this.rbtNaive.Size = new System.Drawing.Size(188, 21);
            this.rbtNaive.TabIndex = 21;
            this.rbtNaive.TabStop = true;
            this.rbtNaive.Text = "Persamaan Garis Normal";
            this.rbtNaive.UseVisualStyleBackColor = true;
            // 
            // rbtBresenham
            // 
            this.rbtBresenham.AutoSize = true;
            this.rbtBresenham.Location = new System.Drawing.Point(9, 21);
            this.rbtBresenham.Name = "rbtBresenham";
            this.rbtBresenham.Size = new System.Drawing.Size(101, 21);
            this.rbtBresenham.TabIndex = 22;
            this.rbtBresenham.TabStop = true;
            this.rbtBresenham.Text = "Bresenham";
            this.rbtBresenham.UseVisualStyleBackColor = true;
            // 
            // rbtCircle
            // 
            this.rbtCircle.AutoSize = true;
            this.rbtCircle.Location = new System.Drawing.Point(223, 48);
            this.rbtCircle.Name = "rbtCircle";
            this.rbtCircle.Size = new System.Drawing.Size(64, 21);
            this.rbtCircle.TabIndex = 23;
            this.rbtCircle.TabStop = true;
            this.rbtCircle.Text = "Circle";
            this.rbtCircle.UseVisualStyleBackColor = true;
            // 
            // rbtEllipse
            // 
            this.rbtEllipse.AutoSize = true;
            this.rbtEllipse.Location = new System.Drawing.Point(223, 75);
            this.rbtEllipse.Name = "rbtEllipse";
            this.rbtEllipse.Size = new System.Drawing.Size(70, 21);
            this.rbtEllipse.TabIndex = 24;
            this.rbtEllipse.TabStop = true;
            this.rbtEllipse.Text = "Ellipse";
            this.rbtEllipse.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudNGon);
            this.groupBox1.Controls.Add(this.rbtEllipse);
            this.groupBox1.Controls.Add(this.rbtPolygon);
            this.groupBox1.Controls.Add(this.rbtDDA);
            this.groupBox1.Controls.Add(this.rbtStar);
            this.groupBox1.Controls.Add(this.rbtCircle);
            this.groupBox1.Controls.Add(this.rbtNaive);
            this.groupBox1.Controls.Add(this.rbtBresenham);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 137);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembuatan Objek";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "N-side";
            // 
            // nudNGon
            // 
            this.nudNGon.Location = new System.Drawing.Point(223, 102);
            this.nudNGon.Name = "nudNGon";
            this.nudNGon.Size = new System.Drawing.Size(57, 22);
            this.nudNGon.TabIndex = 34;
            this.nudNGon.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNGon.ValueChanged += new System.EventHandler(this.nudNGon_ValueChanged);
            // 
            // rbtPolygon
            // 
            this.rbtPolygon.AutoSize = true;
            this.rbtPolygon.Location = new System.Drawing.Point(9, 75);
            this.rbtPolygon.Name = "rbtPolygon";
            this.rbtPolygon.Size = new System.Drawing.Size(80, 21);
            this.rbtPolygon.TabIndex = 33;
            this.rbtPolygon.TabStop = true;
            this.rbtPolygon.Text = "Polygon";
            this.rbtPolygon.UseVisualStyleBackColor = true;
            // 
            // rbtStar
            // 
            this.rbtStar.AutoSize = true;
            this.rbtStar.Location = new System.Drawing.Point(9, 102);
            this.rbtStar.Name = "rbtStar";
            this.rbtStar.Size = new System.Drawing.Size(55, 21);
            this.rbtStar.TabIndex = 32;
            this.rbtStar.TabStop = true;
            this.rbtStar.Text = "Star";
            this.rbtStar.UseVisualStyleBackColor = true;
            this.rbtStar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(433, 672);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtTranslasi);
            this.groupBox2.Controls.Add(this.rbtRefleksi);
            this.groupBox2.Controls.Add(this.rbtDilatasi);
            this.groupBox2.Controls.Add(this.btnTransform);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dYd);
            this.groupBox2.Controls.Add(this.dXd);
            this.groupBox2.Location = new System.Drawing.Point(334, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 137);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transformasi Objek";
            // 
            // dXd
            // 
            this.dXd.Location = new System.Drawing.Point(45, 47);
            this.dXd.Name = "dXd";
            this.dXd.Size = new System.Drawing.Size(45, 22);
            this.dXd.TabIndex = 1;
            // 
            // dYd
            // 
            this.dYd.Location = new System.Drawing.Point(125, 46);
            this.dYd.Name = "dYd";
            this.dYd.Size = new System.Drawing.Size(45, 22);
            this.dYd.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Δx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Δy";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(510, 101);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(101, 23);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "Transformasi";
            this.btnTransform.UseVisualStyleBackColor = true;
            // 
            // rbtDilatasi
            // 
            this.rbtDilatasi.AutoSize = true;
            this.rbtDilatasi.Location = new System.Drawing.Point(10, 85);
            this.rbtDilatasi.Name = "rbtDilatasi";
            this.rbtDilatasi.Size = new System.Drawing.Size(75, 21);
            this.rbtDilatasi.TabIndex = 6;
            this.rbtDilatasi.TabStop = true;
            this.rbtDilatasi.Text = "Dilatasi";
            this.rbtDilatasi.UseVisualStyleBackColor = true;
            // 
            // rbtRefleksi
            // 
            this.rbtRefleksi.AutoSize = true;
            this.rbtRefleksi.Location = new System.Drawing.Point(10, 112);
            this.rbtRefleksi.Name = "rbtRefleksi";
            this.rbtRefleksi.Size = new System.Drawing.Size(79, 21);
            this.rbtRefleksi.TabIndex = 7;
            this.rbtRefleksi.TabStop = true;
            this.rbtRefleksi.Text = "Refleksi";
            this.rbtRefleksi.UseVisualStyleBackColor = true;
            // 
            // rbtTranslasi
            // 
            this.rbtTranslasi.AutoSize = true;
            this.rbtTranslasi.Location = new System.Drawing.Point(11, 20);
            this.rbtTranslasi.Name = "rbtTranslasi";
            this.rbtTranslasi.Size = new System.Drawing.Size(87, 21);
            this.rbtTranslasi.TabIndex = 8;
            this.rbtTranslasi.TabStop = true;
            this.rbtTranslasi.Text = "Translasi";
            this.rbtTranslasi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxPaint);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y0);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mini Paint";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNGon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x0;
        private System.Windows.Forms.TextBox y0;
        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtDDA;
        private System.Windows.Forms.RadioButton rbtNaive;
        private System.Windows.Forms.RadioButton rbtBresenham;
        private System.Windows.Forms.RadioButton rbtCircle;
        private System.Windows.Forms.RadioButton rbtEllipse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtPolygon;
        private System.Windows.Forms.RadioButton rbtStar;
        private System.Windows.Forms.NumericUpDown nudNGon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dYd;
        private System.Windows.Forms.TextBox dXd;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.RadioButton rbtRefleksi;
        private System.Windows.Forms.RadioButton rbtDilatasi;
        private System.Windows.Forms.RadioButton rbtTranslasi;
    }
}


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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSudut = new System.Windows.Forms.TextBox();
            this.lblSudut = new System.Windows.Forms.Label();
            this.txtKx = new System.Windows.Forms.TextBox();
            this.txtKy = new System.Windows.Forms.TextBox();
            this.lblKx = new System.Windows.Forms.Label();
            this.lblKy = new System.Windows.Forms.Label();
            this.rbtRotasi = new System.Windows.Forms.RadioButton();
            this.btnTransform = new System.Windows.Forms.Button();
            this.rbtTranslasi = new System.Windows.Forms.RadioButton();
            this.dXd = new System.Windows.Forms.TextBox();
            this.rbtRefleksi = new System.Windows.Forms.RadioButton();
            this.dYd = new System.Windows.Forms.TextBox();
            this.rbtDilatasi = new System.Windows.Forms.RadioButton();
            this.lblDxd = new System.Windows.Forms.Label();
            this.lblDyd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtBound = new System.Windows.Forms.RadioButton();
            this.rbtScanLine = new System.Windows.Forms.RadioButton();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbxCartesian = new System.Windows.Forms.CheckBox();
            this.gbxSumbuRefleksi = new System.Windows.Forms.GroupBox();
            this.rbtReflekX = new System.Windows.Forms.RadioButton();
            this.rbtReflekY = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNGon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbxSumbuRefleksi.SuspendLayout();
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
            this.pictureBoxPaint.Location = new System.Drawing.Point(12, 242);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(951, 403);
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
            this.rbtDDA.Location = new System.Drawing.Point(12, 48);
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
            this.rbtNaive.Location = new System.Drawing.Point(12, 75);
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
            this.rbtCircle.Location = new System.Drawing.Point(311, 21);
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
            this.rbtEllipse.Location = new System.Drawing.Point(311, 48);
            this.rbtEllipse.Name = "rbtEllipse";
            this.rbtEllipse.Size = new System.Drawing.Size(70, 21);
            this.rbtEllipse.TabIndex = 24;
            this.rbtEllipse.TabStop = true;
            this.rbtEllipse.Text = "Ellipse";
            this.rbtEllipse.UseVisualStyleBackColor = true;
            this.rbtEllipse.CheckedChanged += new System.EventHandler(this.rbtEllipse_CheckedChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(401, 175);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembuatan Objek";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "N-side";
            // 
            // nudNGon
            // 
            this.nudNGon.Location = new System.Drawing.Point(318, 131);
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
            this.rbtPolygon.Location = new System.Drawing.Point(9, 116);
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
            this.rbtStar.Location = new System.Drawing.Point(9, 143);
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
            this.btnClear.Location = new System.Drawing.Point(423, 659);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 40);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(419, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 222);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gbxSumbuRefleksi);
            this.tabPage1.Controls.Add(this.txtSudut);
            this.tabPage1.Controls.Add(this.lblSudut);
            this.tabPage1.Controls.Add(this.txtKx);
            this.tabPage1.Controls.Add(this.txtKy);
            this.tabPage1.Controls.Add(this.lblKx);
            this.tabPage1.Controls.Add(this.lblKy);
            this.tabPage1.Controls.Add(this.rbtRotasi);
            this.tabPage1.Controls.Add(this.btnTransform);
            this.tabPage1.Controls.Add(this.rbtTranslasi);
            this.tabPage1.Controls.Add(this.dXd);
            this.tabPage1.Controls.Add(this.rbtRefleksi);
            this.tabPage1.Controls.Add(this.dYd);
            this.tabPage1.Controls.Add(this.rbtDilatasi);
            this.tabPage1.Controls.Add(this.lblDxd);
            this.tabPage1.Controls.Add(this.lblDyd);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transformasi";
            // 
            // txtSudut
            // 
            this.txtSudut.Location = new System.Drawing.Point(189, 72);
            this.txtSudut.Name = "txtSudut";
            this.txtSudut.Size = new System.Drawing.Size(103, 22);
            this.txtSudut.TabIndex = 14;
            this.txtSudut.Visible = false;
            // 
            // lblSudut
            // 
            this.lblSudut.AutoSize = true;
            this.lblSudut.Location = new System.Drawing.Point(138, 77);
            this.lblSudut.Name = "lblSudut";
            this.lblSudut.Size = new System.Drawing.Size(45, 17);
            this.lblSudut.TabIndex = 15;
            this.lblSudut.Text = "Sudut";
            this.lblSudut.Visible = false;
            // 
            // txtKx
            // 
            this.txtKx.Location = new System.Drawing.Point(167, 43);
            this.txtKx.Name = "txtKx";
            this.txtKx.Size = new System.Drawing.Size(45, 22);
            this.txtKx.TabIndex = 10;
            this.txtKx.Visible = false;
            // 
            // txtKy
            // 
            this.txtKy.Location = new System.Drawing.Point(247, 42);
            this.txtKy.Name = "txtKy";
            this.txtKy.Size = new System.Drawing.Size(45, 22);
            this.txtKy.TabIndex = 11;
            this.txtKy.Visible = false;
            // 
            // lblKx
            // 
            this.lblKx.AutoSize = true;
            this.lblKx.Location = new System.Drawing.Point(138, 44);
            this.lblKx.Name = "lblKx";
            this.lblKx.Size = new System.Drawing.Size(25, 17);
            this.lblKx.TabIndex = 12;
            this.lblKx.Text = " kx";
            this.lblKx.Visible = false;
            // 
            // lblKy
            // 
            this.lblKy.AutoSize = true;
            this.lblKy.Location = new System.Drawing.Point(218, 46);
            this.lblKy.Name = "lblKy";
            this.lblKy.Size = new System.Drawing.Size(22, 17);
            this.lblKy.TabIndex = 13;
            this.lblKy.Text = "ky";
            this.lblKy.Visible = false;
            // 
            // rbtRotasi
            // 
            this.rbtRotasi.AutoSize = true;
            this.rbtRotasi.Location = new System.Drawing.Point(18, 74);
            this.rbtRotasi.Name = "rbtRotasi";
            this.rbtRotasi.Size = new System.Drawing.Size(69, 21);
            this.rbtRotasi.TabIndex = 9;
            this.rbtRotasi.TabStop = true;
            this.rbtRotasi.Text = "Rotasi";
            this.rbtRotasi.UseVisualStyleBackColor = true;
            this.rbtRotasi.CheckedChanged += new System.EventHandler(this.rbtRotasi_CheckedChanged);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(410, 146);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(116, 39);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "Transformasi";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // rbtTranslasi
            // 
            this.rbtTranslasi.AutoSize = true;
            this.rbtTranslasi.Location = new System.Drawing.Point(18, 12);
            this.rbtTranslasi.Name = "rbtTranslasi";
            this.rbtTranslasi.Size = new System.Drawing.Size(87, 21);
            this.rbtTranslasi.TabIndex = 8;
            this.rbtTranslasi.TabStop = true;
            this.rbtTranslasi.Text = "Translasi";
            this.rbtTranslasi.UseVisualStyleBackColor = true;
            this.rbtTranslasi.CheckedChanged += new System.EventHandler(this.rbtTranslasi_CheckedChanged);
            // 
            // dXd
            // 
            this.dXd.Location = new System.Drawing.Point(167, 13);
            this.dXd.Name = "dXd";
            this.dXd.Size = new System.Drawing.Size(45, 22);
            this.dXd.TabIndex = 1;
            this.dXd.Visible = false;
            // 
            // rbtRefleksi
            // 
            this.rbtRefleksi.AutoSize = true;
            this.rbtRefleksi.Location = new System.Drawing.Point(18, 104);
            this.rbtRefleksi.Name = "rbtRefleksi";
            this.rbtRefleksi.Size = new System.Drawing.Size(79, 21);
            this.rbtRefleksi.TabIndex = 7;
            this.rbtRefleksi.TabStop = true;
            this.rbtRefleksi.Text = "Refleksi";
            this.rbtRefleksi.UseVisualStyleBackColor = true;
            this.rbtRefleksi.CheckedChanged += new System.EventHandler(this.rbtRefleksi_CheckedChanged);
            // 
            // dYd
            // 
            this.dYd.Location = new System.Drawing.Point(247, 12);
            this.dYd.Name = "dYd";
            this.dYd.Size = new System.Drawing.Size(45, 22);
            this.dYd.TabIndex = 2;
            this.dYd.Visible = false;
            // 
            // rbtDilatasi
            // 
            this.rbtDilatasi.AutoSize = true;
            this.rbtDilatasi.Location = new System.Drawing.Point(18, 43);
            this.rbtDilatasi.Name = "rbtDilatasi";
            this.rbtDilatasi.Size = new System.Drawing.Size(75, 21);
            this.rbtDilatasi.TabIndex = 6;
            this.rbtDilatasi.TabStop = true;
            this.rbtDilatasi.Text = "Dilatasi";
            this.rbtDilatasi.UseVisualStyleBackColor = true;
            this.rbtDilatasi.CheckedChanged += new System.EventHandler(this.rbtDilatasi_CheckedChanged);
            // 
            // lblDxd
            // 
            this.lblDxd.AutoSize = true;
            this.lblDxd.Location = new System.Drawing.Point(138, 14);
            this.lblDxd.Name = "lblDxd";
            this.lblDxd.Size = new System.Drawing.Size(23, 17);
            this.lblDxd.TabIndex = 3;
            this.lblDxd.Text = "Δx";
            this.lblDxd.Visible = false;
            // 
            // lblDyd
            // 
            this.lblDyd.AutoSize = true;
            this.lblDyd.Location = new System.Drawing.Point(218, 16);
            this.lblDyd.Name = "lblDyd";
            this.lblDyd.Size = new System.Drawing.Size(24, 17);
            this.lblDyd.TabIndex = 4;
            this.lblDyd.Text = "Δy";
            this.lblDyd.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.rbtBound);
            this.tabPage2.Controls.Add(this.rbtScanLine);
            this.tabPage2.Controls.Add(this.btnColor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fill Color";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Scan Line Algorithm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtBound
            // 
            this.rbtBound.AutoSize = true;
            this.rbtBound.Location = new System.Drawing.Point(17, 64);
            this.rbtBound.Name = "rbtBound";
            this.rbtBound.Size = new System.Drawing.Size(174, 21);
            this.rbtBound.TabIndex = 2;
            this.rbtBound.TabStop = true;
            this.rbtBound.Text = "Boundary Fill Algorithm";
            this.rbtBound.UseVisualStyleBackColor = true;
            // 
            // rbtScanLine
            // 
            this.rbtScanLine.AutoSize = true;
            this.rbtScanLine.Location = new System.Drawing.Point(17, 23);
            this.rbtScanLine.Name = "rbtScanLine";
            this.rbtScanLine.Size = new System.Drawing.Size(155, 21);
            this.rbtScanLine.TabIndex = 1;
            this.rbtScanLine.TabStop = true;
            this.rbtScanLine.Text = "Scan Line Algorithm";
            this.rbtScanLine.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(373, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(127, 35);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Pilih Warna";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbxCartesian
            // 
            this.cbxCartesian.AutoSize = true;
            this.cbxCartesian.Location = new System.Drawing.Point(12, 195);
            this.cbxCartesian.Name = "cbxCartesian";
            this.cbxCartesian.Size = new System.Drawing.Size(159, 21);
            this.cbxCartesian.TabIndex = 28;
            this.cbxCartesian.Text = "Tampilkan Cartesian";
            this.cbxCartesian.UseVisualStyleBackColor = true;
            this.cbxCartesian.CheckedChanged += new System.EventHandler(this.cbxCartesian_CheckedChanged);
            // 
            // gbxSumbuRefleksi
            // 
            this.gbxSumbuRefleksi.Controls.Add(this.rbtReflekX);
            this.gbxSumbuRefleksi.Controls.Add(this.rbtReflekY);
            this.gbxSumbuRefleksi.Location = new System.Drawing.Point(18, 132);
            this.gbxSumbuRefleksi.Name = "gbxSumbuRefleksi";
            this.gbxSumbuRefleksi.Size = new System.Drawing.Size(386, 55);
            this.gbxSumbuRefleksi.TabIndex = 16;
            this.gbxSumbuRefleksi.TabStop = false;
            this.gbxSumbuRefleksi.Text = "Sumbu";
            this.gbxSumbuRefleksi.Visible = false;
            // 
            // rbtReflekX
            // 
            this.rbtReflekX.AutoSize = true;
            this.rbtReflekX.Location = new System.Drawing.Point(6, 24);
            this.rbtReflekX.Name = "rbtReflekX";
            this.rbtReflekX.Size = new System.Drawing.Size(38, 21);
            this.rbtReflekX.TabIndex = 18;
            this.rbtReflekX.TabStop = true;
            this.rbtReflekX.Text = "X";
            this.rbtReflekX.UseVisualStyleBackColor = true;
            // 
            // rbtReflekY
            // 
            this.rbtReflekY.AutoSize = true;
            this.rbtReflekY.Location = new System.Drawing.Point(98, 24);
            this.rbtReflekY.Name = "rbtReflekY";
            this.rbtReflekY.Size = new System.Drawing.Size(38, 21);
            this.rbtReflekY.TabIndex = 17;
            this.rbtReflekY.TabStop = true;
            this.rbtReflekY.Text = "Y";
            this.rbtReflekY.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 711);
            this.Controls.Add(this.cbxCartesian);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbxSumbuRefleksi.ResumeLayout(false);
            this.gbxSumbuRefleksi.PerformLayout();
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
        private System.Windows.Forms.Label lblDyd;
        private System.Windows.Forms.Label lblDxd;
        private System.Windows.Forms.TextBox dYd;
        private System.Windows.Forms.TextBox dXd;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.RadioButton rbtRefleksi;
        private System.Windows.Forms.RadioButton rbtDilatasi;
        private System.Windows.Forms.RadioButton rbtTranslasi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSudut;
        private System.Windows.Forms.Label lblSudut;
        private System.Windows.Forms.TextBox txtKx;
        private System.Windows.Forms.TextBox txtKy;
        private System.Windows.Forms.Label lblKx;
        private System.Windows.Forms.Label lblKy;
        private System.Windows.Forms.RadioButton rbtRotasi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtBound;
        private System.Windows.Forms.RadioButton rbtScanLine;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox cbxCartesian;
        private System.Windows.Forms.GroupBox gbxSumbuRefleksi;
        private System.Windows.Forms.RadioButton rbtReflekX;
        private System.Windows.Forms.RadioButton rbtReflekY;
    }
}


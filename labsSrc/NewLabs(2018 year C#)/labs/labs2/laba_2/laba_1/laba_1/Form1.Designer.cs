namespace laba_1
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windowA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.windowB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.windowC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.windowD = new System.Windows.Forms.NumericUpDown();
            this.par_A = new System.Windows.Forms.NumericUpDown();
            this.par_B = new System.Windows.Forms.NumericUpDown();
            this.par_G = new System.Windows.Forms.NumericUpDown();
            this.par_D = new System.Windows.Forms.NumericUpDown();
            this.par_E = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_01 = new System.Windows.Forms.RadioButton();
            this.radio_001 = new System.Windows.Forms.RadioButton();
            this.radio_0001 = new System.Windows.Forms.RadioButton();
            this.radio_00001 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button_UP = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maxNtext = new System.Windows.Forms.Label();
            this.maxN = new System.Windows.Forms.TextBox();
            this.numeric_a = new System.Windows.Forms.NumericUpDown();
            this.numeric_b = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_G = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_E = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_b)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Enabled = false;
            this.zedGraph.ForeColor = System.Drawing.Color.White;
            this.zedGraph.IsShowPointValues = false;
            this.zedGraph.Location = new System.Drawing.Point(12, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.PointValueFormat = "G";
            this.zedGraph.Size = new System.Drawing.Size(570, 488);
            this.zedGraph.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер окна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // windowA
            // 
            this.windowA.DecimalPlaces = 1;
            this.windowA.Location = new System.Drawing.Point(612, 38);
            this.windowA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowA.Name = "windowA";
            this.windowA.Size = new System.Drawing.Size(57, 20);
            this.windowA.TabIndex = 9;
            this.windowA.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // windowB
            // 
            this.windowB.DecimalPlaces = 1;
            this.windowB.Location = new System.Drawing.Point(698, 38);
            this.windowB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowB.Name = "windowB";
            this.windowB.Size = new System.Drawing.Size(52, 20);
            this.windowB.TabIndex = 7;
            this.windowB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "C";
            // 
            // windowC
            // 
            this.windowC.DecimalPlaces = 1;
            this.windowC.Location = new System.Drawing.Point(698, 66);
            this.windowC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowC.Name = "windowC";
            this.windowC.Size = new System.Drawing.Size(52, 20);
            this.windowC.TabIndex = 9;
            this.windowC.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "D";
            // 
            // windowD
            // 
            this.windowD.DecimalPlaces = 1;
            this.windowD.Location = new System.Drawing.Point(612, 66);
            this.windowD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowD.Name = "windowD";
            this.windowD.Size = new System.Drawing.Size(57, 20);
            this.windowD.TabIndex = 11;
            this.windowD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // par_A
            // 
            this.par_A.Location = new System.Drawing.Point(70, 19);
            this.par_A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_A.Name = "par_A";
            this.par_A.Size = new System.Drawing.Size(40, 20);
            this.par_A.TabIndex = 13;
            this.par_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // par_B
            // 
            this.par_B.Location = new System.Drawing.Point(70, 173);
            this.par_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_B.Name = "par_B";
            this.par_B.Size = new System.Drawing.Size(40, 20);
            this.par_B.TabIndex = 14;
            this.par_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // par_G
            // 
            this.par_G.Location = new System.Drawing.Point(70, 69);
            this.par_G.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_G.Name = "par_G";
            this.par_G.Size = new System.Drawing.Size(40, 20);
            this.par_G.TabIndex = 15;
            this.par_G.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // par_D
            // 
            this.par_D.Location = new System.Drawing.Point(70, 120);
            this.par_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_D.Name = "par_D";
            this.par_D.Size = new System.Drawing.Size(40, 20);
            this.par_D.TabIndex = 16;
            this.par_D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // par_E
            // 
            this.par_E.Location = new System.Drawing.Point(70, 227);
            this.par_E.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_E.Name = "par_E";
            this.par_E.Size = new System.Drawing.Size(40, 20);
            this.par_E.TabIndex = 17;
            this.par_E.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Число узлов интерполяции";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "n";
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(612, 396);
            this.numN.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(40, 20);
            this.numN.TabIndex = 20;
            this.numN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дэльта";
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Location = new System.Drawing.Point(744, 329);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(31, 17);
            this.radio_1.TabIndex = 23;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "1";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_01
            // 
            this.radio_01.AutoSize = true;
            this.radio_01.Location = new System.Drawing.Point(744, 352);
            this.radio_01.Name = "radio_01";
            this.radio_01.Size = new System.Drawing.Size(40, 17);
            this.radio_01.TabIndex = 24;
            this.radio_01.TabStop = true;
            this.radio_01.Text = "0,1";
            this.radio_01.UseVisualStyleBackColor = true;
            // 
            // radio_001
            // 
            this.radio_001.AutoSize = true;
            this.radio_001.Location = new System.Drawing.Point(744, 375);
            this.radio_001.Name = "radio_001";
            this.radio_001.Size = new System.Drawing.Size(46, 17);
            this.radio_001.TabIndex = 25;
            this.radio_001.TabStop = true;
            this.radio_001.Text = "0,01";
            this.radio_001.UseVisualStyleBackColor = true;
            // 
            // radio_0001
            // 
            this.radio_0001.AutoSize = true;
            this.radio_0001.Location = new System.Drawing.Point(744, 398);
            this.radio_0001.Name = "radio_0001";
            this.radio_0001.Size = new System.Drawing.Size(52, 17);
            this.radio_0001.TabIndex = 26;
            this.radio_0001.TabStop = true;
            this.radio_0001.Text = "0,001";
            this.radio_0001.UseVisualStyleBackColor = true;
            // 
            // radio_00001
            // 
            this.radio_00001.AutoSize = true;
            this.radio_00001.Location = new System.Drawing.Point(744, 421);
            this.radio_00001.Name = "radio_00001";
            this.radio_00001.Size = new System.Drawing.Size(58, 17);
            this.radio_00001.TabIndex = 27;
            this.radio_00001.TabStop = true;
            this.radio_00001.Text = "0,0001";
            this.radio_00001.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 28;
            // 
            // button_UP
            // 
            this.button_UP.Location = new System.Drawing.Point(595, 461);
            this.button_UP.Name = "button_UP";
            this.button_UP.Size = new System.Drawing.Size(97, 23);
            this.button_UP.TabIndex = 36;
            this.button_UP.Text = "Нарисовать";
            this.button_UP.UseVisualStyleBackColor = true;
            this.button_UP.Click += new System.EventHandler(this.button_UP_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(700, 461);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(90, 23);
            this.button_Clean.TabIndex = 37;
            this.button_Clean.Text = "Очистить";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::laba_1.Properties.Resources.alfa;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::laba_1.Properties.Resources.betta;
            this.pictureBox2.Location = new System.Drawing.Point(25, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 48);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::laba_1.Properties.Resources.gamma;
            this.pictureBox3.Location = new System.Drawing.Point(27, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 45);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::laba_1.Properties.Resources.epsi;
            this.pictureBox4.Location = new System.Drawing.Point(26, 227);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 41);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = global::laba_1.Properties.Resources.delta;
            this.pictureBox5.Location = new System.Drawing.Point(25, 120);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 47);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = global::laba_1.Properties.Resources.del;
            this.pictureBox6.Location = new System.Drawing.Point(744, 277);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 47);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "ГРАФИК (Новикова Наталия ИТ-32БО)";
            // 
            // maxNtext
            // 
            this.maxNtext.AutoSize = true;
            this.maxNtext.Location = new System.Drawing.Point(593, 423);
            this.maxNtext.Name = "maxNtext";
            this.maxNtext.Size = new System.Drawing.Size(35, 13);
            this.maxNtext.TabIndex = 45;
            this.maxNtext.Text = "n max";
            // 
            // maxN
            // 
            this.maxN.Location = new System.Drawing.Point(634, 423);
            this.maxN.Name = "maxN";
            this.maxN.Size = new System.Drawing.Size(100, 20);
            this.maxN.TabIndex = 46;
            this.maxN.Text = "0";
            // 
            // numeric_a
            // 
            this.numeric_a.DecimalPlaces = 3;
            this.numeric_a.Location = new System.Drawing.Point(744, 111);
            this.numeric_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_a.Name = "numeric_a";
            this.numeric_a.Size = new System.Drawing.Size(60, 20);
            this.numeric_a.TabIndex = 47;
            // 
            // numeric_b
            // 
            this.numeric_b.Location = new System.Drawing.Point(744, 161);
            this.numeric_b.Name = "numeric_b";
            this.numeric_b.Size = new System.Drawing.Size(60, 20);
            this.numeric_b.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(724, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "a";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(725, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "b";
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.Location = new System.Drawing.Point(70, 40);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(47, 17);
            this.rad_A.TabIndex = 51;
            this.rad_A.TabStop = true;
            this.rad_A.Text = "fixed";
            this.rad_A.UseVisualStyleBackColor = true;
            this.rad_A.CheckedChanged += new System.EventHandler(this.rad_A_CheckedChanged);
            // 
            // rad_G
            // 
            this.rad_G.AutoSize = true;
            this.rad_G.Location = new System.Drawing.Point(70, 95);
            this.rad_G.Name = "rad_G";
            this.rad_G.Size = new System.Drawing.Size(47, 17);
            this.rad_G.TabIndex = 52;
            this.rad_G.TabStop = true;
            this.rad_G.Text = "fixed";
            this.rad_G.UseVisualStyleBackColor = true;
            this.rad_G.CheckedChanged += new System.EventHandler(this.rad_G_CheckedChanged);
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.Location = new System.Drawing.Point(70, 146);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(47, 17);
            this.rad_D.TabIndex = 53;
            this.rad_D.TabStop = true;
            this.rad_D.Text = "fixed";
            this.rad_D.UseVisualStyleBackColor = true;
            this.rad_D.CheckedChanged += new System.EventHandler(this.rad_D_CheckedChanged);
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.Location = new System.Drawing.Point(70, 199);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(47, 17);
            this.rad_B.TabIndex = 54;
            this.rad_B.TabStop = true;
            this.rad_B.Text = "fixed";
            this.rad_B.UseVisualStyleBackColor = true;
            this.rad_B.CheckedChanged += new System.EventHandler(this.rad_B_CheckedChanged);
            // 
            // rad_E
            // 
            this.rad_E.AutoSize = true;
            this.rad_E.Location = new System.Drawing.Point(70, 253);
            this.rad_E.Name = "rad_E";
            this.rad_E.Size = new System.Drawing.Size(47, 17);
            this.rad_E.TabIndex = 55;
            this.rad_E.TabStop = true;
            this.rad_E.Text = "fixed";
            this.rad_E.UseVisualStyleBackColor = true;
            this.rad_E.CheckedChanged += new System.EventHandler(this.rad_E_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rad_E);
            this.groupBox1.Controls.Add(this.par_A);
            this.groupBox1.Controls.Add(this.rad_B);
            this.groupBox1.Controls.Add(this.par_B);
            this.groupBox1.Controls.Add(this.rad_D);
            this.groupBox1.Controls.Add(this.par_G);
            this.groupBox1.Controls.Add(this.rad_G);
            this.groupBox1.Controls.Add(this.par_D);
            this.groupBox1.Controls.Add(this.rad_A);
            this.groupBox1.Controls.Add(this.par_E);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Location = new System.Drawing.Point(595, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 280);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numeric_b);
            this.Controls.Add(this.numeric_a);
            this.Controls.Add(this.maxN);
            this.Controls.Add(this.maxNtext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.button_UP);
            this.Controls.Add(this.radio_00001);
            this.Controls.Add(this.radio_0001);
            this.Controls.Add(this.radio_001);
            this.Controls.Add(this.radio_01);
            this.Controls.Add(this.radio_1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.windowD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.windowC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.windowB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.windowA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.windowA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_b)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown windowA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown windowB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown windowC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown windowD;
        private System.Windows.Forms.NumericUpDown par_A;
        private System.Windows.Forms.NumericUpDown par_B;
        private System.Windows.Forms.NumericUpDown par_G;
        private System.Windows.Forms.NumericUpDown par_D;
        private System.Windows.Forms.NumericUpDown par_E;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_01;
        private System.Windows.Forms.RadioButton radio_001;
        private System.Windows.Forms.RadioButton radio_0001;
        private System.Windows.Forms.RadioButton radio_00001;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_UP;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label maxNtext;
        private System.Windows.Forms.TextBox maxN;
        private System.Windows.Forms.NumericUpDown numeric_a;
        private System.Windows.Forms.NumericUpDown numeric_b;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_G;
        private System.Windows.Forms.RadioButton rad_D;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_E;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


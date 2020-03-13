namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric_b = new System.Windows.Forms.NumericUpDown();
            this.numeric_a = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Par_D = new System.Windows.Forms.NumericUpDown();
            this.Par_C = new System.Windows.Forms.NumericUpDown();
            this.Par_B = new System.Windows.Forms.NumericUpDown();
            this.Par_A = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Eps = new System.Windows.Forms.RadioButton();
            this.numericEpsylon = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton_Bet = new System.Windows.Forms.RadioButton();
            this.radioButton_Gamma = new System.Windows.Forms.RadioButton();
            this.radioButton_Alph = new System.Windows.Forms.RadioButton();
            this.numericBeta = new System.Windows.Forms.NumericUpDown();
            this.numericGamma = new System.Windows.Forms.NumericUpDown();
            this.numericAlpha = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_points = new System.Windows.Forms.NumericUpDown();
            this.Build_up = new System.Windows.Forms.Button();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsylon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlpha)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_points)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numeric_b);
            this.groupBox1.Controls.Add(this.numeric_a);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Par_D);
            this.groupBox1.Controls.Add(this.Par_C);
            this.groupBox1.Controls.Add(this.Par_B);
            this.groupBox1.Controls.Add(this.Par_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры окна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "b";
            // 
            // numeric_b
            // 
            this.numeric_b.DecimalPlaces = 3;
            this.numeric_b.Location = new System.Drawing.Point(199, 97);
            this.numeric_b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_b.Name = "numeric_b";
            this.numeric_b.Size = new System.Drawing.Size(80, 20);
            this.numeric_b.TabIndex = 15;
            // 
            // numeric_a
            // 
            this.numeric_a.DecimalPlaces = 3;
            this.numeric_a.Location = new System.Drawing.Point(36, 98);
            this.numeric_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_a.Name = "numeric_a";
            this.numeric_a.Size = new System.Drawing.Size(80, 20);
            this.numeric_a.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "a";
            // 
            // Par_D
            // 
            this.Par_D.DecimalPlaces = 3;
            this.Par_D.Location = new System.Drawing.Point(199, 61);
            this.Par_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_D.Name = "Par_D";
            this.Par_D.Size = new System.Drawing.Size(80, 20);
            this.Par_D.TabIndex = 12;
            this.Par_D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Par_C
            // 
            this.Par_C.DecimalPlaces = 3;
            this.Par_C.Location = new System.Drawing.Point(199, 21);
            this.Par_C.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_C.Name = "Par_C";
            this.Par_C.Size = new System.Drawing.Size(80, 20);
            this.Par_C.TabIndex = 11;
            this.Par_C.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // Par_B
            // 
            this.Par_B.DecimalPlaces = 3;
            this.Par_B.Location = new System.Drawing.Point(36, 61);
            this.Par_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_B.Name = "Par_B";
            this.Par_B.Size = new System.Drawing.Size(80, 20);
            this.Par_B.TabIndex = 10;
            this.Par_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Par_A
            // 
            this.Par_A.DecimalPlaces = 3;
            this.Par_A.Location = new System.Drawing.Point(36, 21);
            this.Par_A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_A.Name = "Par_A";
            this.Par_A.Size = new System.Drawing.Size(80, 20);
            this.Par_A.TabIndex = 9;
            this.Par_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(137, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Х";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "А";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.radioButton_Eps);
            this.groupBox2.Controls.Add(this.numericEpsylon);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.radioButton_Bet);
            this.groupBox2.Controls.Add(this.radioButton_Gamma);
            this.groupBox2.Controls.Add(this.radioButton_Alph);
            this.groupBox2.Controls.Add(this.numericBeta);
            this.groupBox2.Controls.Add(this.numericGamma);
            this.groupBox2.Controls.Add(this.numericAlpha);
            this.groupBox2.Location = new System.Drawing.Point(6, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры функции";
            // 
            // radioButton_Eps
            // 
            this.radioButton_Eps.AutoSize = true;
            this.radioButton_Eps.Location = new System.Drawing.Point(199, 152);
            this.radioButton_Eps.Name = "radioButton_Eps";
            this.radioButton_Eps.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Eps.TabIndex = 17;
            this.radioButton_Eps.TabStop = true;
            this.radioButton_Eps.Text = "no fixed";
            this.radioButton_Eps.UseVisualStyleBackColor = true;
            this.radioButton_Eps.CheckedChanged += new System.EventHandler(this.radioButton_Eps_CheckedChanged);
            // 
            // numericEpsylon
            // 
            this.numericEpsylon.DecimalPlaces = 3;
            this.numericEpsylon.Location = new System.Drawing.Point(102, 150);
            this.numericEpsylon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericEpsylon.Name = "numericEpsylon";
            this.numericEpsylon.Size = new System.Drawing.Size(80, 20);
            this.numericEpsylon.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Эпсилон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Бетта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Гамма";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Альфа";
            // 
            // radioButton_Bet
            // 
            this.radioButton_Bet.AutoSize = true;
            this.radioButton_Bet.Location = new System.Drawing.Point(199, 114);
            this.radioButton_Bet.Name = "radioButton_Bet";
            this.radioButton_Bet.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Bet.TabIndex = 11;
            this.radioButton_Bet.TabStop = true;
            this.radioButton_Bet.Text = "no fixed";
            this.radioButton_Bet.UseVisualStyleBackColor = true;
            this.radioButton_Bet.CheckedChanged += new System.EventHandler(this.Param_Bet_CheckedChanged);
            // 
            // radioButton_Gamma
            // 
            this.radioButton_Gamma.AutoSize = true;
            this.radioButton_Gamma.Location = new System.Drawing.Point(199, 72);
            this.radioButton_Gamma.Name = "radioButton_Gamma";
            this.radioButton_Gamma.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Gamma.TabIndex = 10;
            this.radioButton_Gamma.TabStop = true;
            this.radioButton_Gamma.Text = "no fixed";
            this.radioButton_Gamma.UseVisualStyleBackColor = true;
            this.radioButton_Gamma.CheckedChanged += new System.EventHandler(this.Param_Gamma_CheckedChanged);
            // 
            // radioButton_Alph
            // 
            this.radioButton_Alph.AutoSize = true;
            this.radioButton_Alph.Location = new System.Drawing.Point(199, 27);
            this.radioButton_Alph.Name = "radioButton_Alph";
            this.radioButton_Alph.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Alph.TabIndex = 9;
            this.radioButton_Alph.TabStop = true;
            this.radioButton_Alph.Text = "no fixed";
            this.radioButton_Alph.UseVisualStyleBackColor = true;
            this.radioButton_Alph.CheckedChanged += new System.EventHandler(this.Param_Alph_CheckedChanged);
            // 
            // numericBeta
            // 
            this.numericBeta.DecimalPlaces = 3;
            this.numericBeta.Location = new System.Drawing.Point(102, 111);
            this.numericBeta.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericBeta.Name = "numericBeta";
            this.numericBeta.Size = new System.Drawing.Size(80, 20);
            this.numericBeta.TabIndex = 8;
            // 
            // numericGamma
            // 
            this.numericGamma.DecimalPlaces = 3;
            this.numericGamma.Location = new System.Drawing.Point(102, 69);
            this.numericGamma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericGamma.Name = "numericGamma";
            this.numericGamma.Size = new System.Drawing.Size(80, 20);
            this.numericGamma.TabIndex = 7;
            // 
            // numericAlpha
            // 
            this.numericAlpha.DecimalPlaces = 3;
            this.numericAlpha.Location = new System.Drawing.Point(102, 27);
            this.numericAlpha.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericAlpha.Name = "numericAlpha";
            this.numericAlpha.Size = new System.Drawing.Size(80, 20);
            this.numericAlpha.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.nMax);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numeric_points);
            this.groupBox3.Location = new System.Drawing.Point(6, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прочие параметры";
            // 
            // nMax
            // 
            this.nMax.Location = new System.Drawing.Point(187, 69);
            this.nMax.Multiline = true;
            this.nMax.Name = "nMax";
            this.nMax.ReadOnly = true;
            this.nMax.Size = new System.Drawing.Size(90, 20);
            this.nMax.TabIndex = 8;
            this.nMax.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Значение n_max";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(227, 112);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(58, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "0,0001";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(169, 112);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "0,001";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(120, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "0,01";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(74, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0,1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Resource1.Delta;
            this.pictureBox4.Location = new System.Drawing.Point(4, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Число разбиений n";
            // 
            // numeric_points
            // 
            this.numeric_points.Location = new System.Drawing.Point(187, 40);
            this.numeric_points.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_points.Name = "numeric_points";
            this.numeric_points.Size = new System.Drawing.Size(90, 20);
            this.numeric_points.TabIndex = 0;
            this.numeric_points.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Build_up
            // 
            this.Build_up.Location = new System.Drawing.Point(19, 551);
            this.Build_up.Name = "Build_up";
            this.Build_up.Size = new System.Drawing.Size(110, 35);
            this.Build_up.TabIndex = 4;
            this.Build_up.Text = "Построить";
            this.Build_up.UseVisualStyleBackColor = true;
            this.Build_up.Click += new System.EventHandler(this.Build_up_Click);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.SystemColors.Control;
            this.Graph.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Graph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graph.IsEnableHZoom = false;
            this.Graph.IsEnableVZoom = false;
            this.Graph.Location = new System.Drawing.Point(305, 10);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(677, 564);
            this.Graph.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(157, 551);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 35);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить всё";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Build_up);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 650);
            this.MinimumSize = new System.Drawing.Size(1010, 650);
            this.Name = "Form1";
            this.Text = "Бритнев Андрей, ИВТ-42 БО";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsylon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlpha)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_points)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_points;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Build_up;
        private System.Windows.Forms.Button Clear;
        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.NumericUpDown Par_D;
        private System.Windows.Forms.NumericUpDown Par_C;
        private System.Windows.Forms.NumericUpDown Par_B;
        private System.Windows.Forms.NumericUpDown Par_A;
        private System.Windows.Forms.NumericUpDown numericBeta;
        private System.Windows.Forms.NumericUpDown numericGamma;
        private System.Windows.Forms.NumericUpDown numericAlpha;
        private System.Windows.Forms.RadioButton radioButton_Bet;
        private System.Windows.Forms.RadioButton radioButton_Gamma;
        private System.Windows.Forms.RadioButton radioButton_Alph;
        private System.Windows.Forms.NumericUpDown numeric_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numeric_b;
        private System.Windows.Forms.TextBox nMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_Eps;
        private System.Windows.Forms.NumericUpDown numericEpsylon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}


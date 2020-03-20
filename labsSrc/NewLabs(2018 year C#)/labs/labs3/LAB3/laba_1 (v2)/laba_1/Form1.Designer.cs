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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windowA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.windowB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.windowC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.windowD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_01 = new System.Windows.Forms.RadioButton();
            this.radio_001 = new System.Windows.Forms.RadioButton();
            this.radio_0001 = new System.Windows.Forms.RadioButton();
            this.radio_00001 = new System.Windows.Forms.RadioButton();
            this.button_Clean = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.par_D = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.par_F = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.par_A = new System.Windows.Forms.NumericUpDown();
            this.par_B = new System.Windows.Forms.NumericUpDown();
            this.par_G = new System.Windows.Forms.NumericUpDown();
            this.par_P = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.windowA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_P)).BeginInit();
            this.SuspendLayout();
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
            this.windowA.ValueChanged += new System.EventHandler(this.par_ValueChanged);
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
            this.windowB.ValueChanged += new System.EventHandler(this.par_ValueChanged);
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
            this.windowC.ValueChanged += new System.EventHandler(this.par_ValueChanged);
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
            this.windowD.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Число шагов n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "n";
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(632, 285);
            this.numN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(97, 20);
            this.numN.TabIndex = 20;
            this.numN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numN.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Location = new System.Drawing.Point(795, 330);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(31, 17);
            this.radio_1.TabIndex = 23;
            this.radio_1.TabStop = true;
            this.radio_1.Text = "1";
            this.radio_1.UseVisualStyleBackColor = true;
            this.radio_1.CheckedChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // radio_01
            // 
            this.radio_01.AutoSize = true;
            this.radio_01.Location = new System.Drawing.Point(795, 353);
            this.radio_01.Name = "radio_01";
            this.radio_01.Size = new System.Drawing.Size(40, 17);
            this.radio_01.TabIndex = 24;
            this.radio_01.TabStop = true;
            this.radio_01.Text = "0,1";
            this.radio_01.UseVisualStyleBackColor = true;
            this.radio_01.CheckedChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // radio_001
            // 
            this.radio_001.AutoSize = true;
            this.radio_001.Location = new System.Drawing.Point(795, 376);
            this.radio_001.Name = "radio_001";
            this.radio_001.Size = new System.Drawing.Size(46, 17);
            this.radio_001.TabIndex = 25;
            this.radio_001.TabStop = true;
            this.radio_001.Text = "0,01";
            this.radio_001.UseVisualStyleBackColor = true;
            this.radio_001.CheckedChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // radio_0001
            // 
            this.radio_0001.AutoSize = true;
            this.radio_0001.Location = new System.Drawing.Point(795, 399);
            this.radio_0001.Name = "radio_0001";
            this.radio_0001.Size = new System.Drawing.Size(52, 17);
            this.radio_0001.TabIndex = 26;
            this.radio_0001.TabStop = true;
            this.radio_0001.Text = "0,001";
            this.radio_0001.UseVisualStyleBackColor = true;
            this.radio_0001.CheckedChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // radio_00001
            // 
            this.radio_00001.AutoSize = true;
            this.radio_00001.Location = new System.Drawing.Point(795, 422);
            this.radio_00001.Name = "radio_00001";
            this.radio_00001.Size = new System.Drawing.Size(58, 17);
            this.radio_00001.TabIndex = 27;
            this.radio_00001.TabStop = true;
            this.radio_00001.Text = "0,0001";
            this.radio_00001.UseVisualStyleBackColor = true;
            this.radio_00001.CheckedChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(632, 416);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(96, 23);
            this.button_Clean.TabIndex = 37;
            this.button_Clean.Text = "Очистить";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Параметры";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::laba_1.Properties.Resources.tau;
            this.pictureBox1.Location = new System.Drawing.Point(795, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 30);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = global::laba_1.Properties.Resources.scoba;
            this.pictureBox7.Location = new System.Drawing.Point(592, 124);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 118);
            this.pictureBox7.TabIndex = 57;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(819, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "y +";
            // 
            // par_D
            // 
            this.par_D.DecimalPlaces = 3;
            this.par_D.Location = new System.Drawing.Point(778, 194);
            this.par_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_D.Name = "par_D";
            this.par_D.Size = new System.Drawing.Size(40, 20);
            this.par_D.TabIndex = 103;
            this.par_D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_D.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(883, 198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 102;
            this.label20.Text = "x  ))";
            // 
            // par_F
            // 
            this.par_F.DecimalPlaces = 3;
            this.par_F.Location = new System.Drawing.Point(841, 194);
            this.par_F.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_F.Name = "par_F";
            this.par_F.Size = new System.Drawing.Size(40, 20);
            this.par_F.TabIndex = 101;
            this.par_F.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_F.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(748, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = ")  *  (";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(687, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 99;
            this.label17.Text = "x -";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "((";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(772, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = ")";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "x * y +";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "(";
            // 
            // par_A
            // 
            this.par_A.DecimalPlaces = 3;
            this.par_A.Location = new System.Drawing.Point(647, 153);
            this.par_A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_A.Name = "par_A";
            this.par_A.Size = new System.Drawing.Size(40, 20);
            this.par_A.TabIndex = 90;
            this.par_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_A.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // par_B
            // 
            this.par_B.DecimalPlaces = 3;
            this.par_B.Location = new System.Drawing.Point(645, 194);
            this.par_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_B.Name = "par_B";
            this.par_B.Size = new System.Drawing.Size(40, 20);
            this.par_B.TabIndex = 91;
            this.par_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_B.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // par_G
            // 
            this.par_G.DecimalPlaces = 3;
            this.par_G.Location = new System.Drawing.Point(706, 194);
            this.par_G.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_G.Name = "par_G";
            this.par_G.Size = new System.Drawing.Size(40, 20);
            this.par_G.TabIndex = 92;
            this.par_G.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_G.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // par_P
            // 
            this.par_P.DecimalPlaces = 3;
            this.par_P.Location = new System.Drawing.Point(729, 153);
            this.par_P.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_P.Name = "par_P";
            this.par_P.Size = new System.Drawing.Size(40, 20);
            this.par_P.TabIndex = 93;
            this.par_P.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.par_P.ValueChanged += new System.EventHandler(this.par_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(24, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 16);
            this.label14.TabIndex = 106;
            this.label14.Text = "Выполнил: Мехтиханов Леонид (ИТ-32)";
            // 
            // zedGraph
            // 
            this.zedGraph.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.zedGraph.ForeColor = System.Drawing.Color.White;
            this.zedGraph.IsEnableHZoom = false;
            this.zedGraph.IsEnableVZoom = false;
            this.zedGraph.Location = new System.Drawing.Point(12, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(570, 488);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Graph_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 493);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.par_D);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.par_F);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.par_A);
            this.Controls.Add(this.par_B);
            this.Controls.Add(this.par_G);
            this.Controls.Add(this.par_P);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.radio_00001);
            this.Controls.Add(this.radio_0001);
            this.Controls.Add(this.radio_001);
            this.Controls.Add(this.radio_01);
            this.Controls.Add(this.radio_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_P)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_01;
        private System.Windows.Forms.RadioButton radio_001;
        private System.Windows.Forms.RadioButton radio_0001;
        private System.Windows.Forms.RadioButton radio_00001;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown par_D;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown par_F;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown par_A;
        private System.Windows.Forms.NumericUpDown par_B;
        private System.Windows.Forms.NumericUpDown par_G;
        private System.Windows.Forms.NumericUpDown par_P;
        private System.Windows.Forms.Label label14;
    }
}


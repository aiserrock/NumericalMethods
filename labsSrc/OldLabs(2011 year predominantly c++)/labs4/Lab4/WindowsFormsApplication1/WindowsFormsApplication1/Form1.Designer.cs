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
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxPsi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_points)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Par_D);
            this.groupBox1.Controls.Add(this.Par_C);
            this.groupBox1.Controls.Add(this.Par_B);
            this.groupBox1.Controls.Add(this.Par_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(687, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры окна";
            // 
            // Par_D
            // 
            this.Par_D.DecimalPlaces = 3;
            this.Par_D.Location = new System.Drawing.Point(211, 67);
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
            this.Par_C.Location = new System.Drawing.Point(211, 27);
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
            this.Par_B.Location = new System.Drawing.Point(48, 67);
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
            this.Par_A.Location = new System.Drawing.Point(48, 27);
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
            this.label5.Location = new System.Drawing.Point(149, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Х";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "А";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBoxPsi);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.textBoxEpsilon);
            this.groupBox2.Controls.Add(this.textBoxDelta);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxFi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxBeta);
            this.groupBox2.Controls.Add(this.textBoxAlpha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(687, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры функции";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(107, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "+";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(179, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "+";
            // 
            // textBoxPsi
            // 
            this.textBoxPsi.Location = new System.Drawing.Point(192, 104);
            this.textBoxPsi.Name = "textBoxPsi";
            this.textBoxPsi.Size = new System.Drawing.Size(37, 20);
            this.textBoxPsi.TabIndex = 25;
            this.textBoxPsi.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(156, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 17);
            this.label23.TabIndex = 23;
            this.label23.Text = "y";
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(119, 102);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(37, 20);
            this.textBoxEpsilon.TabIndex = 22;
            this.textBoxEpsilon.Text = "1";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(48, 102);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(37, 20);
            this.textBoxDelta.TabIndex = 20;
            this.textBoxDelta.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(33, 103);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 17);
            this.label24.TabIndex = 19;
            this.label24.Text = "=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(87, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 17);
            this.label25.TabIndex = 21;
            this.label25.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "+";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(201, 54);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(37, 20);
            this.textBoxFi.TabIndex = 10;
            this.textBoxFi.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(158, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "x";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(119, 54);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(37, 20);
            this.textBoxBeta.TabIndex = 7;
            this.textBoxBeta.Text = "1";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(48, 54);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(37, 20);
            this.textBoxAlpha.TabIndex = 5;
            this.textBoxAlpha.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "ẏ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "=";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "ẋ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Resource1.bkt;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(87, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "y";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numeric_points);
            this.groupBox3.Location = new System.Drawing.Point(687, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прочие параметры";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(235, 89);
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
            this.radioButton4.Location = new System.Drawing.Point(177, 89);
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
            this.radioButton3.Location = new System.Drawing.Point(125, 89);
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
            this.radioButton2.Location = new System.Drawing.Point(79, 89);
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
            this.radioButton1.Location = new System.Drawing.Point(48, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Resource1.tau;
            this.pictureBox4.Location = new System.Drawing.Point(12, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Число шагов n";
            // 
            // numeric_points
            // 
            this.numeric_points.Location = new System.Drawing.Point(195, 36);
            this.numeric_points.Maximum = new decimal(new int[] {
            10000,
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
            this.Build_up.Location = new System.Drawing.Point(705, 509);
            this.Build_up.Name = "Build_up";
            this.Build_up.Size = new System.Drawing.Size(110, 35);
            this.Build_up.TabIndex = 4;
            this.Build_up.Text = "Применить";
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
            this.Graph.Location = new System.Drawing.Point(12, 12);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(660, 532);
            this.Graph.TabIndex = 5;
            this.Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Graph_MouseClick);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(869, 509);
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
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Build_up);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 610);
            this.MinimumSize = new System.Drawing.Size(1020, 610);
            this.Name = "Form1";
            this.Text = "Томчук Анна ИВТ-41 БО";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxPsi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}


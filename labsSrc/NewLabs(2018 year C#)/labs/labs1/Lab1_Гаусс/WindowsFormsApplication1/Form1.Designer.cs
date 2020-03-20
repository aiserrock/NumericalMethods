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
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Beta1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Epsilon1 = new System.Windows.Forms.NumericUpDown();
            this.Gamma1 = new System.Windows.Forms.NumericUpDown();
            this.Alpha1 = new System.Windows.Forms.NumericUpDown();
            this.interpolation_points = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dPn_x = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.df_x = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Rn_x = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pn_x = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.f_x = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Build_up = new System.Windows.Forms.Button();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.Clear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Beta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epsilon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alpha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolation_points)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.Par_D);
            this.groupBox1.Controls.Add(this.Par_C);
            this.groupBox1.Controls.Add(this.Par_B);
            this.groupBox1.Controls.Add(this.Par_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(696, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры окна";
            // 
            // Par_D
            // 
            this.Par_D.DecimalPlaces = 3;
            this.Par_D.Location = new System.Drawing.Point(199, 57);
            this.Par_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_D.Name = "Par_D";
            this.Par_D.Size = new System.Drawing.Size(80, 20);
            this.Par_D.TabIndex = 12;
            this.Par_D.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Par_C
            // 
            this.Par_C.DecimalPlaces = 3;
            this.Par_C.Location = new System.Drawing.Point(199, 22);
            this.Par_C.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_C.Name = "Par_C";
            this.Par_C.Size = new System.Drawing.Size(80, 20);
            this.Par_C.TabIndex = 11;
            this.Par_C.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // Par_B
            // 
            this.Par_B.DecimalPlaces = 3;
            this.Par_B.Location = new System.Drawing.Point(36, 57);
            this.Par_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_B.Name = "Par_B";
            this.Par_B.Size = new System.Drawing.Size(80, 20);
            this.Par_B.TabIndex = 10;
            this.Par_B.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Par_A
            // 
            this.Par_A.DecimalPlaces = 3;
            this.Par_A.Location = new System.Drawing.Point(36, 22);
            this.Par_A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_A.Name = "Par_A";
            this.Par_A.Size = new System.Drawing.Size(80, 20);
            this.Par_A.TabIndex = 9;
            this.Par_A.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(137, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(10, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(173, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(171, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Beta1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Epsilon1);
            this.groupBox2.Controls.Add(this.Gamma1);
            this.groupBox2.Controls.Add(this.Alpha1);
            this.groupBox2.Location = new System.Drawing.Point(696, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры функции";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(171, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 29);
            this.label18.TabIndex = 7;
            this.label18.Text = "ε";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(172, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 29);
            this.label17.TabIndex = 7;
            this.label17.Text = "γ";
            // 
            // Beta1
            // 
            this.Beta1.DecimalPlaces = 3;
            this.Beta1.Location = new System.Drawing.Point(36, 60);
            this.Beta1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Beta1.Name = "Beta1";
            this.Beta1.Size = new System.Drawing.Size(80, 20);
            this.Beta1.TabIndex = 8;
            this.Beta1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(8, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "β";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "α";
            // 
            // Epsilon1
            // 
            this.Epsilon1.DecimalPlaces = 3;
            this.Epsilon1.Location = new System.Drawing.Point(199, 65);
            this.Epsilon1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Epsilon1.Name = "Epsilon1";
            this.Epsilon1.Size = new System.Drawing.Size(80, 20);
            this.Epsilon1.TabIndex = 7;
            this.Epsilon1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Gamma1
            // 
            this.Gamma1.DecimalPlaces = 3;
            this.Gamma1.Location = new System.Drawing.Point(199, 25);
            this.Gamma1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Gamma1.Name = "Gamma1";
            this.Gamma1.Size = new System.Drawing.Size(80, 20);
            this.Gamma1.TabIndex = 7;
            this.Gamma1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Alpha1
            // 
            this.Alpha1.DecimalPlaces = 3;
            this.Alpha1.Location = new System.Drawing.Point(36, 25);
            this.Alpha1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Alpha1.Name = "Alpha1";
            this.Alpha1.Size = new System.Drawing.Size(80, 20);
            this.Alpha1.TabIndex = 6;
            this.Alpha1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // interpolation_points
            // 
            this.interpolation_points.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.interpolation_points.Location = new System.Drawing.Point(42, 19);
            this.interpolation_points.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.interpolation_points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interpolation_points.Name = "interpolation_points";
            this.interpolation_points.Size = new System.Drawing.Size(237, 20);
            this.interpolation_points.TabIndex = 0;
            this.interpolation_points.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(696, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Погрешность";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(227, 29);
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
            this.radioButton4.Location = new System.Drawing.Point(171, 29);
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
            this.radioButton3.Location = new System.Drawing.Point(121, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "0,01";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 29);
            this.label15.TabIndex = 7;
            this.label15.Text = "Δ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 29);
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
            this.radioButton1.Location = new System.Drawing.Point(42, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.dPn_x);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.df_x);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Rn_x);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.Pn_x);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.f_x);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(696, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список функций";
            // 
            // dPn_x
            // 
            this.dPn_x.AutoSize = true;
            this.dPn_x.Location = new System.Drawing.Point(247, 65);
            this.dPn_x.Name = "dPn_x";
            this.dPn_x.Size = new System.Drawing.Size(15, 14);
            this.dPn_x.TabIndex = 9;
            this.dPn_x.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(228, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "dPn(x)";
            // 
            // df_x
            // 
            this.df_x.AutoSize = true;
            this.df_x.Location = new System.Drawing.Point(188, 65);
            this.df_x.Name = "df_x";
            this.df_x.Size = new System.Drawing.Size(15, 14);
            this.df_x.TabIndex = 7;
            this.df_x.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "df(x)";
            // 
            // Rn_x
            // 
            this.Rn_x.AutoSize = true;
            this.Rn_x.Location = new System.Drawing.Point(129, 65);
            this.Rn_x.Name = "Rn_x";
            this.Rn_x.Size = new System.Drawing.Size(15, 14);
            this.Rn_x.TabIndex = 5;
            this.Rn_x.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Rn(x)";
            // 
            // Pn_x
            // 
            this.Pn_x.AutoSize = true;
            this.Pn_x.Location = new System.Drawing.Point(71, 65);
            this.Pn_x.Name = "Pn_x";
            this.Pn_x.Size = new System.Drawing.Size(15, 14);
            this.Pn_x.TabIndex = 3;
            this.Pn_x.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Pn(x)";
            // 
            // f_x
            // 
            this.f_x.AutoSize = true;
            this.f_x.Location = new System.Drawing.Point(15, 65);
            this.f_x.Name = "f_x";
            this.f_x.Size = new System.Drawing.Size(15, 14);
            this.f_x.TabIndex = 1;
            this.f_x.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "f(x)";
            // 
            // Build_up
            // 
            this.Build_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Build_up.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Build_up.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Build_up.Location = new System.Drawing.Point(723, 489);
            this.Build_up.Name = "Build_up";
            this.Build_up.Size = new System.Drawing.Size(110, 35);
            this.Build_up.TabIndex = 4;
            this.Build_up.Text = "Построить";
            this.Build_up.UseVisualStyleBackColor = true;
            this.Build_up.Click += new System.EventHandler(this.Build_up_Click);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Graph.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Graph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graph.IsEnableHZoom = false;
            this.Graph.IsEnableVZoom = false;
            this.Graph.Location = new System.Drawing.Point(9, 9);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(677, 550);
            this.Graph.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Clear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(851, 489);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 35);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(692, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Кучма Марина";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(10, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 29);
            this.label20.TabIndex = 7;
            this.label20.Text = "n";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.interpolation_points);
            this.groupBox5.Location = new System.Drawing.Point(696, 336);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 51);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Узлы интерполяции";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(692, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "ИВТ-31БО";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(994, 572);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Build_up);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 610);
            this.MinimumSize = new System.Drawing.Size(1010, 610);
            this.Name = "Form1";
            this.Text = "Интерполяция функций";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Beta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epsilon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alpha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolation_points)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown interpolation_points;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox dPn_x;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox df_x;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Rn_x;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Pn_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox f_x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Build_up;
        private System.Windows.Forms.Button Clear;
        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.NumericUpDown Par_D;
        private System.Windows.Forms.NumericUpDown Par_C;
        private System.Windows.Forms.NumericUpDown Par_B;
        private System.Windows.Forms.NumericUpDown Par_A;
        private System.Windows.Forms.NumericUpDown Beta1;
        private System.Windows.Forms.NumericUpDown Gamma1;
        private System.Windows.Forms.NumericUpDown Alpha1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Epsilon1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
    }
}


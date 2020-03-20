namespace WindowsFormsApplication1
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Par_Alf = new System.Windows.Forms.NumericUpDown();
            this.Par_Bet = new System.Windows.Forms.NumericUpDown();
            this.Par_Mu = new System.Windows.Forms.NumericUpDown();
            this.Par_Eps = new System.Windows.Forms.NumericUpDown();
            this.ParA = new System.Windows.Forms.NumericUpDown();
            this.ParB = new System.Windows.Forms.NumericUpDown();
            this.ParC = new System.Windows.Forms.NumericUpDown();
            this.ParD = new System.Windows.Forms.NumericUpDown();
            this.Par_n = new System.Windows.Forms.NumericUpDown();
            this.Par_m = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.Par_p = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Par_x0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Alf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Eps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_x0)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.LabelStyle.Format = "D";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.IntervalOffset = 1D;
            chartArea1.CursorY.IntervalOffset = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 10F;
            legend1.Position.Width = 25F;
            legend1.Position.X = 75F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(264, 9);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(100);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerSize = 2;
            series1.Name = "Series2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 2;
            series2.Name = "Series3";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(788, 501);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(63, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "α=";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "β=";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(144, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "ε=";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "γ=";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "A=";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(144, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "B=";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(4, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "C=";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(144, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "D=";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "n=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(2, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 60);
            this.label12.TabIndex = 33;
            this.label12.Text = "Выполнил:\r\nБритнев Андрей\r\nГруппа: ИВТ - 42БО";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "α",
            "β",
            "γ",
            "ε"});
            this.comboBox2.Location = new System.Drawing.Point(201, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(34, 28);
            this.comboBox2.TabIndex = 41;
            this.comboBox2.Text = "α";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(3, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 25);
            this.label16.TabIndex = 42;
            this.label16.Text = "Выделенный параметр:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(2, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(256, 25);
            this.label17.TabIndex = 43;
            this.label17.Text = "Функция: αcos(εx)*sin(tan(β/(x-γ)))";
            // 
            // Par_Alf
            // 
            this.Par_Alf.DecimalPlaces = 2;
            this.Par_Alf.Location = new System.Drawing.Point(40, 19);
            this.Par_Alf.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_Alf.Name = "Par_Alf";
            this.Par_Alf.Size = new System.Drawing.Size(63, 20);
            this.Par_Alf.TabIndex = 46;
            // 
            // Par_Bet
            // 
            this.Par_Bet.DecimalPlaces = 2;
            this.Par_Bet.Location = new System.Drawing.Point(182, 19);
            this.Par_Bet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_Bet.Name = "Par_Bet";
            this.Par_Bet.Size = new System.Drawing.Size(63, 20);
            this.Par_Bet.TabIndex = 47;
            // 
            // Par_Mu
            // 
            this.Par_Mu.DecimalPlaces = 2;
            this.Par_Mu.Location = new System.Drawing.Point(40, 53);
            this.Par_Mu.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_Mu.Name = "Par_Mu";
            this.Par_Mu.Size = new System.Drawing.Size(63, 20);
            this.Par_Mu.TabIndex = 49;
            // 
            // Par_Eps
            // 
            this.Par_Eps.DecimalPlaces = 2;
            this.Par_Eps.Location = new System.Drawing.Point(182, 53);
            this.Par_Eps.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_Eps.Name = "Par_Eps";
            this.Par_Eps.Size = new System.Drawing.Size(63, 20);
            this.Par_Eps.TabIndex = 50;
            // 
            // ParA
            // 
            this.ParA.DecimalPlaces = 2;
            this.ParA.Location = new System.Drawing.Point(51, 19);
            this.ParA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ParA.Name = "ParA";
            this.ParA.Size = new System.Drawing.Size(63, 20);
            this.ParA.TabIndex = 51;
            // 
            // ParB
            // 
            this.ParB.DecimalPlaces = 2;
            this.ParB.Location = new System.Drawing.Point(182, 19);
            this.ParB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ParB.Name = "ParB";
            this.ParB.Size = new System.Drawing.Size(63, 20);
            this.ParB.TabIndex = 52;
            // 
            // ParC
            // 
            this.ParC.DecimalPlaces = 2;
            this.ParC.Location = new System.Drawing.Point(51, 53);
            this.ParC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ParC.Name = "ParC";
            this.ParC.Size = new System.Drawing.Size(63, 20);
            this.ParC.TabIndex = 53;
            // 
            // ParD
            // 
            this.ParD.DecimalPlaces = 2;
            this.ParD.Location = new System.Drawing.Point(182, 53);
            this.ParD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ParD.Name = "ParD";
            this.ParD.Size = new System.Drawing.Size(63, 20);
            this.ParD.TabIndex = 54;
            // 
            // Par_n
            // 
            this.Par_n.Location = new System.Drawing.Point(57, 26);
            this.Par_n.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Par_n.Name = "Par_n";
            this.Par_n.Size = new System.Drawing.Size(63, 20);
            this.Par_n.TabIndex = 55;
            // 
            // Par_m
            // 
            this.Par_m.Location = new System.Drawing.Point(182, 24);
            this.Par_m.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Par_m.Name = "Par_m";
            this.Par_m.Size = new System.Drawing.Size(63, 20);
            this.Par_m.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(135, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 25);
            this.label18.TabIndex = 57;
            this.label18.Text = "m=";
            // 
            // Par_p
            // 
            this.Par_p.Location = new System.Drawing.Point(57, 64);
            this.Par_p.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Par_p.Name = "Par_p";
            this.Par_p.Size = new System.Drawing.Size(63, 20);
            this.Par_p.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(10, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 25);
            this.label19.TabIndex = 59;
            this.label19.Text = "p=";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(135, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "x0=";
            // 
            // Par_x0
            // 
            this.Par_x0.DecimalPlaces = 2;
            this.Par_x0.Location = new System.Drawing.Point(182, 62);
            this.Par_x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_x0.Name = "Par_x0";
            this.Par_x0.Size = new System.Drawing.Size(63, 20);
            this.Par_x0.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Par_Alf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Par_Bet);
            this.groupBox1.Controls.Add(this.Par_Mu);
            this.groupBox1.Controls.Add(this.Par_Eps);
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 84);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры функции";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ParB);
            this.groupBox2.Controls.Add(this.ParD);
            this.groupBox2.Controls.Add(this.ParC);
            this.groupBox2.Location = new System.Drawing.Point(6, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 83);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры окна";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Par_x0);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.Par_p);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Par_m);
            this.groupBox3.Controls.Add(this.Par_n);
            this.groupBox3.Location = new System.Drawing.Point(6, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 99);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прочие параметры";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Лабораторная №4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Alf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_Eps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_x0)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown Par_Alf;
        private System.Windows.Forms.NumericUpDown Par_Bet;
        private System.Windows.Forms.NumericUpDown Par_Mu;
        private System.Windows.Forms.NumericUpDown Par_Eps;
        private System.Windows.Forms.NumericUpDown ParA;
        private System.Windows.Forms.NumericUpDown ParB;
        private System.Windows.Forms.NumericUpDown ParC;
        private System.Windows.Forms.NumericUpDown ParD;
        private System.Windows.Forms.NumericUpDown Par_n;
        private System.Windows.Forms.NumericUpDown Par_m;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown Par_p;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Par_x0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


namespace Polynomial
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
            this.components = new System.ComponentModel.Container();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelEpsilon = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelDR = new System.Windows.Forms.Label();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.numericD = new System.Windows.Forms.NumericUpDown();
            this.numericAlfa = new System.Windows.Forms.NumericUpDown();
            this.numericSigma = new System.Windows.Forms.NumericUpDown();
            this.numericEpsilon = new System.Windows.Forms.NumericUpDown();
            this.numericN = new System.Windows.Forms.NumericUpDown();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.numericDR = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelFi = new System.Windows.Forms.Label();
            this.numericFi = new System.Windows.Forms.NumericUpDown();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.windowParametersBox = new System.Windows.Forms.GroupBox();
            this.functionParametersBox = new System.Windows.Forms.GroupBox();
            this.labelDelta = new System.Windows.Forms.Label();
            this.numericDelta = new System.Windows.Forms.NumericUpDown();
            this.otherParametersBox = new System.Windows.Forms.GroupBox();
            this.labelFirstEquation = new System.Windows.Forms.Label();
            this.labelSecondEquation = new System.Windows.Forms.Label();
            this.systemBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFi)).BeginInit();
            this.windowParametersBox.SuspendLayout();
            this.functionParametersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelta)).BeginInit();
            this.otherParametersBox.SuspendLayout();
            this.systemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 421);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(8, 16);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 17);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(111, 14);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 17);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(8, 46);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(17, 17);
            this.labelC.TabIndex = 8;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(111, 46);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(18, 17);
            this.labelD.TabIndex = 9;
            this.labelD.Text = "D";
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlpha.Location = new System.Drawing.Point(5, 19);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(16, 17);
            this.labelAlpha.TabIndex = 16;
            this.labelAlpha.Text = "α";
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSigma.Location = new System.Drawing.Point(5, 98);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(15, 17);
            this.labelSigma.TabIndex = 18;
            this.labelSigma.Text = "γ";
            // 
            // labelEpsilon
            // 
            this.labelEpsilon.AutoSize = true;
            this.labelEpsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEpsilon.Location = new System.Drawing.Point(6, 71);
            this.labelEpsilon.Name = "labelEpsilon";
            this.labelEpsilon.Size = new System.Drawing.Size(16, 17);
            this.labelEpsilon.TabIndex = 21;
            this.labelEpsilon.Text = "δ";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(111, 20);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(13, 13);
            this.labelN.TabIndex = 28;
            this.labelN.Text = "n";
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDR.Location = new System.Drawing.Point(4, 19);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(17, 17);
            this.labelDR.TabIndex = 30;
            this.labelDR.Text = "Δ";
            // 
            // numericA
            // 
            this.numericA.DecimalPlaces = 3;
            this.numericA.Location = new System.Drawing.Point(27, 16);
            this.numericA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(70, 20);
            this.numericA.TabIndex = 42;
            this.numericA.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericB
            // 
            this.numericB.DecimalPlaces = 3;
            this.numericB.Location = new System.Drawing.Point(130, 16);
            this.numericB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(72, 20);
            this.numericB.TabIndex = 43;
            this.numericB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericC
            // 
            this.numericC.DecimalPlaces = 3;
            this.numericC.Location = new System.Drawing.Point(27, 48);
            this.numericC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(70, 20);
            this.numericC.TabIndex = 44;
            this.numericC.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericD
            // 
            this.numericD.DecimalPlaces = 3;
            this.numericD.Location = new System.Drawing.Point(130, 48);
            this.numericD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericD.Name = "numericD";
            this.numericD.Size = new System.Drawing.Size(72, 20);
            this.numericD.TabIndex = 45;
            this.numericD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericAlfa
            // 
            this.numericAlfa.DecimalPlaces = 3;
            this.numericAlfa.Location = new System.Drawing.Point(27, 19);
            this.numericAlfa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericAlfa.Name = "numericAlfa";
            this.numericAlfa.Size = new System.Drawing.Size(70, 20);
            this.numericAlfa.TabIndex = 46;
            this.numericAlfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericSigma
            // 
            this.numericSigma.DecimalPlaces = 3;
            this.numericSigma.Location = new System.Drawing.Point(27, 98);
            this.numericSigma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericSigma.Name = "numericSigma";
            this.numericSigma.Size = new System.Drawing.Size(70, 20);
            this.numericSigma.TabIndex = 48;
            this.numericSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEpsilon
            // 
            this.numericEpsilon.DecimalPlaces = 3;
            this.numericEpsilon.Location = new System.Drawing.Point(27, 72);
            this.numericEpsilon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericEpsilon.Name = "numericEpsilon";
            this.numericEpsilon.Size = new System.Drawing.Size(70, 20);
            this.numericEpsilon.TabIndex = 49;
            this.numericEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericN
            // 
            this.numericN.Location = new System.Drawing.Point(130, 20);
            this.numericN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericN.Name = "numericN";
            this.numericN.Size = new System.Drawing.Size(72, 20);
            this.numericN.TabIndex = 50;
            this.numericN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.Location = new System.Drawing.Point(20, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(140, 40);
            this.labelAuthor.TabIndex = 51;
            this.labelAuthor.Text = "Бритнев Андрей \r\nИВТ-42БО";
            // 
            // numericDR
            // 
            this.numericDR.DecimalPlaces = 4;
            this.numericDR.Location = new System.Drawing.Point(27, 19);
            this.numericDR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDR.Name = "numericDR";
            this.numericDR.Size = new System.Drawing.Size(70, 20);
            this.numericDR.TabIndex = 52;
            this.numericDR.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelFi
            // 
            this.labelFi.AutoSize = true;
            this.labelFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFi.Location = new System.Drawing.Point(113, 19);
            this.labelFi.Name = "labelFi";
            this.labelFi.Size = new System.Drawing.Size(17, 17);
            this.labelFi.TabIndex = 65;
            this.labelFi.Text = "φ";
            // 
            // numericFi
            // 
            this.numericFi.DecimalPlaces = 3;
            this.numericFi.Location = new System.Drawing.Point(136, 19);
            this.numericFi.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericFi.Name = "numericFi";
            this.numericFi.Size = new System.Drawing.Size(70, 20);
            this.numericFi.TabIndex = 69;
            this.numericFi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // zedGraph
            // 
            this.zedGraph.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraph.Cursor = System.Windows.Forms.Cursors.Cross;
            this.zedGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zedGraph.IsAntiAlias = true;
            this.zedGraph.IsEnableHZoom = false;
            this.zedGraph.IsEnableVZoom = false;
            this.zedGraph.Location = new System.Drawing.Point(230, 7);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(472, 432);
            this.zedGraph.TabIndex = 71;
            this.zedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZedGraphMouseClick);
            // 
            // windowParametersBox
            // 
            this.windowParametersBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.windowParametersBox.Controls.Add(this.labelA);
            this.windowParametersBox.Controls.Add(this.numericA);
            this.windowParametersBox.Controls.Add(this.numericB);
            this.windowParametersBox.Controls.Add(this.labelB);
            this.windowParametersBox.Controls.Add(this.numericD);
            this.windowParametersBox.Controls.Add(this.labelC);
            this.windowParametersBox.Controls.Add(this.labelD);
            this.windowParametersBox.Controls.Add(this.numericC);
            this.windowParametersBox.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.windowParametersBox.Location = new System.Drawing.Point(12, 75);
            this.windowParametersBox.Name = "windowParametersBox";
            this.windowParametersBox.Size = new System.Drawing.Size(212, 76);
            this.windowParametersBox.TabIndex = 72;
            this.windowParametersBox.TabStop = false;
            this.windowParametersBox.Text = "Параметры окна";
            // 
            // functionParametersBox
            // 
            this.functionParametersBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.functionParametersBox.Controls.Add(this.labelDelta);
            this.functionParametersBox.Controls.Add(this.numericDelta);
            this.functionParametersBox.Controls.Add(this.numericAlfa);
            this.functionParametersBox.Controls.Add(this.labelAlpha);
            this.functionParametersBox.Controls.Add(this.numericFi);
            this.functionParametersBox.Controls.Add(this.numericEpsilon);
            this.functionParametersBox.Controls.Add(this.labelFi);
            this.functionParametersBox.Controls.Add(this.labelEpsilon);
            this.functionParametersBox.Controls.Add(this.numericSigma);
            this.functionParametersBox.Controls.Add(this.labelSigma);
            this.functionParametersBox.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.functionParametersBox.Location = new System.Drawing.Point(12, 157);
            this.functionParametersBox.Name = "functionParametersBox";
            this.functionParametersBox.Size = new System.Drawing.Size(212, 124);
            this.functionParametersBox.TabIndex = 73;
            this.functionParametersBox.TabStop = false;
            this.functionParametersBox.Text = "Параметры функций";
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelta.Location = new System.Drawing.Point(5, 46);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(16, 17);
            this.labelDelta.TabIndex = 48;
            this.labelDelta.Text = "β";
            // 
            // numericDelta
            // 
            this.numericDelta.DecimalPlaces = 3;
            this.numericDelta.Location = new System.Drawing.Point(27, 46);
            this.numericDelta.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericDelta.Name = "numericDelta";
            this.numericDelta.Size = new System.Drawing.Size(70, 20);
            this.numericDelta.TabIndex = 47;
            this.numericDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otherParametersBox
            // 
            this.otherParametersBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.otherParametersBox.Controls.Add(this.numericDR);
            this.otherParametersBox.Controls.Add(this.labelN);
            this.otherParametersBox.Controls.Add(this.labelDR);
            this.otherParametersBox.Controls.Add(this.numericN);
            this.otherParametersBox.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.otherParametersBox.Location = new System.Drawing.Point(12, 287);
            this.otherParametersBox.Name = "otherParametersBox";
            this.otherParametersBox.Size = new System.Drawing.Size(212, 49);
            this.otherParametersBox.TabIndex = 74;
            this.otherParametersBox.TabStop = false;
            this.otherParametersBox.Text = "Другие параметры";
            // 
            // labelFirstEquation
            // 
            this.labelFirstEquation.AutoSize = true;
            this.labelFirstEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstEquation.Location = new System.Drawing.Point(8, 18);
            this.labelFirstEquation.Name = "labelFirstEquation";
            this.labelFirstEquation.Size = new System.Drawing.Size(122, 20);
            this.labelFirstEquation.TabIndex = 75;
            this.labelFirstEquation.Text = "x = αx^2+βy^2+γ";
            // 
            // labelSecondEquation
            // 
            this.labelSecondEquation.AutoSize = true;
            this.labelSecondEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondEquation.Location = new System.Drawing.Point(7, 38);
            this.labelSecondEquation.Name = "labelSecondEquation";
            this.labelSecondEquation.Size = new System.Drawing.Size(67, 20);
            this.labelSecondEquation.TabIndex = 76;
            this.labelSecondEquation.Text = "y = δy+φ";
            // 
            // systemBox
            // 
            this.systemBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.systemBox.Controls.Add(this.labelSecondEquation);
            this.systemBox.Controls.Add(this.labelFirstEquation);
            this.systemBox.Location = new System.Drawing.Point(12, 347);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(212, 68);
            this.systemBox.TabIndex = 77;
            this.systemBox.TabStop = false;
            this.systemBox.Text = "Система";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(708, 451);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.systemBox);
            this.Controls.Add(this.otherParametersBox);
            this.Controls.Add(this.functionParametersBox);
            this.Controls.Add(this.windowParametersBox);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.buttonClear);
            this.Name = "MainWindow";
            this.Text = "Численное решение систем ОДУ";
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFi)).EndInit();
            this.windowParametersBox.ResumeLayout(false);
            this.windowParametersBox.PerformLayout();
            this.functionParametersBox.ResumeLayout(false);
            this.functionParametersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelta)).EndInit();
            this.otherParametersBox.ResumeLayout(false);
            this.otherParametersBox.PerformLayout();
            this.systemBox.ResumeLayout(false);
            this.systemBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelEpsilon;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.NumericUpDown numericD;
        private System.Windows.Forms.NumericUpDown numericAlfa;
        private System.Windows.Forms.NumericUpDown numericSigma;
        private System.Windows.Forms.NumericUpDown numericEpsilon;
        private System.Windows.Forms.NumericUpDown numericN;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.NumericUpDown numericDR;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelFi;
        private System.Windows.Forms.NumericUpDown numericFi;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox windowParametersBox;
        private System.Windows.Forms.GroupBox functionParametersBox;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.NumericUpDown numericDelta;
        private System.Windows.Forms.GroupBox otherParametersBox;
        private System.Windows.Forms.Label labelFirstEquation;
        private System.Windows.Forms.Label labelSecondEquation;
        private System.Windows.Forms.GroupBox systemBox;
    }
}


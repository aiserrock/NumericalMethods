namespace ODUSystems
{
    partial class MainForm
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
            this.clearButton = new System.Windows.Forms.Button();
            this.buildButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tauСomboBox = new System.Windows.Forms.ComboBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phiTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.etaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gamaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.betaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.graph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1010, 492);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 44);
            this.clearButton.TabIndex = 120;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(908, 492);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(86, 44);
            this.buildButton.TabIndex = 119;
            this.buildButton.Text = "Применить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 118;
            this.label17.Text = "τ:";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(44, 32);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(53, 20);
            this.nTextBox.TabIndex = 99;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 117;
            this.label16.Text = "N:";
            // 
            // tauСomboBox
            // 
            this.tauСomboBox.FormattingEnabled = true;
            this.tauСomboBox.Location = new System.Drawing.Point(25, 36);
            this.tauСomboBox.Name = "tauСomboBox";
            this.tauСomboBox.Size = new System.Drawing.Size(82, 21);
            this.tauСomboBox.TabIndex = 98;
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(116, 50);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(38, 20);
            this.dTextBox.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 114;
            this.label13.Text = "D:";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(48, 50);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(38, 20);
            this.cTextBox.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "C:";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(116, 21);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(38, 20);
            this.bTextBox.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "B:";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(48, 21);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(38, 20);
            this.aTextBox.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "A:";
            // 
            // phiTextBox
            // 
            this.phiTextBox.Location = new System.Drawing.Point(133, 48);
            this.phiTextBox.Name = "phiTextBox";
            this.phiTextBox.Size = new System.Drawing.Size(38, 20);
            this.phiTextBox.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "φ:";
            // 
            // etaTextBox
            // 
            this.etaTextBox.Location = new System.Drawing.Point(78, 48);
            this.etaTextBox.Name = "etaTextBox";
            this.etaTextBox.Size = new System.Drawing.Size(38, 20);
            this.etaTextBox.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "δ:";
            // 
            // gamaTextBox
            // 
            this.gamaTextBox.Location = new System.Drawing.Point(133, 19);
            this.gamaTextBox.Name = "gamaTextBox";
            this.gamaTextBox.Size = new System.Drawing.Size(38, 20);
            this.gamaTextBox.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "gama:";
            // 
            // betaTextBox
            // 
            this.betaTextBox.Location = new System.Drawing.Point(22, 44);
            this.betaTextBox.Name = "betaTextBox";
            this.betaTextBox.Size = new System.Drawing.Size(38, 20);
            this.betaTextBox.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "β:";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(22, 20);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(38, 20);
            this.alphaTextBox.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "α:";
            // 
            // graph
            // 
            this.graph.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(797, 524);
            this.graph.TabIndex = 121;
            this.graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graph_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.aTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.bTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(887, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 84);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры окна";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alphaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.betaTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gamaTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.etaTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.phiTextBox);
            this.groupBox2.Location = new System.Drawing.Point(887, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 83);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tauСomboBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(887, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 83);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шаг сетки:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nTextBox);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(887, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 84);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Число шагов:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ODUSystems.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(815, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 83);
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buildButton);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Численное решение систем ОДУ (Климычев М.Н, ИВТ-42БО)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox tauСomboBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phiTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox etaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gamaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox betaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Label label3;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


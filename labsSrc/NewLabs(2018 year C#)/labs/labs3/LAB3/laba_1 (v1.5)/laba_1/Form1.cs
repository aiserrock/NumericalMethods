using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace laba_1
{
    public partial class Form1 : Form
    {
        double A = -5, B = 5, C = -5, D = 5;
        double Alfa=1, Betta=1, Pi=1, Delta=1, Gamm=1, Fi=1;
        double y0, x0, y2, Tau, n = 500;

        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики

        Color[] _colors = new Color[] 
        {
            Color.Black, 
            Color.Blue, 
            Color.Green,
            Color.Indigo,
            Color.Orange,
            Color.Red,
            Color.YellowGreen,
            Color.Chocolate,
            Color.DarkCyan,
            Color.DarkViolet,
            Color.Gold,
            Color.Purple,
            Color.Gray
        };

        public Form1()
        {

            InitializeComponent();

            radio_001.Checked = true;
            // добавляем точку (0,0) для отображения осей в центре в этой точе
            list.Add(0, 0);

            // Создадим кривую
            LineItem krivaya = this.zedGraph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None);

            zedGraph.GraphPane.Title = " "; //Заголовок графика

            zedGraph.Invalidate(); // Обновляем график
            zedGraph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            pictureBox7.Image = Properties.Resources.scoba;
            pictureBox1.Image = Properties.Resources.tau;

            button_Clean_Click(this, null);
        }

        private void button_UP_Click(object sender, EventArgs e)
        {

            this.zedGraph.GraphPane.CurveList.Clear(); //очистка координатной плоскости
            //list.Clear();//очистка списка точек

            //ограничения
            A = Convert.ToDouble(this.windowA.Value);
            B = Convert.ToDouble(this.windowB.Value);
            C = Convert.ToDouble(this.windowC.Value);
            D = Convert.ToDouble(this.windowD.Value);

            n = (int)numN.Value;

            //проверка поля ограничений для функции
            if (A >= B || C >= D)
            {
                MessageBox.Show("Некоректно подобран интервал! Должно быть A < B, C < D.");
                A = -5;
                B = 5;
                C = -5;
                D = 5;
                this.windowA.Value = -5;
                this.windowB.Value = 5;
                this.windowC.Value = -5;
                this.windowD.Value = 5;
            }
            
            try
            {
                Alfa = Convert.ToDouble(par_A.Text);
                Betta = Convert.ToDouble(par_B.Text);
                Pi = Convert.ToDouble(par_P.Text);
                Fi = Convert.ToDouble(par_F.Text);
                Delta = Convert.ToDouble(par_D.Text);
                Gamm = Convert.ToDouble(par_G.Text);
                
            }
            catch
            {
                MessageBox.Show("Неверный ввод параметра(-ов)");
                return;
            }
            if (Alfa > 1000)
            {
                Alfa = 1000;
                par_A.Text = "1000";
            }
            if (Alfa < -1000)
            {
                Alfa = -1000;
                par_A.Text = "-1000";
            }
            if (Betta < -1000)
            {
                Betta = -1000;
                par_B.Text = "-1000";
            }
            if (Betta > 1000)
            {
                Betta = 1000;
                par_B.Text = "1000";
            }
            if (Pi > 1000)
            {
                Pi = 1000;
                par_P.Text = "1000";
            }
            if (Pi < -1000)
            {
                Pi = -1000;
                par_P.Text = "-1000";
            }
            if (Fi > 1000)
            {
                Fi = 1000;
                par_F.Text = "1000";
            }
            if (Fi < -1000)
            {
                Fi = -1000;
                par_F.Text = "-1000";
            }
            if (Delta > 1000)
            {
                Delta = 1000;
                par_D.Text = "1000";
            }
            if (Delta < -1000)
            {
                Delta = -1000;
                par_D.Text = "-1000";
            }

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = A;
            this.zedGraph.GraphPane.XAxis.Max = B;
            this.zedGraph.GraphPane.YAxis.Min = C;
            this.zedGraph.GraphPane.YAxis.Max = D;

            if (radio_1.Checked)
                Tau = 1.0;
            if (radio_01.Checked)
                Tau = 0.1;
            if (radio_001.Checked)
                Tau = 0.01;
            if (radio_0001.Checked)
                Tau = 0.001;
            if (radio_00001.Checked)
                Tau = 0.0001;

            //// Обновляем график
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            windowA.Value = -5;
            windowB.Value = 5;
            windowC.Value = -5;
            windowD.Value = 5;

            //par_A.Value = 1;
            //par_B.Value = 1;
            //par_D.Value = 1;
            //par_G.Value = 1;
            //par_P.Value = 1;
            //par_F.Value = 1;

            //radio_1.Checked = true;

            //numN.Value = 1;

            //очистка графиков
            this.zedGraph.GraphPane.CurveList.Clear();

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = -5;
            this.zedGraph.GraphPane.XAxis.Max = 5;
            this.zedGraph.GraphPane.YAxis.Min = -5;
            this.zedGraph.GraphPane.YAxis.Max = 5;

            //обновляем
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();
        }

        void method_of_EulerX()//рисует интегральную кривую и выводит n_max
        {
            PointPairList list1 = new PointPairList();

            double x = x0, y = y0, x1;

            list1.Add(x0, y0);

            for (int par = 0; par < n; par++)
            {
                x1 = x;
                x = x + Tau * (Alfa * x * y + Pi);
                y = y + Tau * ((Betta * x - Gamm) * (Delta * y + Fi * x));
                list1.Add(x, y);
            }

            PointPairList list2 = new PointPairList();

            list2.Add(x0, y0);

            x = x0; y = y0;

            for (int par = 0; par < n; par++)
            {
                x1 = x;
                x = x - Tau * (Alfa * x * y + Pi);
                y = y - Tau * ((Betta * x - Gamm) * (Delta * y + Fi * x));
                list2.Add(x, y);
            }

            Random rnd = new Random();

            Color curveColor = _colors[rnd.Next(_colors.Length)];

            zedGraph.GraphPane.AddCurve("", list1, curveColor, SymbolType.None); // Создадим кривую
            zedGraph.GraphPane.AddCurve("", list2, curveColor, SymbolType.None); // Создадим кривую

            zedGraph.AxisChange();

            zedGraph.Invalidate(); // Обновляем график
        }


        private void Graph_MouseClick(object sender, MouseEventArgs e)//считавание координат клика мышкой
        {
            // Пересчитываем пиксели в координаты на графике
            // У ZedGraph есть несколько перегруженных методов ReverseTransform.
            zedGraph.GraphPane.ReverseTransform(e.Location, out x0, out y0, out y2); 
            
            method_of_EulerX();
        } 

    }
}

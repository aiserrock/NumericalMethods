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
        double A = -10, B = 10, C = -10, D = 10;
        double Alfa = 1, Betta = 1, Pi = 1, Delta = 1, Gamm = 1, Fi = 1;
        double Tau, n = 50;

        struct Curve
        {
            public double x0, x2, y0, y2;
            public Color color;
        }
        List<Curve> curves = new List<Curve>();

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

            radio_1.Checked = true;
            // добавляем точку (0,0) для отображения осей в центре в этой точе
            list.Add(0, 0);

            // Создадим кривую
            LineItem krivaya = this.zedGraph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None);

            zedGraph.GraphPane.Title.Text = " "; //Заголовок графика

            zedGraph.GraphPane.XAxis.Cross = 0.0; // Ось X будет пересекаться с осью Y на уровне Y = 0
            zedGraph.GraphPane.YAxis.Cross = 0.0; // Ось Y будет пересекаться с осью X на уровне X = 0
            zedGraph.GraphPane.XAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            zedGraph.GraphPane.XAxis.Scale.IsSkipLastLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            zedGraph.GraphPane.XAxis.Scale.IsSkipCrossLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            zedGraph.GraphPane.YAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            zedGraph.GraphPane.YAxis.Scale.IsSkipLastLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            zedGraph.GraphPane.YAxis.Scale.IsSkipCrossLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            zedGraph.GraphPane.XAxis.Title.IsVisible = false; // Спрячем заголовки осей 
            zedGraph.GraphPane.YAxis.Title.IsVisible = false;

            zedGraph.Cursor = Cursors.Hand;

            zedGraph.Invalidate(); // Обновляем график
            zedGraph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 

            pictureBox7.Image = Properties.Resources.scoba;
            pictureBox1.Image = Properties.Resources.tau;
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            windowA.Value = -10;
            windowB.Value = 10;
            windowC.Value = -10;
            windowD.Value = 10;

            //par_A.Value = 1;
            //par_B.Value = 1;
            //par_D.Value = 1;
            //par_G.Value = 1;
            //par_P.Value = 1;
            //par_F.Value = 1;
            //
            //radio_1.Checked = true;
            //
            //numN.Value = 1;

            //очистка графиков
            this.zedGraph.GraphPane.CurveList.Clear();

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Scale.Min = -10;
            this.zedGraph.GraphPane.XAxis.Scale.Max = 10;
            this.zedGraph.GraphPane.YAxis.Scale.Min = -10;
            this.zedGraph.GraphPane.YAxis.Scale.Max = 10;

            //обновляем
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();

            curves.Clear();
        }

        private void par_ValueChanged(object sender, EventArgs e)
        {
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
                A = -10;
                B = 10;
                C = -10;
                D = 10;
                this.windowA.Value = -10;
                this.windowB.Value = 10;
                this.windowC.Value = -10;
                this.windowD.Value = 10;
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
            if (Alfa > 100)
            {
                Alfa = 100;
                par_A.Text = "100";
            }
            if (Alfa < -100)
            {
                Alfa = -100;
                par_A.Text = "-100";
            }
            if (Betta < -100)
            {
                Betta = -100;
                par_B.Text = "-100";
            }
            if (Betta > 100)
            {
                Betta = 100;
                par_B.Text = "100";
            }
            if (Pi > 100)
            {
                Pi = 100;
                par_P.Text = "100";
            }
            if (Pi < -100)
            {
                Pi = -100;
                par_P.Text = "-100";
            }
            if (Fi > 100)
            {
                Fi = 100;
                par_F.Text = "100";
            }
            if (Fi < -100)
            {
                Fi = -100;
                par_F.Text = "-100";
            }
            if (Delta > 100)
            {
                Delta = 100;
                par_D.Text = "100";
            }
            if (Delta < -100)
            {
                Delta = -100;
                par_D.Text = "-100";
            }

            // Интервалы для осей
            this.zedGraph.GraphPane.XAxis.Scale.Min = A;
            this.zedGraph.GraphPane.XAxis.Scale.Max = B;
            this.zedGraph.GraphPane.YAxis.Scale.Min = C;
            this.zedGraph.GraphPane.YAxis.Scale.Max = D;

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

            // Обновляем график
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();

            this.zedGraph.GraphPane.CurveList.Clear();

            foreach (Curve c in curves)
                method_of_EulerX(c);
        }

        void method_of_EulerX(Curve curve)//рисует интегральную кривую и выводит n_max
        {
            PointPairList list1 = new PointPairList();

            double x = curve.x0, y = curve.y0, x1;

            list1.Add(curve.x0, curve.y0);

            for (int par = 0; par < n; par++)
            {
                x1 = x;
                x = x + Tau * (Alfa * x * y + Pi);
                y = y + Tau * ((Betta * x - Gamm) * (Delta * y + Fi * x));
                list1.Add(x, y);
            }

            PointPairList list2 = new PointPairList();

            x = curve.x0; y = curve.y0;

            list2.Add(curve.x0, curve.y0);

            for (int par = 0; par < n; par++)
            {
                x1 = x;
                x = x - Tau * (Alfa * x * y + Pi);
                y = y - Tau * ((Betta * x - Gamm) * (Delta * y + Fi * x));
                list2.Add(x, y);
            }

            zedGraph.GraphPane.AddCurve("", list1, curve.color, SymbolType.None); // Создадим кривую
            zedGraph.GraphPane.AddCurve("", list2, curve.color, SymbolType.None); // Создадим кривую

            zedGraph.AxisChange();

            zedGraph.Invalidate(); // Обновляем график
        }

        private void Graph_MouseClick(object sender, MouseEventArgs e)//считавание координат клика мышкой
        {
            Curve curve;

            // Пересчитываем пиксели в координаты на графике
            // У ZedGraph есть несколько перегруженных методов ReverseTransform.
            zedGraph.GraphPane.ReverseTransform(e.Location, out curve.x0, out curve.x2, out curve.y0, out curve.y2);

            Random rnd = new Random();
            curve.color = _colors[rnd.Next(_colors.Length)];

            method_of_EulerX(curve);
            curves.Add(curve);
        }
    }
}

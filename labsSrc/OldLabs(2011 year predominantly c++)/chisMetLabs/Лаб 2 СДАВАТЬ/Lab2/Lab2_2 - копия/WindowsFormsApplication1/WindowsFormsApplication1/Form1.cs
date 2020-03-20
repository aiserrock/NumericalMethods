using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double A = -1, B = 1, C = -1, D = 1, Gamma, Beta, Alpha, Delta, Epsylon, a, b, sh, n_max;
        int n;

        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList list1 = new PointPairList();

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;

            radioButton_Alph.Checked = true;

            numericAlpha.Enabled = false;

            numeric_a.Value = -0.5m;
            numeric_b.Value = 0.5m;

            list.Add(0, 0); // добавляем точку (0,0) для отображения осей в центре в этой точе

            LineItem myCurve = this.Graph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None); // Создадим кривую

            this.Graph.GraphPane.Title.Text = "График"; //Заголовок графика

            this.Graph.GraphPane.XAxis.Cross = 0.0; // Ось X будет пересекаться с осью Y на уровне Y = 0

            this.Graph.GraphPane.YAxis.Cross = 0.0; // Ось Y будет пересекаться с осью X на уровне X = 0


            this.Graph.GraphPane.XAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            this.Graph.GraphPane.XAxis.Scale.IsSkipLastLabel = true;

            this.Graph.GraphPane.XAxis.Scale.IsSkipCrossLabel = true; // Отключим отображение меток в точке пересечения с другой осью

            this.Graph.GraphPane.YAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям

            this.Graph.GraphPane.YAxis.Scale.IsSkipLastLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            this.Graph.GraphPane.YAxis.Scale.IsSkipCrossLabel = true;

            this.Graph.GraphPane.XAxis.Title.IsVisible = false; // Спрячем заголовки осей 
            this.Graph.GraphPane.YAxis.Title.IsVisible = false;

            Graph.Invalidate(); // Обновляем график

            Graph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
        }

        private void Build_up_Click(object sender, EventArgs e)
        {

            this.Graph.GraphPane.CurveList.Clear(); //очистка координатной плоскости

            A = (double)Par_A.Value; //считывание ограничений
            B = (double)Par_B.Value;
            C = (double)Par_C.Value;
            D = (double)Par_D.Value;

            a = (double)numeric_a.Value;
            b = (double)numeric_b.Value;
            n = (int)numeric_points.Value;

            if (A >= B || C >= D)//проверка на коректность, иначе сбрасываем по умолчанию
            {
                MessageBox.Show("Значение А не может быть больше (либо равно) В\nЗначение C не может быть больше (либо равно) D");
                A = -1;
                B = 1;
                C = -1;
                D = 1;
                Par_A.Value = -1;
                Par_B.Value = 1;
                Par_C.Value = -1;
                Par_D.Value = 1;
            }

            if (a >= b)
            {
                MessageBox.Show("Значение a не может быть больше (либо равно) b");
                a = A * 0.5;
                numeric_a.Value = (decimal)a;
                b = B * 0.5;
                numeric_b.Value = (decimal)b;
            }

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            Alpha = (double)numericAlpha.Value;
            Beta = (double)numericBeta.Value;
            Gamma = (double)numericGamma.Value;
            Epsylon = (double)numericEpsylon.Value;

            // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;

            // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();

            //// Обновляем график
            this.Graph.Invalidate();

            if (radioButton1.Checked)
                Delta = 1.0;
            if (radioButton2.Checked)
                Delta = 0.1;
            if (radioButton3.Checked)
                Delta = 0.01;
            if (radioButton4.Checked)
                Delta = 0.001;
            if (radioButton5.Checked)
                Delta = 0.0001;

            method_of_rectangles();
        }

        private void Clear_Click(object sender, EventArgs e)//очистка и сброс параметров по умолчанию
        {
            Par_A.Value = -1;
            Par_B.Value = 1;
            Par_C.Value = -1;
            Par_D.Value = 1;
            numericAlpha.Value = 0;
            numericBeta.Value = 0;
            numericGamma.Value = 0;
            numeric_a.Value = -0.5m;
            numeric_b.Value = 0.5m;
            nMax.Text = "0";

            radioButton_Alph.Checked = true;
            numericAlpha.Enabled = false;

            radioButton1.Checked = true;
            numeric_points.Value = 1;

            this.Graph.GraphPane.CurveList.Clear();//очистка графиков

            // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Min = -1;
            this.Graph.GraphPane.XAxis.Scale.Max = 1;

            // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Min = -1;
            this.Graph.GraphPane.YAxis.Scale.Max = 1;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();

            //// Обновляем график
            this.Graph.Invalidate();
        }

        private void Param_Alph_CheckedChanged(object sender, EventArgs e)
        {
            numericAlpha.Enabled = false;
            numericBeta.Enabled = true;
            numericGamma.Enabled = true;
            numericEpsylon.Enabled = true;
        }

        private void Param_Gamma_CheckedChanged(object sender, EventArgs e)
        {
            numericAlpha.Enabled = true;
            numericBeta.Enabled = true;
            numericGamma.Enabled = false;
            numericEpsylon.Enabled = true;
        }

        private void Param_Bet_CheckedChanged(object sender, EventArgs e)
        {
            numericAlpha.Enabled = true;
            numericBeta.Enabled = false;
            numericGamma.Enabled = true;
            numericEpsylon.Enabled = true;
        }



        private void radioButton_Eps_CheckedChanged(object sender, EventArgs e)
        {
            numericAlpha.Enabled = true;
            numericBeta.Enabled = true;
            numericGamma.Enabled = true;
            numericEpsylon.Enabled = false;
        }

        double Runge(double p)
        {
            int n_count = n;
            double Int2n = Integral(p, n_count * 2), Intn = Integral(p, n_count);

            while (Delta < (1.0 / 3.0) * Math.Abs(Int2n - Intn))
            {
                n_count = n_count * 2;
                Int2n = Integral(p, n_count * 2);
                Intn = Integral(p, n_count);
            }

            if (n_count > n_max)
                n_max = n_count;

            return Int2n;
        }

        double Integral(double p1, int tmp)
        {
            double h = (Math.Abs(b) + Math.Abs(a)) / tmp;
            double InSum = 0, y = 0;

            if (radioButton_Alph.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    InSum += p1 * Math.Sin(Epsylon * y) * Math.Cos(Math.Tan(Beta / y - Gamma));
                }
                return h * InSum;
            }

            if (radioButton_Bet.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    InSum += Alpha * Math.Sin(Epsylon * y) * Math.Cos(Math.Tan(p1 / y - Gamma));
                }
                return h * InSum;
            }

            if (radioButton_Gamma.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    InSum += Alpha * Math.Sin(Epsylon * y) * Math.Cos(Math.Tan(Beta / y - p1));
                }
                return h * InSum;
            }

            if (radioButton_Eps.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    InSum += Alpha * Math.Sin(p1 * y) * Math.Cos(Math.Tan(Beta / y - Gamma));
                }
                return h * InSum;
            }

            return 0;
        }

        void method_of_rectangles()//рисует интегральную кривую и выводит n_max
        {
            list1.Clear();
            n_max = 0;

            for (double parametr = A; parametr <= B; parametr += sh)
            {
                list1.Add(parametr, Runge(parametr));
            }

            nMax.Text = Convert.ToString(n_max);

            LineItem myCurve1 = this.Graph.GraphPane.AddCurve("", list1, Color.Red, SymbolType.None); // Создадим кривую

            this.Graph.AxisChange();

            Graph.Invalidate(); // Обновляем график
        }
    }

}

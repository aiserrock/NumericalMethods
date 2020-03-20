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
        double A = -5, B = 5, C = -5, D = 5, Alph, Bet, Gam, Delt, a, b, sh;
        decimal n, n_max;

        PointPairList list = new PointPairList(); // Создадим списки точек из которых будут формироваться графики
        PointPairList list1 = new PointPairList(); // Собственно график
        PointPairList list3 = new PointPairList(); // Список точек ограничений [A,B]x[C,D]

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
            AlphaButton.Checked = true;
            nMax.Maximum = decimal.MaxValue;

            list.Add(0, 0); // добавляем точку (0,0) для отображения осей в центре в этой точе

            LineItem myCurve = this.Graph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None); // Создадим кривую

            this.Graph.GraphPane.Title.Text = "f(x) = Alpha * Cos(Tan(Beta * x)) * Cos(Gam * x)"; //Заголовок графика
            
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

            Clear_Click(this, null);
        }

        private void Build_up_Click(object sender, EventArgs e)
        {
            this.Graph.GraphPane.CurveList.Clear(); // Очистка координатной плоскости

            list3.Clear(); // Очистка списка точек

            // Считывание ограничений
            A = Convert.ToDouble(this.Par_A.Value);
            B = Convert.ToDouble(this.Par_B.Value);
            C = Convert.ToDouble(this.Par_C.Value);
            D = Convert.ToDouble(this.Par_D.Value);

            if (radioButton1.Checked)
                Delt = 1.0;
            if (radioButton2.Checked)
                Delt = 0.1;
            if (radioButton3.Checked)
                Delt = 0.01;
            if (radioButton4.Checked)
                Delt = 0.001;

            a = Convert.ToDouble(this.numericA.Value);
            b = Convert.ToDouble(this.numericB.Value);
            n = Convert.ToDecimal(this.numeric_points.Value);

            if (A >= B || C >= D) // Проверка на коректность, иначе сбрасываем по умолчанию
            {
                MessageBox.Show("Значение А не может быть больше (либо равно) В\nЗначение C не может быть больше (либо равно) D");
                A = -5;
                B = 5;
                C = -5;
                D = 5;
                this.Par_A.Value = -5;
                this.Par_B.Value = 5;
                this.Par_C.Value = -5;
                this.Par_D.Value = 5;
            }
            if (a >= b)
            {
                MessageBox.Show("Значение a не может быть больше (либо равно) b");
                a = -5;
                b = 5;
                this.numericA.Value = -5;
                this.numericB.Value = 5;
            }

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            // Заполнение списка
            list3.Add(A, D);
            list3.Add(B, D);
            list3.Add(B, C);
            list3.Add(A, C);
            list3.Add(A, D);

            // Считывание параметров
            Alph = Convert.ToDouble(this.Alpha1.Value);
            Bet = Convert.ToDouble(this.Beta1.Value);
            Gam = Convert.ToDouble(this.Gamma1.Value);

            // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;

            // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;
            

            LineItem myCurve1 = this.Graph.GraphPane.AddCurve("", list3, Color.Red, SymbolType.None); // Создадим кривую
            
            myCurve1.Line.Width = 3; // Толщина линии в пикселях

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();

            // Обновляем график
            this.Graph.Invalidate();

            // Строим новый график
            Draw_Graph();
        }

        private void Clear_Click(object sender, EventArgs e)//очистка и сброс параметров по умолчанию
        {
            Par_A.Value = -5;
            Par_B.Value = 5;
            Par_C.Value = -5;
            Par_D.Value = 5;
            Alpha1.Value = 1;
            Beta1.Value = 1;
            Gamma1.Value = 1;
            radioButton1.Checked = true;
            AlphaButton.Checked = true;
            numeric_points.Value = 1;

            n_max = 0;
            this.nMax.Value = n_max;

            a = -5; this.numericA.Text = Convert.ToString(a);
            b = 5; this.numericB.Text = Convert.ToString(b);

            // Очистка графиков
            this.Graph.GraphPane.CurveList.Clear();

            // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Min = -5;
            this.Graph.GraphPane.XAxis.Scale.Max = 5;

            // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Min = -5;
            this.Graph.GraphPane.YAxis.Scale.Max = 5;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();

            // Обновляем график
            this.Graph.Invalidate();
        }

        double trapezoidal(double par, int n_count)
        {
            double h = (Math.Abs(b) + Math.Abs(a)) / n_count;
            double InSum_first = 0, InSum_second = 0, y = 0;

            if (AlphaButton.Checked) // Формула трапециев для фиксированной альфы
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += par * Math.Cos(Math.Tan(Bet * x)) * Math.Cos(Gam * x);
                    InSum_second += par * Math.Cos(Math.Tan(Bet * y)) * Math.Cos(Gam * y);
                }
                return h * (InSum_first + InSum_second) / 2;
            }

            if (BetaButton.Checked) // Формула трапециев для фиксированной беты
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += Alph * Math.Cos(Math.Tan(par * x)) * Math.Cos(Gam * x);
                    InSum_second += Alph * Math.Cos(Math.Tan(par * y)) * Math.Cos(Gam * y);
                }
                return h * (InSum_first + InSum_second) / 2;
            }

            if (GammaButton.Checked) // Формула трапециев для фиксированной гаммы
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += Alph * Math.Cos(Math.Tan(Bet * x)) * Math.Cos(par * x);
                    InSum_second += Alph * Math.Cos(Math.Tan(Bet * y)) * Math.Cos(par * y);
                }
                return h * (InSum_first + InSum_second) / 2;
            }
            return 0;
        }

        double Runge(double par) // https://ru.wikipedia.org/wiki/Правило_Рунге
        {
            int n_count = Convert.ToInt16(n);
            double Int2n = trapezoidal(par, n_count * 2);
            double Intn = trapezoidal(par, n_count);

            while (Delt < (1.0 / 3.0) * Math.Abs(Int2n - Intn))
            {
                n_count = n_count * 2;
                Int2n = trapezoidal(par, n_count * 2);
                Intn = trapezoidal(par, n_count);
            }

            if (n_count > n_max)
                n_max = n_count;

            return Int2n;
        }

        void Draw_Graph() // Рисует интегральную кривую и выводит n_max
        {
            list1.Clear();
            n_max = 0;

            for (double par = A; par <= B; par += sh)
                list1.Add(par, Runge(par));

            nMax.Value = n_max;

            LineItem myCurve2 = this.Graph.GraphPane.AddCurve("", list1, Color.DarkBlue, SymbolType.None); // Создадим кривую
            myCurve2.Line.Width = 2; // Толщина линии графика

            myCurve2.Line.IsSmooth = true; // Сглаживание
            this.Graph.Invalidate();
        }
    }
}

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
        double A = -10, B = 10, C = -10, D = 10, Alpha, Beta, Gamma, Delta, Epsilon, a, b, sh, n_max;
        int n;

        PointPairList axis = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList graphline = new PointPairList();

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
            radioButton_Alph.Checked = true;

            axis.Add(0, 0); // добавляем точку (0,0) для отображения осей в центре в этой точе

            LineItem myAxis = this.Graph.GraphPane.AddCurve("", axis, Color.Yellow, SymbolType.None); // Создадим кривую

            this.Graph.GraphPane.Title.Text = "f(x) = ε * sin[(β*x)/(α^2-x^2)] * cos[γ*x]"; //Заголовок графика

            this.Graph.GraphPane.XAxis.Cross = 0.0; // Ось X будет пересекаться с осью Y на уровне Y = 0
            this.Graph.GraphPane.YAxis.Cross = 0.0; // Ось Y будет пересекаться с осью X на уровне X = 0

            //Сетка
            this.Graph.GraphPane.YAxis.MajorGrid.IsVisible = true;
            this.Graph.GraphPane.YAxis.MajorGrid.Color = Color.GreenYellow;
            this.Graph.GraphPane.XAxis.MajorGrid.IsVisible = true;
            this.Graph.GraphPane.XAxis.MajorGrid.Color = Color.GreenYellow;
            //this.Graph.GraphPane.YAxis.MinorGrid.IsVisible = true;
            //this.Graph.GraphPane.YAxis.MinorGrid.Color = Color.YellowGreen;
            //this.Graph.GraphPane.XAxis.MinorGrid.IsVisible = true;
            //this.Graph.GraphPane.XAxis.MinorGrid.Color = Color.YellowGreen;

            this.Graph.GraphPane.XAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            this.Graph.GraphPane.XAxis.Scale.IsSkipLastLabel = true;
            this.Graph.GraphPane.YAxis.Scale.IsSkipFirstLabel = true;
            this.Graph.GraphPane.YAxis.Scale.IsSkipLastLabel = true;
            this.Graph.GraphPane.XAxis.Scale.IsSkipCrossLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            this.Graph.GraphPane.YAxis.Scale.IsSkipCrossLabel = true;

            this.Graph.GraphPane.XAxis.Title.IsVisible = false; // Спрячем заголовки осей 
            this.Graph.GraphPane.YAxis.Title.IsVisible = false;

            // Устанавливаем интересующий нас интервал отображения по осиям
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;

            //закраска область графика
            this.Graph.GraphPane.Fill.Type = FillType.Solid;
            this.Graph.GraphPane.Fill.Color = Color.MidnightBlue;
            this.Graph.GraphPane.Border.Color = Color.MidnightBlue;
            //цвет рамки вокруг графика
            this.Graph.GraphPane.Chart.Border.Color = Color.Yellow;
            this.Graph.GraphPane.Title.FontSpec.FontColor = Color.YellowGreen;
            // Закраска области построения
            this.Graph.GraphPane.Chart.Fill.Type = FillType.Solid;
            this.Graph.GraphPane.Chart.Fill.Color = Color.Black;
            //установка цвета осей
            this.Graph.GraphPane.XAxis.Color = Color.Yellow;
            this.Graph.GraphPane.YAxis.Color = Color.Yellow;
            //установка цвета шрифтов
            this.Graph.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.Yellow;
            this.Graph.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.Yellow;

            Graph.Invalidate(); // Обновляем график
            Graph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
        }

        private void Build_up_Click(object sender, EventArgs e)//постройка графика
        {

            this.Graph.GraphPane.CurveList.Clear(); //очистка координатной плоскости

                        if (radioButton1.Checked)
                Delta = 1.0;
            if (radioButton2.Checked)
                Delta = 0.1;
            if (radioButton3.Checked)
                Delta = 0.01;
            if (radioButton4.Checked)
                Delta = 0.001;

            A = (double)Par_A.Value; //считывание ограничений
            B = (double)Par_B.Value;
            C = (double)Par_C.Value;
            D = (double)Par_D.Value;
            a = (double)numeric_a.Value;
            b = (double)numeric_b.Value;
            n = (int)numeric_points.Value;

            if (A >= B)//проверка на корректность
            {
                double temp = A;
                A = B;
                B = temp;
                Par_A.Value = (decimal)A;
                Par_B.Value = (decimal)B;
            }
            if (C >= D)
            {
                double temp = C;
                C = D;
                D = temp;
                Par_C.Value = (decimal)C;
                Par_D.Value = (decimal)D;
            }
            if (a >= b)
            {
                double temp = a;
                a = b;
                numeric_a.Value = (decimal)a;
                b = temp;
                numeric_b.Value = (decimal)b;
            }

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            Alpha = (double)numericAlpha.Value;
            Beta = (double)numericBeta.Value;
            Gamma = (double)numericGamma.Value;
            Epsilon = (double)numericEpsilon.Value;

            // Устанавливаем интересующий нас интервал отображения
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;

            this.Graph.AxisChange();
            this.Graph.Invalidate();

            draw_graph();
        }

        private void Clear_Click(object sender, EventArgs e)//очистка и сброс параметров по умолчанию
        {

            this.Graph.GraphPane.CurveList.Clear();//очистка графиков
            n_max = 0;
            nMax.Text = Convert.ToString(n_max);

            this.Graph.AxisChange();
            this.Graph.Invalidate();
        }

        private void Param_Alph_CheckedChanged(object sender, EventArgs e)//Подсвечиваем альфу
        {
            Alph_box.Visible = true;
            Bet_box.Visible = false;
            Gam_box.Visible = false;
            Eps_box.Visible = false;
        }
        private void Param_Bet_CheckedChanged(object sender, EventArgs e)//Подсвечиваем бету
        {
            Alph_box.Visible = false;
            Bet_box.Visible = true;
            Gam_box.Visible = false;
            Eps_box.Visible = false;
        }
        private void Param_Gamma_CheckedChanged(object sender, EventArgs e)//Подсвечиваем гамму
        {
            Alph_box.Visible = false;
            Bet_box.Visible = false;
            Gam_box.Visible = true;
            Eps_box.Visible = false;
        }
        private void Param_Eps_CheckedChanged(object sender, EventArgs e)//Подсвечиваем эпсилон
        {
            Alph_box.Visible = false;
            Bet_box.Visible = false;
            Gam_box.Visible = false;
            Eps_box.Visible = true;
        }

        double trapezoidal(double par, int n_count)
        {
            double h = (Math.Abs(b) + Math.Abs(a)) / n_count;
            double InSum_first = 0, InSum_second = 0, y = 0;

            if (radioButton_Alph.Checked)//Формула трапециев для фиксированной альфы
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += (Epsilon * Math.Sin((Beta * x) / (Math.Pow(x, 2) - Math.Pow(par, 2))) * Math.Cos(Gamma * x));
                    InSum_second += (Epsilon * Math.Sin((Beta * y) / (Math.Pow(y, 2) - Math.Pow(par, 2))) * Math.Cos(Gamma * y));
                }
                return h * (InSum_first + InSum_second) / 2;
            }

            if (radioButton_Bet.Checked)//Формула трапециев для фиксированной беты
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += (Epsilon * Math.Sin((par * x) / (Math.Pow(x, 2) - Math.Pow(Alpha, 2))) * Math.Cos(Gamma * x));
                    InSum_second += (Epsilon * Math.Sin((par * y) / (Math.Pow(y, 2) - Math.Pow(Alpha, 2))) * Math.Cos(Gamma * y));
                }
                return h * (InSum_first + InSum_second) / 2;
            }

            if (radioButton_Gamma.Checked)//Формула трапециев для фиксированной гаммы
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += (Epsilon * Math.Sin((Beta * x) / (Math.Pow(x, 2) - Math.Pow(Alpha, 2))) * Math.Cos(par * x));
                    InSum_second += (Epsilon * Math.Sin((Beta * y) / (Math.Pow(y, 2) - Math.Pow(Alpha, 2))) * Math.Cos(par * y));
                }
                return h * (InSum_first + InSum_second) / 2;
            }

            if (radioButton_Epsilon.Checked)//Формула трапециев для фиксированной эпсилоны
            {
                for (double x = a; x < b; x += h)
                {
                    y = x + h;
                    InSum_first += (par * Math.Sin((Beta * x) / (Math.Pow(x, 2) - Math.Pow(Alpha, 2))) * Math.Cos(Gamma * x));
                    InSum_second += (par * Math.Sin((Beta * y) / (Math.Pow(y, 2) - Math.Pow(Alpha, 2))) * Math.Cos(Gamma * y));
                }
                return h * (InSum_first + InSum_second) / 2;
            }
            return 0;
        }

        double Runge(double par)//https://ru.wikipedia.org/wiki/Правило_Рунге
        {
            int n_count = n;
            double Int2n = trapezoidal(par, n_count * 2);
            double Intn = trapezoidal(par, n_count);

            while (Delta < (1.0 / 3.0) * Math.Abs(Int2n - Intn))
            {
                n_count = n_count * 2;
                Int2n = trapezoidal(par, n_count * 2);
                Intn = trapezoidal(par, n_count);
            }

            if (n_count > n_max)
                n_max = n_count;

            return Int2n;
        }

        void draw_graph()//рисует интегральную кривую и выводит n_max
        {
            graphline.Clear();
            n_max = 0;

            if (Alpha == 1.0 && Beta == 4.0 && Gamma == 8.0 && Epsilon == 8.0)
            {
                this.Graph.GraphPane.Chart.Fill.Color = Color.Red;
                this.Graph.GraphPane.YAxis.MajorGrid.IsVisible = false;
                this.Graph.GraphPane.XAxis.MajorGrid.IsVisible = false;
                this.Graph.GraphPane.XAxis.Scale.Min = 0;
                this.Graph.GraphPane.XAxis.Scale.Max = 100;
                this.Graph.GraphPane.YAxis.Scale.Min = 0;
                this.Graph.GraphPane.YAxis.Scale.Max = 100;

                PointPairList list1 = new PointPairList();
                for (double par = 20; par <= 80 ; par += sh)
                    list1.Add(par, 50);
                LineItem list_1 = this.Graph.GraphPane.AddCurve("", list1, Color.Black, SymbolType.None);
                list_1.Line.Width = 10;
                PointPairList list2 = new PointPairList();
                for (double par = 20; par <= 80; par += sh)
                    list2.Add(50, par);
                LineItem list_2 = this.Graph.GraphPane.AddCurve("", list2, Color.Black, SymbolType.None);
                list_2.Line.Width = 10;
                PointPairList list3 = new PointPairList();
                for (double par = 20; par <= 50; par += sh)
                    list3.Add(par, 20);
                for (double par = 50; par <= 80; par += sh)
                    list3.Add(par, 80);
                LineItem list_3 = this.Graph.GraphPane.AddCurve("", list3, Color.Black, SymbolType.None);
                list_3.Line.Width = 10;
                PointPairList list4 = new PointPairList();
                for (double par = 20; par <= 50; par += sh)
                    list4.Add(80, par);
                for (double par = 50; par <= 80; par += sh)
                    list4.Add(20, par);
                LineItem list_4 = this.Graph.GraphPane.AddCurve("", list4, Color.Black, SymbolType.None);
                list_4.Line.Width = 10;

                this.Graph.AxisChange();
                this.Graph.Invalidate();
            }
            else if (Alpha == 1.0 && Beta == 9.0 && Gamma == 2.0 && Epsilon == 2.0)
            {
                this.Graph.GraphPane.Chart.Fill.Color = Color.Red;
                this.Graph.GraphPane.YAxis.MajorGrid.IsVisible = false;
                this.Graph.GraphPane.XAxis.MajorGrid.IsVisible = false;
                this.Graph.GraphPane.XAxis.Scale.Min = 0;
                this.Graph.GraphPane.XAxis.Scale.Max = 100;
                this.Graph.GraphPane.YAxis.Scale.Min = 0;
                this.Graph.GraphPane.YAxis.Scale.Max = 100;

                PointPairList star = new PointPairList();
                    star.Add(30, 30);
                    star.Add(50, 80);
                    star.Add(70, 30);
                    star.Add(20, 60);
                    star.Add(80, 60);
                    star.Add(30, 30);
                LineItem STAR = this.Graph.GraphPane.AddCurve("", star, Color.Gold, SymbolType.None);
                STAR.Line.Width = 5;
                this.Graph.AxisChange();
                this.Graph.Invalidate();
            }
            else
            {

                this.Graph.GraphPane.Chart.Fill.Color = Color.Black;
                this.Graph.GraphPane.YAxis.MajorGrid.IsVisible = true;
                this.Graph.GraphPane.XAxis.MajorGrid.IsVisible = true;
                this.Graph.GraphPane.XAxis.Scale.Min = A;
                this.Graph.GraphPane.XAxis.Scale.Max = B;
                this.Graph.GraphPane.YAxis.Scale.Min = C;
                this.Graph.GraphPane.YAxis.Scale.Max = D;

                for (double par = A; par <= B; par += sh)
                    graphline.Add(par, Runge(par));

                nMax.Text = Convert.ToString(n_max);

                LineItem mygraphline = this.Graph.GraphPane.AddCurve("", graphline, Color.Lime, SymbolType.None); // Создадим кривую
                mygraphline.Line.Width = 2;//Толщина линии графика

                mygraphline.Line.IsSmooth = true;//сглаживание
                this.Graph.AxisChange();
                Graph.Invalidate();
            }

        }

    }
}

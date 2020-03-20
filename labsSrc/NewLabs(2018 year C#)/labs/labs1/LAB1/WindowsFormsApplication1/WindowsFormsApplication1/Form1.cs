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
        double A = -5, B = 5, C = -5, D = 5, y, Gam, Bet, Alph, Delt, sh, h, t, tmp = 1, x0;
        int n, e = 1;
        double[,] rez = new double[5000,5000];


        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList list1 = new PointPairList();//fx()
        PointPairList list2 = new PointPairList();//dfx()
        PointPairList list3 = new PointPairList();//список точек ограничений [A,B]x[C,D]
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList(); //dPnx
        PointPairList list6 = new PointPairList();//Rnx

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;


            list.Add(0, 0); // добавляем точку (0,0) для отображения осей в центре в этой точе

            LineItem myCurve = this.Graph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None); // Создадим кривую

            //this.Graph.GraphPane.Title.Text = "График"; //Заголовок графика
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
            Clear_Click(this,null);
        }

        private void Build_up_Click(object sender, EventArgs e)
        {

            this.Graph.GraphPane.CurveList.Clear(); //очистка координатной плоскости

            list3.Clear();//очистка списка точек

            A = Convert.ToDouble(this.Par_A.Value); //считывание ограничений
            B = Convert.ToDouble(this.Par_B.Value);
            C = Convert.ToDouble(this.Par_C.Value);
            D = Convert.ToDouble(this.Par_D.Value);

            if (A >= B || C >= D)//проверка на коректность, иначе сбрасываем по умолчанию
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

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            list3.Add(A, D);//заполнение списка
            list3.Add(B, D);
            list3.Add(B, C);
            list3.Add(A, C);
            list3.Add(A, D);

            Alph = Convert.ToDouble(this.Alpha1.Value);//считывание параметров
            Bet = Convert.ToDouble(this.Beta1.Value);
            Gam = Convert.ToDouble(this.Gamma1.Value);

            InicialPolinom();

            // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;

            // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;
            

            LineItem myCurve1 = this.Graph.GraphPane.AddCurve("", list3, Color.Red, SymbolType.None); // Создадим кривую
            
            myCurve1.Line.Width = 3;//толщина линии в пикселях

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();

            //// Обновляем график
            this.Graph.Invalidate();


            if (f_x.Checked)//отмечаем, какие графики отображать
                fx();

            if (df_x.Checked)
                dfx();

            if (Pn_x.Checked)
                Pnx();

            if (dPn_x.Checked)
                dPnx();

            if (Rn_x.Checked)
                Rnx();
        }

        double function(double x)
        {
            return Alph * Math.Cos(Math.Tan(Bet*x))*Math.Cos(Gam*x);
        }

        void fx()//график исходной функции
        {
            list1.Clear();//очистка списка

            for (double x = A; x <= B; x +=sh)//вычисляем точки функции с указанным шагом
            {
                y = function(x);
                //y = ((Alph + Bet * Math.Pow(x, 3)) * Math.Pow(Math.Sin(Gam * x), 2));
                list1.Add(x, y);//добавляем точки в список
            }

            LineItem myCurve2 = this.Graph.GraphPane.AddCurve("f(x)", list1, Color.DarkBlue, SymbolType.None);//рисуем функцию

            
            myCurve2.Line.IsSmooth = true;//сглаживание графика
            
            this.Graph.Invalidate(); // Обновляем график
        }

        void dfx()//график df(x)
        {
            list2.Clear();//очистка списка точек

            if (radioButton1.Checked)//параметры дельта
                Delt = 1;
            if (radioButton2.Checked)
                Delt = 0.1;
            if (radioButton3.Checked)
                Delt = 0.01;
            if (radioButton4.Checked)
                Delt = 0.001;
            if (radioButton5.Checked)
                Delt = 0.0001;

            for (double x = A; x < B; x +=sh)//вычисляем точки функции
            {
                y = -Alph*(Gam*Math.Sin(Gam*x)*Math.Cos(Math.Tan(Bet*x))+Bet*Math.Pow(1/Math.Cos(Bet*x), 2)*Math.Cos(Gam*x)*Math.Sin(Math.Tan(Bet*x)));
                //y = (1/Delt)*(((Alph + Bet * Math.Pow((x + Delt), 3)) * Math.Pow(Math.Sin(Gam * (x + Delt)), 2)) - ((Alph + Bet * Math.Pow(x, 3)) * Math.Pow(Math.Sin(Gam*x),2)));
                list2.Add(x, y);//добавляем их в список
            }

            LineItem myCurve3 = this.Graph.GraphPane.AddCurve("df(x)", list2, Color.Green, SymbolType.None);//рисуем график


            myCurve3.Line.IsSmooth = true;//сглаживание
            
            this.Graph.Invalidate();// Обновляем график
        }

        void Pnx()
        {
            list4.Clear();

            for (double x = A; x <= B; x += sh)//вычисляем точки функции с указанным шагом
            {
                t = (x - x0) / h;
                tmp = 1;
                e = 1;
                y = Polinom(n, t);
                list4.Add(x, y);
            }

            LineItem myCurve4 = this.Graph.GraphPane.AddCurve("Pn(x)", list4, Color.Red, SymbolType.None);//рисуем график

            myCurve4.Line.IsSmooth = true;//сглаживание


            this.Graph.Invalidate();// Обновляем график
        }

        double Polinom(int n, double t)
        {
            double xx = (A + B) / 2;
            double p = function(xx);
            ///double p = ((Alph + Bet * Math.Pow(((A + B) / 2), 3)) * Math.Pow(Math.Sin(Gam * ((A + B) / 2)), 2));
            int j;
            for (int i = 1; i <= 2 * n; i++)
            {
                if ( i % 2 == 0) j = 2;
                else j = 1;
                p += simV(i) * Math.Pow(t, j) * tet(i, t);
            } 
            return p;
        }

        double tet(int i, double t)
        {
            if (i < 2) return 1;
            if (i % 2 == 0)
            {
                tmp = tmp / i;
                return tmp;
            } 
            tmp = (tmp * (t * t - e * e))/i;
            e++;
            return tmp;
        }

        double simV(int i)
        {
            if (i % 2 != 0)
            {
                return (rez[2 * n + 1, i] + rez[2 * n - 1, i]) / 2;
            }
            else
            {
                return rez[2 * n, i];
            }  
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
            f_x.Checked = false;
            Pn_x.Checked = false;
            Rn_x.Checked = false;
            df_x.Checked = false;
            dPn_x.Checked = false;
            radioButton1.Checked = true;
            interpolation_points.Value = 1;

            this.Graph.GraphPane.CurveList.Clear();//очистка графиков

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

            //// Обновляем график
            this.Graph.Invalidate();
        }

        void InicialPolinom()//инициализация полинома и расчёт таблицы центральных разностей
        {
            n = Convert.ToInt32(interpolation_points.Value); //число узлов интерполяции

            x0 = (A + B) / 2;

            h = (B - A) / (2 * n); //шаг интерполяции

            int a = 0;

            for (double x = A; x <= B; x += h)
            {
                rez[a, 0] = function(x);
                //rez[a, 0] = ((Alph + Bet * Math.Pow(x, 3)) * Math.Pow(Math.Sin(Gam * x), 2));
                a += 2;
            }

            for (int j = 1; j <= 2 * n; j++)
            for (int i = j; i <= 4 * n - j; i += 2)
            {
                rez[i, j] = rez[i + 1, j - 1] - rez[i - 1, j - 1];
            }
        }

        void dPnx()
        {
            list5.Clear();

            if (radioButton1.Checked)//параметры дельта
                Delt = 1;
            if (radioButton2.Checked)
                Delt = 0.1;
            if (radioButton3.Checked)
                Delt = 0.01;
            if (radioButton4.Checked)
                Delt = 0.001;
            if (radioButton5.Checked)
                Delt = 0.0001;

            for (double x = A; x <= B; x += h)//вычисляем точки функции с указанным шагом
            {
                    t = (x - x0) / h;
                    tmp = 1;
                    e = 1;
                    y = (1 / Delt) * (Polinom(n, ((x + Delt - x0) / h)) - Polinom(n, t));
                    list5.Add(x, y);
            }

            LineItem myCurve5 = this.Graph.GraphPane.AddCurve("dPn(x)", list5, Color.Orange, SymbolType.None);//рисуем график


            myCurve5.Line.IsSmooth = true;//сглаживание

            this.Graph.Invalidate();// Обновляем график
        }

        void Rnx()
        {
            list6.Clear();

            for (double x = A; x <= B; x += sh)//вычисляем точки функции с указанным шагом
            {
                    t = (x - x0) / h;
                    tmp = 1;
                    e = 1;
                    y = Math.Abs(function(x) - Polinom(n, t));
                    //y = Math.Abs(((Alph + Bet * Math.Pow(x, 3)) * Math.Pow(Math.Sin(Gam * x), 2)) - Polinom(n,t));
                    list6.Add(x, y);
             }

            LineItem myCurve6 = this.Graph.GraphPane.AddCurve("Rn(x)", list6, Color.Brown, SymbolType.None);//рисуем график

            myCurve6.Line.IsSmooth = true;//сглаживание

            this.Graph.Invalidate();// Обновляем график
        }
    }
}

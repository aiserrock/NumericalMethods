using System;
using System.Collections.Generic;
using System.Collections;
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
        double A=-50, B=50, C=-50, D=50, y, Alph, Bet, Gam, Eps, Delt, sh, h, t, tmp=1, x0;
        int n, e=1;
        double[,] rez = new double[1000,1000];


        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList list1 = new PointPairList();//fx()
        PointPairList list2 = new PointPairList();//dfx()
        PointPairList list3 = new PointPairList();//список точек ограничений [A,B]x[C,D]
        PointPairList list4 = new PointPairList();//Pn(x)
        PointPairList list5 = new PointPairList();//dPnx
        PointPairList list6 = new PointPairList();//Rnx

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;

            list.Add(0, 0); // добавляем точку (0,0) для отображения осей в центре в этой точе

            LineItem myCurve = this.Graph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None); // Создадим кривую

            this.Graph.GraphPane.Title.Text = "f(x) = α * cos[ε*x] * sin[tg[β/x-γ]]"; //Заголовок графика
            
            
            this.Graph.GraphPane.XAxis.Cross = 0.0; // Ось X будет пересекаться с осью Y в точке (0,0)
            this.Graph.GraphPane.YAxis.Cross = 0.0;

            this.Graph.GraphPane.XAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            this.Graph.GraphPane.XAxis.Scale.IsSkipLastLabel = true;
            
            this.Graph.GraphPane.XAxis.Scale.IsSkipCrossLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            
            this.Graph.GraphPane.YAxis.Scale.IsSkipFirstLabel = true; // Отключим отображение первых и последних меток по осям
            
            this.Graph.GraphPane.YAxis.Scale.IsSkipLastLabel = true; // Отключим отображение меток в точке пересечения с другой осью
            this.Graph.GraphPane.YAxis.Scale.IsSkipCrossLabel = true;
           
            this.Graph.GraphPane.XAxis.Title.IsVisible = false; // Спрячем заголовки осей 
            this.Graph.GraphPane.YAxis.Title.IsVisible = false;

            this.Graph.GraphPane.XAxis.Scale.Min = A; // Устанавливаем интересующий нас интервал по оси X (интерал отображения графика)
            this.Graph.GraphPane.XAxis.Scale.Max = B;

            this.Graph.GraphPane.YAxis.Scale.Min = C; // Устанавливаем интересующий нас интервал по оси Y (интерал отображения графика)
            this.Graph.GraphPane.YAxis.Scale.Max = D;

            Graph.Invalidate(); // Обновляем график
            Graph.AxisChange(); // Обновляем данные об осях. 
            
        }

        private void Build_up_Click(object sender, EventArgs e)
        {

            this.Graph.GraphPane.CurveList.Clear(); //очистка координатной плоскости
            list3.Clear();//очистка списка точек

            //считывание ограничений
            A = Convert.ToDouble(this.Par_A.Value);
            B = Convert.ToDouble(this.Par_B.Value);
            C = Convert.ToDouble(this.Par_C.Value);
            D = Convert.ToDouble(this.Par_D.Value);

            if (A >= B || C >= D)//проверка на коректность, иначе сбрасываем по умолчанию
            {
                MessageBox.Show("Значение А не может быть больше (либо равно) В\nЗначение C не может быть больше (либо равно) D");
                A = -10;
                B = 10;
                C = -10;
                D = 10;
                this.Par_A.Value = -10;
                this.Par_B.Value = 10;
                this.Par_C.Value = -10;
                this.Par_D.Value = 10;
            }

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            //заполнение списка
            list3.Add(A, D);
            list3.Add(B, D);
            list3.Add(B, C);
            list3.Add(A, C);
            list3.Add(A, D);

            //считывание параметров
            Alph = Convert.ToDouble(this.Alpha1.Value);
            Bet = Convert.ToDouble(this.Beta1.Value);
            Gam = Convert.ToDouble(this.Gamma1.Value);
            Eps = Convert.ToDouble(this.Epsilon1.Value);

            // Устанавливаем интересующий нас интервал по осям
            this.Graph.GraphPane.XAxis.Scale.Min = A;
            this.Graph.GraphPane.XAxis.Scale.Max = B;
            this.Graph.GraphPane.YAxis.Scale.Min = C;
            this.Graph.GraphPane.YAxis.Scale.Max = D;

            // Вызываем метод AxisChangе, чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            this.Graph.AxisChange();
            this.Graph.Invalidate();

            //отмечаем, какие графики отображать
            if (f_x.Checked)
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

        double F(double x)
        {
            return (Alph * Math.Cos(Eps * x) * Math.Sin(Math.Tan(Bet / (x - Gam))));
            //return (Eps * Math.Sin((Bet * x) / (Math.Pow(x, 2) - Math.Pow(Alph, 2))) * Math.Cos(Gam * x));
        }
        
        /*-------------------------------------график исходной функции-----------------------------------*/
        void fx()
        {
            list1.Clear();//очистка списка

            for (double x = A; x <= B; x +=sh)//вычисляем точки функции с указанным шагом
            {
                y = F(x);
                list1.Add(x, y);//добавляем точки в список
            }

            LineItem myCurve2 = this.Graph.GraphPane.AddCurve("f(x)", list1, Color.Green, SymbolType.None);//рисуем функцию
            myCurve2.Line.IsSmooth = true;//сглаживание графика
            this.Graph.Invalidate(); // Обновляем график
        }

        /*-------------------------------------график df(x)-----------------------------------*/
        void dfx()
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
                y = (1 / Delt) * (F(x+Delt) - F(x));
                list2.Add(x, y);//добавляем их в список
            }

            LineItem myCurve3 = this.Graph.GraphPane.AddCurve("df(x)", list2, Color.Yellow, SymbolType.None);

            myCurve3.Line.IsSmooth = true;//сглаживание          
            this.Graph.Invalidate();// Обновляем график
        }

        /*-------------------------------------график Pn(x)-----------------------------------*/
        void Pnx()
        {
            list4.Clear();//очистка списка точек

            Hashtable table = init_table();
            
            for (double x = 0; x <= 100; x += sh)//вычисляем точки функции с указанным шагом
            {
                double q = (x - x0) / h;
                double k = 1;
                double value = (double)((Hashtable)table[0])[0];
		        for(int i = 1; i <= (n - 1); i++)
		        {
		            if (i % 2 == 1)
			        k *= (q - (int)(i / 2)) / i;
		            if (i % 2 == 0)
			        k *= (q + (int)(i / 2)) / i;
		            value += k * (double)((Hashtable)table[i])[(int)(- i / 2)];
		        }
                list4.Add(x, value);
            }

            LineItem myCurve4 = this.Graph.GraphPane.AddCurve("Pn(x)", list4, Color.RosyBrown, SymbolType.None);
            myCurve4.Line.IsSmooth = true;//сглаживание
            this.Graph.Invalidate();// Обновляем график
        }

        /*-------------------------------------график dPn(x)-----------------------------------*/
        void dPnx()
        {
            list5.Clear();//очистка списка точек

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

            Hashtable table = init_table();

            for (double x = A; x <= B-sh; x += sh)//вычисляем точки функции с указанным шагом
            {
                double q = (x - x0) / h;
                double k = 1;
                double value = (double)((Hashtable)table[0])[0];
                for (int i = 1; i <= (n - 1); i++)
                {
                    if (i % 2 == 1)
                        k *= (q - (int)(i / 2)) / i;
                    if (i % 2 == 0)
                        k *= (q + (int)(i / 2)) / i;
                    value += k * (double)((Hashtable)table[i])[(int)(-i / 2)];
                }

                double q1 = (x + Delt - x0) / h;
                double k1 = 1;
                double value1 = (double)((Hashtable)table[0])[0];
                for (int i = 1; i <= (n - 1); i++)
                {
                    if (i % 2 == 1)
                        k1 *= (q1 - (int)(i / 2)) / i;
                    if (i % 2 == 0)
                        k1 *= (q1 + (int)(i / 2)) / i;
                    value1 += k1 * (double)((Hashtable)table[i])[(int)(-i / 2)];
                }
                
                list5.Add(x, (1/Delt) * (value1-value));
            }

            LineItem myCurve5 = this.Graph.GraphPane.AddCurve("dPn(x)", list5, Color.Cyan, SymbolType.None);
            myCurve5.Line.IsSmooth = true;//сглаживание
            this.Graph.Invalidate();// Обновляем график
        }

        /*-------------------------------------график Rn(x)-----------------------------------*/
        void Rnx()
        {
            list6.Clear();//очистка списка точек

            Hashtable table = init_table();

            for (double x = A; x <= B; x += sh)//вычисляем точки функции с указанным шагом
            {
                double q = (x - x0) / h;
                double k = 1;
                double value = (double)((Hashtable)table[0])[0];
                for (int i = 1; i <= (n - 1); i++)
                {
                    if (i % 2 == 1)
                        k *= (q - (int)(i / 2)) / i;
                    if (i % 2 == 0)
                        k *= (q + (int)(i / 2)) / i;
                    value += k * (double)((Hashtable)table[i])[(int)(-i / 2)];
                }

                y = Math.Abs(F(x) - value);
                list6.Add(x, y);
            }

            LineItem myCurve6 = this.Graph.GraphPane.AddCurve("Rn(x)", list6, Color.Red, SymbolType.None);
            myCurve6.Line.IsSmooth = true;//сглаживание
            this.Graph.Invalidate();// Обновляем график
        }

        Hashtable init_table()
        {
            n = Convert.ToInt32(interpolation_points.Value); //число узлов интерполяции
            if (n % 2 != 1)
                n++;

            x0 = (A + B) / 2;

	        int k = (n - 1)/2;
	        h = (B - A) / (n - 1);
	        Hashtable table = new Hashtable();
	        table[0] = new Hashtable();

	        for(int i = -k; i <= k; i++)
	        {
		        ((Hashtable)table[0])[i] = F(A + (i + k) * h);
	        }

	        for(int i = 1; i <= n-1; i++)
	        {
		        table[i] = new Hashtable();
		        for(int j = -k; j <= k-i; j++)
		        {
                    ((Hashtable)table[i])[j] = (double)((Hashtable)table[i - 1])[j + 1] - (double)((Hashtable)table[i - 1])[j];
		        }
	        }
	        return table;
        }

        double Polinom(int n, double t)
        {
            double p = F((A+B)/2);
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
            f_x.Checked = false;
            Pn_x.Checked = false;
            Rn_x.Checked = false;
            df_x.Checked = false;
            dPn_x.Checked = false;
            radioButton1.Checked = true;

            this.Graph.GraphPane.CurveList.Clear();
            this.Graph.AxisChange();
            this.Graph.Invalidate();
        }
        
    }
}

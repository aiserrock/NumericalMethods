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
        double Alfa, Betta, Gamma, Delta, Epsilon;
        double y, DeltA, N, error = 0.00000001;


        PointPairList listABCD = new PointPairList();//список точек ограничений [A,B]x[C,D]
        PointPairList fx = new PointPairList();//f(x)
        PointPairList dfx = new PointPairList();//df(x)
        PointPairList Pnx = new PointPairList();//Pn(x)
        PointPairList dPnx = new PointPairList();//dPn(x)
        PointPairList Rnx = new PointPairList();//Rn(x)
        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList PnxPoints = new PointPairList();//точки пересечения
        PointPairList dPnxPoints = new PointPairList();//точки пересечения

        public Form1()
        {

            InitializeComponent();
            radio_1.Checked = true;

            N = Convert.ToDouble(this.numN.Value);
            // добавляем точку (0,0) для отображения осей в центре в этой точе
            list.Add(0, 0);

            // Создадим кривую
            LineItem krivaya = this.zedGraph.GraphPane.AddCurve("", list, Color.Black, SymbolType.None);



            zedGraph.Invalidate(); // Обновляем график
            zedGraph.AxisChange(); // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            pictureBox1.Image = Properties.Resources.alfa;
            pictureBox2.Image = Properties.Resources.betta;
            pictureBox3.Image = Properties.Resources.gamma;
            pictureBox4.Image = Properties.Resources.epsi;
            pictureBox5.Image = Properties.Resources.delta;
            pictureBox6.Image = Properties.Resources.del;


        }

        private void button_UP_Click(object sender, EventArgs e)
        {

            this.zedGraph.GraphPane.CurveList.Clear(); //очистка координатной плоскости
            listABCD.Clear();//очистка списка точек

            //ограничения
            A = Convert.ToDouble(this.windowA.Value);
            B = Convert.ToDouble(this.windowB.Value);
            C = Convert.ToDouble(this.windowC.Value);
            D = Convert.ToDouble(this.windowD.Value);

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
            //заполнение списка, границы
            listABCD.Add(A, D);
            listABCD.Add(B, D);
            listABCD.Add(B, C);
            listABCD.Add(A, C);
            listABCD.Add(A, D);

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = A;
            this.zedGraph.GraphPane.XAxis.Max = B;
            this.zedGraph.GraphPane.YAxis.Min = C;
            this.zedGraph.GraphPane.YAxis.Max = D;

            LineItem krivaya_1 = this.zedGraph.GraphPane.AddCurve("", listABCD, Color.LightBlue, SymbolType.None); // Создадим кривую
            krivaya_1.Line.Width = 5;//толщина линии в пикселях


            if (check_f.Checked)
                f();
            if (check_df.Checked)
                df();
            if (check_Pn.Checked)
                Pn();
            if (check_dPn.Checked)
                dPn();
            if (check_Rn.Checked)
                Rn();

            //// Обновляем график
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();

        }
        void f()
        {
            fx.Clear();//очистить график
            //определяем параметры
            Alfa = Convert.ToDouble(this.par_A.Value);
            Betta = Convert.ToDouble(this.par_B.Value);
            Gamma = Convert.ToDouble(this.par_G.Value);
            Delta = Convert.ToDouble(this.par_D.Value);
            Epsilon = Convert.ToDouble(this.par_E.Value);

            for (double x = A; x <= B; x +=(B - A)/1000)//вычисляем точки функции с указанным шагом
            {
                y = Alfa * (Math.Cos(Math.Tan(Betta * x))) + Gamma * (Math.Cos(Delta * x));
                fx.Add(x, y);//добавляем точки в список
            }

            LineItem krivaya_fx = this.zedGraph.GraphPane.AddCurve("f(x)", fx, Color.Blue, SymbolType.None);//рисуем функцию

            krivaya_fx.Line.IsSmooth = true;//сглаживание графика

            krivaya_fx.Line.Width = 2;// толщина линии 2 пикселя

        }

        void df()
        {
            dfx.Clear();//очистить список
            //определяем параметры

            Alfa = Convert.ToDouble(this.par_A.Value);
            Betta = Convert.ToDouble(this.par_B.Value);
            Gamma = Convert.ToDouble(this.par_G.Value);
            Delta = Convert.ToDouble(this.par_D.Value);
            Epsilon = Convert.ToDouble(this.par_E.Value);

            if (radio_1.Checked)
                DeltA = 1;
            if (radio_01.Checked)
                DeltA = 0.1;
            if (radio_001.Checked)
                DeltA = 0.01;
            if (radio_0001.Checked)
                DeltA = 0.001;
            if (radio_00001.Checked)
                DeltA = 0.0001;

            for (double x = A; x <= B; x += (B-A)/1000)//вычисляем точки функции с указанным шагом
            {
                y = ((Alfa * (Math.Sin(Math.Tan(Betta / ((x + DeltA) - Gamma)))) + Delta * (Math.Cos(Epsilon * (x + DeltA)))) - 
                    (Alfa * (Math.Sin(Math.Tan(Betta / (x - Gamma)))) + Delta * (Math.Cos(Epsilon * x)))) / DeltA;
                dfx.Add(x, y);//добавляем точки в список
            }
            LineItem krivaya_dfx = this.zedGraph.GraphPane.AddCurve("df(x)", dfx, Color.Red, SymbolType.None);//рисуем функцию

            krivaya_dfx.Line.IsSmooth = true;//сглаживание графика

            krivaya_dfx.Line.Width = 2;// толщина линии 2 пикселя
        }

        void Pn()
        {
            PnxPoints.Clear();
            Pnx.Clear();//очистить график
            N = Convert.ToDouble(this.numN.Value);
            double a = Convert.ToDouble(A);
            double b = Convert.ToDouble(B);
            Int64 n = Convert.ToInt64(this.numN.Value);
            double n_H = Convert.ToDouble(N);
            //определяем параметры
            Alfa = Convert.ToDouble(this.par_A.Value);
            Betta = Convert.ToDouble(this.par_B.Value);
            Gamma = Convert.ToDouble(this.par_G.Value);
            Delta = Convert.ToDouble(this.par_D.Value);
            Epsilon = Convert.ToDouble(this.par_E.Value);

            double h = (B - A) / (n - 1);
            double[][] konRazn = new double[n][];
            for (int i = 0; i < n; i++)
            {
                konRazn[i] = new double[n - i];
            }
            //заполнение x и y
            for (int i = 0; i < n; i++)
            {
                double x_AHI = (A + h * i);
            
                if (Math.Abs(x_AHI - Gamma) <= error) konRazn[i][0] = 0.0;
                else if (Math.Abs(Math.Abs(Betta / (x_AHI - Gamma)) % (Math.PI / 2)) <= error) konRazn[i][0] = 0.0;
                else konRazn[i][0] = Alfa * (Math.Cos(Math.Tan(Betta * x_AHI))) + Gamma * (Math.Cos(Delta * x_AHI));
            
                PnxPoints.Add(x_AHI, konRazn[i][0]);
            }
            for (int j = 1; j < n; j++)
                for (int i = 0; i < n - j; i++)
                    konRazn[i][j] = konRazn[i + 1][j - 1] - konRazn[i][j - 1];

            for (double x = A; x <= B; x+=(B-A)/10)
            {
                y = POLINOM(x, konRazn, n, h);

                if (Math.Abs(y) >= 10000000)
                    y = 1000000;

                Pnx.Add(x, y);
            }

            LineItem krivaya_Pnx = this.zedGraph.GraphPane.AddCurve("Pn(x)", Pnx, Color.Red, SymbolType.None);//рисуем функцию
            LineItem tochki_Pnx = this.zedGraph.GraphPane.AddCurve("", PnxPoints, Color.BlueViolet, SymbolType.Circle);
            tochki_Pnx.Symbol.Fill.Color = Color.Blue;
            tochki_Pnx.Symbol.Fill.Type = FillType.Solid;
            tochki_Pnx.Symbol.Size = 4;
            tochki_Pnx.Line.IsVisible = false;
            krivaya_Pnx.Line.IsSmooth = true;//сглаживание графика
            krivaya_Pnx.Line.Width = 2;// толщина линии 2 пикселя
        }

        double POLINOM(double x, double[][]konRazn, Int64 n, double h)
        {
            double res = 0;
            double x0 = A + (B - A) / 2;
            double q = (x - x0) / h;

            double chislitel = 1; int idx;

            if (n % 2 == 0)
            {
                res += (konRazn[0][n / 2 - 1] + konRazn[0][n / 2]) / 2;
            }
            else
            {
                res += konRazn[0][n / 2];
            }

            for (int i = 1; i < n / 2; i++)
            {
                chislitel *= (Math.Pow(q, 2) - Math.Pow(i - 1, 2));

                if(n % 2 == 0)
                {
                    chislitel /= 2 * i - 1; idx = 2 * i - 1;
                    res += chislitel * (konRazn[idx][konRazn[idx].Length / 2]);

                    chislitel /= 2 * i; idx = 2 * i;
                    res += chislitel * ((konRazn[idx][konRazn[idx].Length / 2 - 1] + konRazn[idx][konRazn[idx].Length / 2]) / 2);
                }
                else
                {
                    chislitel /= 2 * i - 1; idx = 2 * i - 1;
                    res += chislitel * ((konRazn[idx][konRazn[idx].Length / 2 - 1] + konRazn[idx][konRazn[idx].Length / 2]) / 2);

                    chislitel /= 2 * i; idx = 2 * i;
                    res += chislitel * (konRazn[idx][konRazn[idx].Length / 2]);
                }
            }
                
            return res;
        }

        void dPn()
        {
            dPnxPoints.Clear();
            dPnx.Clear();//очистить график
            N = Convert.ToDouble(this.numN.Value);
            double a = Convert.ToDouble(A);
            double b = Convert.ToDouble(B);
            Int64 n = Convert.ToInt64(this.numN.Value);
            double n_H = Convert.ToDouble(N);
            //определяем параметры
            Alfa = Convert.ToDouble(this.par_A.Value);
            Betta = Convert.ToDouble(this.par_B.Value);
            Gamma = Convert.ToDouble(this.par_G.Value);
            Delta = Convert.ToDouble(this.par_D.Value);
            Epsilon = Convert.ToDouble(this.par_E.Value);

            //дельта
            if (radio_1.Checked)
                DeltA = 1;
            if (radio_01.Checked)
                DeltA = 0.1;
            if (radio_001.Checked)
                DeltA = 0.01;
            if (radio_0001.Checked)
                DeltA = 0.001;
            if (radio_00001.Checked)
                DeltA = 0.0001;

            double h = (B - A) / (n - 1);
            double[][] konRazn = new double[n][];
            for (int i = 0; i < n; i++)
            {
                konRazn[i] = new double[n - i];
            }
            //заполнение x и y
            for (int i = 0; i < n; i++)
            {
                double x_AHI = (A + h * i);

                if (Math.Abs(x_AHI - Gamma) <= error)
                {
                    if (Math.Abs((x_AHI + DeltA) - Gamma) <= error)
                    {
                        konRazn[i][0] = 0.0;
                    }
                    else
                    {
                        if (Math.Abs(Math.Abs(Betta / ((x_AHI + DeltA) - Gamma)) % (Math.PI / 2)) <= error)
                        {
                            konRazn[i][0] = 0.0;
                        }
                        else
                        {
                            konRazn[i][0] = 0.0 - Alfa * (Math.Sin(Math.Tan(Betta / ((x_AHI + DeltA) - Gamma)))) + Delta * (Math.Cos(Epsilon * (x_AHI + DeltA)));
                        }
                    }
                }
                else
                {
                    if (Math.Abs((x_AHI + DeltA) - Gamma) <= error)
                    {
                        if (Math.Abs(Math.Abs(Betta / (x_AHI - Gamma)) % (Math.PI / 2)) <= error)
                        {
                            konRazn[i][0] = 0.0;
                        }
                        else
                        {
                            konRazn[i][0] = Alfa * (Math.Sin(Math.Tan(Betta / (x_AHI - Gamma)))) + Delta * (Math.Cos(Epsilon * x_AHI));
                        }
                    }
                    else
                    {
                        if (Math.Abs(Math.Abs(Betta / (x_AHI - Gamma)) % (Math.PI / 2)) <= error)
                        {
                            if (Math.Abs(Math.Abs(Betta / ((x_AHI + DeltA) - Gamma)) % (Math.PI / 2)) <= error)
                            {
                                konRazn[i][0] = 0.0;
                            }
                            else
                            {
                                konRazn[i][0] = 0.0 - Alfa * (Math.Sin(Math.Tan(Betta / ((x_AHI + DeltA) - Gamma)))) + Delta * (Math.Cos(Epsilon * (x_AHI + DeltA)));
                            }
                        }
                        else
                        {
                            if (Math.Abs(Math.Abs(Betta / ((x_AHI + DeltA) - Gamma)) % (Math.PI / 2)) <= error)
                            {
                                konRazn[i][0] = Alfa * (Math.Sin(Math.Tan(Betta / (x_AHI - Gamma)))) + Delta * (Math.Cos(Epsilon * x_AHI));
                            }
                            else
                            {
                                konRazn[i][0] = Alfa * (Math.Sin(Math.Tan(Betta / (x_AHI - Gamma)))) + Delta * (Math.Cos(Epsilon * x_AHI)) - Alfa * (Math.Sin(Math.Tan(Betta / ((x_AHI + DeltA) - Gamma)))) + Delta * (Math.Cos(Epsilon * (x_AHI + DeltA)));
                            }
                        }
                    }
                }
                
                dPnxPoints.Add(x_AHI + DeltA, konRazn[i][0]);
            }
            for (int j = 1; j < n; j++)
                for (int i = 0; i < n - j; i++)
                    konRazn[i][j] = konRazn[i + 1][j - 1] - konRazn[i][j - 1];

            for (double x = A; x <= B; x += (B - A) / 1000)
            {
                y = POLINOM(x+DeltA, konRazn, n, h) - POLINOM(x, konRazn, n, h);

                //if (Math.Abs(y) >= 10000000)
                    y = 1000000;

                dPnx.Add(x, y);
            }

            LineItem krivaya_dPnx = this.zedGraph.GraphPane.AddCurve("Pn(x)", dPnx, Color.BlueViolet, SymbolType.Plus);//рисуем функцию
            LineItem tochki_dPnx = this.zedGraph.GraphPane.AddCurve("", dPnxPoints, Color.Green, SymbolType.Square);
            tochki_dPnx.Symbol.Fill.Color = Color.Blue;
            tochki_dPnx.Symbol.Fill.Type = FillType.Solid;
            tochki_dPnx.Symbol.Size = 4;
            tochki_dPnx.Line.IsVisible = false;
            //krivaya_dPnx.Line.IsVisible = true;
            krivaya_dPnx.Line.IsSmooth = true;//сглаживание графика
            krivaya_dPnx.Line.Width = 2;// толщина линии 2 пикселя

        }

        void Rn()
        {
            Rnx.Clear();//очистить график
            N = Convert.ToDouble(this.numN.Value);
            int a = Convert.ToInt32(A);
            int b = Convert.ToInt32(B);
            int n = Convert.ToInt32(N);
            //определяем параметры
            Alfa = Convert.ToDouble(this.par_A.Value);
            Betta = Convert.ToDouble(this.par_B.Value);
            Gamma = Convert.ToDouble(this.par_G.Value);
            Delta = Convert.ToDouble(this.par_D.Value);
            Epsilon = Convert.ToDouble(this.par_E.Value);

            double h = (b - a) / n;
            h = Math.Round(h, 2);
            double chislo = a - h;
            double[][] konRazn = new double[n + 1][];
            int cur = n + 2;
            for (int m = 0; m < n + 1; m++)
            {
                konRazn[m] = new double[cur];
                cur--;
            }

            for (int i = 0; i < n + 1; i++)
            {
                chislo = chislo + h;
                y = Alfa * (Math.Sin(Math.Tan(Betta / (chislo - Gamma)))) + Delta * (Math.Cos(Epsilon * chislo));
                chislo = Math.Round(chislo, 2);
                y = Math.Round(y, 2);
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        konRazn[i][j] = chislo;
                    }
                    else
                    {
                        konRazn[i][j] = y;
                    }
                }
            }
            int k = n;
            //зубчатый массив
            for (int j = 2; j < n + 2; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    konRazn[i][j] = konRazn[i + 1][j - 1] - konRazn[i][j - 1];
                }
                k--;
            }

            double fact = 1; //факториал

            double x_x = 1;
            for (int col = 0; col < n + 1; col++)
            {
                //полином для определенного числа
                double res = 0;
                for (int i = 0; i < n + 1; i++)
                {
                    if (i == 0)
                        res = konRazn[i][1];
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            x_x *= konRazn[col][0] - konRazn[j][0];
                        }
                        res += (konRazn[0][i + 1] / (fact * Math.Pow(h, i))) * x_x;
                        res = Math.Round(res, 2);
                        fact *= i;
                        x_x = 1;
                    }
                }
                res = Math.Abs((Alfa * (Math.Sin(Math.Tan(Betta / (konRazn[col][0] - Gamma)))) + Delta * (Math.Cos(Epsilon * konRazn[col][0]))) - res);
                Rnx.Add(konRazn[col][0], res);//добавляем точки в список 
            }
            LineItem krivaya_Rnx = this.zedGraph.GraphPane.AddCurve("Rn(x)", Rnx, Color.Green, SymbolType.None);//рисуем функцию
            krivaya_Rnx.Line.IsSmooth = true;//сглаживание графика
            krivaya_Rnx.Line.Width = 2;// толщина линии 2 пикселя

        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            windowA.Value = -10;
            windowB.Value = 10;
            windowC.Value = -10;
            windowD.Value = 10;

            par_A.Value = 1;
            par_B.Value = 1;
            par_D.Value = 1;
            par_E.Value = 1;
            par_G.Value = 1;

            check_f.Checked = false;
            check_df.Checked = false;
            check_Pn.Checked = false;
            check_dPn.Checked = false;
            check_Rn.Checked = false;

            radio_1.Checked = true;

            numN.Value = 1;

            //очистка графиков
            this.zedGraph.GraphPane.CurveList.Clear();

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = -10;
            this.zedGraph.GraphPane.XAxis.Max = 10;
            this.zedGraph.GraphPane.YAxis.Min = -10;
            this.zedGraph.GraphPane.YAxis.Max = 10;

            //обновляем
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

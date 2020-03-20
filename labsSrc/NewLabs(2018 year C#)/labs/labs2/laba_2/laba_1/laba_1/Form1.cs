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
        double a, b, sh, n_max;
        double y, DeltA, N, error = 0.00000001, n;

        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        PointPairList list1 = new PointPairList();

        public Form1()
        {

            InitializeComponent();

            numeric_a.Value = -0.5m;
            numeric_b.Value = 0.5m;

            par_A.Enabled = false;
            rad_A.Checked = true;
            radio_1.Checked = true;

            //N = Convert.ToDouble(this.numN.Value);
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
            list.Clear();//очистка списка точек
            list1.Clear();//очистка списка точек

            //ограничения
            A = Convert.ToDouble(this.windowA.Value);
            B = Convert.ToDouble(this.windowB.Value);
            C = Convert.ToDouble(this.windowC.Value);
            D = Convert.ToDouble(this.windowD.Value);

            a = (double)numeric_a.Value;
            b = (double)numeric_b.Value;
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
            //заполнение списка, границы
            list.Add(A, D);
            list.Add(B, D);
            list.Add(B, C);
            list.Add(A, C);
            list.Add(A, D);

            if (a >= b)
            {
                MessageBox.Show("Значение a не может быть больше (либо равно) b");
                a = A * 0.5;
                numeric_a.Value = (decimal)a;
                b = B * 0.5;
                numeric_b.Value = (decimal)b;
            }

            sh = (Math.Abs(A) + Math.Abs(B)) / 600;

            Alfa = (double)par_A.Value;
            Betta = (double)par_B.Value;
            Gamma = (double)par_G.Value;
            Delta = (double)par_D.Value;
            Epsilon = (double)par_E.Value;

            //интервалы для осей
            this.zedGraph.GraphPane.XAxis.Min = A;
            this.zedGraph.GraphPane.XAxis.Max = B;
            this.zedGraph.GraphPane.YAxis.Min = C;
            this.zedGraph.GraphPane.YAxis.Max = D;

            LineItem krivaya_1 = this.zedGraph.GraphPane.AddCurve("", list, Color.LightBlue, SymbolType.None); // Создадим кривую
            krivaya_1.Line.Width = 5;//толщина линии в пикселях


            if (radio_1.Checked)
                DeltA = 1.0;
            if (radio_01.Checked)
                DeltA = 0.1;
            if (radio_001.Checked)
                DeltA = 0.01;
            if (radio_0001.Checked)
                DeltA = 0.001;
            if (radio_00001.Checked)
                DeltA = 0.0001;

            //// Обновляем график
            this.zedGraph.AxisChange();
            this.zedGraph.Invalidate();

            method_of_rectangles();
        }

        void method_of_rectangles()//рисует интегральную кривую и выводит n_max
        {
            list1.Clear();
            n_max = 0;

            for (double parametr = A; parametr <= B; parametr += sh)
            {
                list1.Add(parametr, Runge(parametr));
            }

            maxN.Text = Convert.ToString(n_max);

            LineItem myCurve1 = this.zedGraph.GraphPane.AddCurve("", list1, Color.Red, SymbolType.None); // Создадим кривую

            this.zedGraph.AxisChange();

            zedGraph.Invalidate(); // Обновляем гранфик
        }

        double Runge(double p)
        {
            double n_count = n;
            double Int2n = Integral(p, n_count * 2), Intn = Integral(p, n_count);

            while (DeltA < (1.0 / 3.0) * Math.Abs(Int2n - Intn))
            {
                n_count = n_count * 2;
                Int2n = Integral(p, n_count * 2);
                Intn = Integral(p, n_count);
            }

            if (n_count > n_max)
                n_max = n_count;

            return Int2n;
        }

        double proverka(double yy, double gam, double bet)
        {
            double cur1;
            if (Math.Abs(yy - gam) <= error)
            {
                cur1 = 0.0;
                return cur1;
            }
            else
            {
                if (Math.Abs(Math.Abs(bet / (yy - gam)) % (Math.PI / 2)) <= error)
                {
                    cur1 = 0.0;
                    return cur1;
                }

                else
                {
                    cur1 = 1.1;
                    return cur1;
                }
            }
        }
        /* проверка
        if (Math.Abs(x_AHI - Gamma) <= error)
                {
                    konRazn[i][0] = 0.0;
                }
                else if(Math.Abs(Math.Abs(Betta / (x_AHI - Gamma)) % (Math.PI / 2)) <= error) konRazn[i][0] = 0.0;
                else konRazn[i][0] = Alfa * (Math.Sin(Math.Tan(Betta / (x_AHI - Gamma)))) + Delta * (Math.Cos(Epsilon * x_AHI));
        
         
         for (double x = A; x <= B; x += (B-A)/1000)//вычисляем точки функции с указанным шагом
            {
                y = ((Alfa * (Math.Sin(Math.Tan(Betta / ((x + DeltA) - Gamma)))) + Delta * (Math.Cos(Epsilon * (x + DeltA)))) - (Alfa * (Math.Sin(Math.Tan(Betta / (x - Gamma)))) + Delta * (Math.Cos(Epsilon * x)))) / DeltA;
                dfx.Add(x, y);//добавляем точки в список
            }
         
         */
        double Integral(double p1, double tmp)
        {
            double h = (b-a) / tmp;
            double InSum = 0, y = 0;
            double cur;

            if (rad_A.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    cur = proverka(y, Gamma, Betta);
                    if (cur == 0.0)
                    {
                        InSum += 0.0;
                    }
                    if (cur == 1.1)
                    {
                        InSum += p1 * (Math.Sin(Math.Tan(Betta / (y - Gamma)))) + Delta * (Math.Cos(Epsilon * y));
                    }
                }
                return h * InSum;
            }

            if (rad_B.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    cur = proverka(y, Gamma, p1);
                    if (cur == 0.0)
                    {
                        InSum += 0.0;
                    }
                    if (cur == 1.1)
                    {
                        InSum += Alfa * (Math.Sin(Math.Tan(p1 / (y - Gamma)))) + Delta * (Math.Cos(Epsilon * y));
                    }
                }
                return h * InSum;
            }

            if (rad_D.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    cur = proverka(y, Gamma, Betta);
                    if (cur == 0.0)
                    {
                        InSum += 0.0;
                    }
                    if (cur == 1.1)
                    {
                        InSum += Alfa * (Math.Sin(Math.Tan(Betta / (y - Gamma)))) + p1 * (Math.Cos(Epsilon * y));
                    }
                }
                return h * InSum;
            }

            if (rad_G.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    cur = proverka(y, p1, Betta);
                    if (cur == 0.0)
                    {
                        InSum += 0.0;
                    }
                    if (cur == 1.1)
                    {
                        InSum += Alfa * (Math.Sin(Math.Tan(Betta / (y - p1)))) + Delta * (Math.Cos(Epsilon * y));
                    }
                }
                return h * InSum;
            }

            if (rad_E.Checked)
            {
                for (double x = a; x < b; x += h)
                {
                    y = (x + (x + h)) / 2.0;
                    cur = proverka(y, Gamma, Betta);
                    if (cur == 0.0)
                    {
                        InSum += 0.0;
                    }
                    if (cur == 1.1)
                    {
                        InSum += Alfa * (Math.Sin(Math.Tan(Betta / (y - Gamma)))) + Delta * (Math.Cos(p1 * y));
                    }
                }
                return h * InSum;
            }

            return 0;
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

            numeric_a.Value = -0.5m;
            numeric_b.Value = 0.5m;

            par_A.Enabled = false;
            rad_A.Checked = true;
            radio_1.Checked = true;

            par_A.Value = 0;
            par_B.Value = 0;
            par_D.Value = 0;
            par_E.Value = 0;
            par_G.Value = 0;

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

        private void rad_A_CheckedChanged(object sender, EventArgs e)
        {
            par_A.Enabled = false;
            par_B.Enabled = true;
            par_G.Enabled = true;
            par_D.Enabled = true;
            par_E.Enabled = true;
        }

        private void rad_G_CheckedChanged(object sender, EventArgs e)
        {
            par_A.Enabled = true;
            par_B.Enabled = true;
            par_G.Enabled = false;
            par_D.Enabled = true;
            par_E.Enabled = true;
        }

        private void rad_D_CheckedChanged(object sender, EventArgs e)
        {
            par_A.Enabled = true;
            par_B.Enabled = true;
            par_G.Enabled = true;
            par_D.Enabled = false;
            par_E.Enabled = true;
        }

        private void rad_B_CheckedChanged(object sender, EventArgs e)
        {
            par_A.Enabled = true;
            par_B.Enabled = false;
            par_G.Enabled = true;
            par_D.Enabled = true;
            par_E.Enabled = true;
        }

        private void rad_E_CheckedChanged(object sender, EventArgs e)
        {
            par_A.Enabled = true;
            par_B.Enabled = true;
            par_G.Enabled = true;
            par_D.Enabled = true;
            par_E.Enabled = false;
        }

    }
}

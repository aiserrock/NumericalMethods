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
        double A = -1, B = 1, C = -1, D = 1, Tau = 1, Alpha = 1, Beta = 1, Kappa = 1, Fi = 1, Gamma = 1, Epsilon = 1, Ro = 1, V = 1,Lambda = 1, x0, y0;
        int n = 50;

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

            radioButton1.Checked = true;

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
        }

        private void Build_up_Click(object sender, EventArgs e)
        {
            
            this.Graph.GraphPane.CurveList.Clear(); //очистка координатной плоскости

            A = (double)Par_A.Value; //считывание ограничений
            B = (double)Par_B.Value;
            C = (double)Par_C.Value;
            D = (double)Par_D.Value;

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

            try 
            {
                Alpha = Convert.ToDouble(textBoxAlpha.Text);
                Beta = Convert.ToDouble(textBoxBeta.Text);
                Fi = Convert.ToDouble(textBoxFi.Text);
                Gamma = Convert.ToDouble(textBoxGamma.Text);
                Epsilon = Convert.ToDouble(textBoxEpsilon.Text);
                V = Convert.ToDouble(textBoxV.Text);
                Lambda = Convert.ToDouble(textBoxLambda.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод параметра(-ов)");
                return;
            }

            if (Alpha > 100)
            {
                Alpha = 100;
                textBoxAlpha.Text = "100";
            }
            if (Alpha < -100)
            {
                Alpha = -100;
                textBoxAlpha.Text = "-100";
            }
            if (Beta > 100)
            {
                Beta = 100;
                textBoxBeta.Text = "100";
            }
            if (Beta < -100)
            {
                Beta = -100;
                textBoxBeta.Text = "-100";
            }
            if (Kappa > 100)
            {
                Kappa = 100;
            }
            if (Kappa < -100)
            {
                Kappa = -100;
            }
            if (Fi > 100)
            {
                Fi = 100;
                textBoxFi.Text = "100";
            }
            if (Fi < -100)
            {
                Fi = -100;
                textBoxFi.Text = "-100";
            }
            if (Gamma > 100)
            {
                Gamma = 100;
                textBoxGamma.Text = "100";
            }
            if (Gamma < -100)
            {
                Gamma = -100;
                textBoxGamma.Text = "-100";
            }
            if (Epsilon > 100)
            {
                Epsilon = 100;
                textBoxEpsilon.Text = "100";
            }
            if (Epsilon < -100)
            {
                Epsilon = -100;
                textBoxEpsilon.Text = "-100";
            }
            if (Ro > 100)
            {
                Ro = 100;
            }
            if (Ro < -100)
            {
                Ro = -100;
            }
            if (V > 100)
            {
                V = 100;
                textBoxV.Text = "100";
            }
            if (V < -100)
            {
                V = -100;
                textBoxV.Text = "-100";
            }
            if (Lambda > 100)
            {
                Lambda = 100;
                textBoxLambda.Text = "100";
            }
            if (Lambda < -100)
            {
                Lambda = -100;
                textBoxLambda.Text = "-100";
            }

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
                Tau = 1.0;
            if (radioButton2.Checked)
                Tau = 0.1;
            if (radioButton3.Checked)
                Tau = 0.01;
            if (radioButton4.Checked)
                Tau = 0.001;
            if (radioButton5.Checked)
                Tau = 0.0001;
        }

        private void Clear_Click(object sender, EventArgs e)//очистка и сброс параметров по умолчанию
        {
            Par_A.Value = -1;
            Par_B.Value = 1;
            Par_C.Value = -1;
            Par_D.Value = 1;
            textBoxAlpha.Text ="1";
            textBoxBeta.Text= "1";
            textBoxFi.Text="1";
            textBoxGamma.Text="1";
            textBoxEpsilon.Text="1";
            textBoxV.Text="1";
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

        void method_of_EulerX()//рисует интегральную кривую и выводит n_max
        {
            PointPairList list1 = new PointPairList();

            double x = x0, y = y0, x1;

            list1.Add(x0, y0);

            for (int par = 0; par < n; par++)
            {
                x1=x;
                //x = x + Tau * (Beta * y + Epsilon * x + Psi);
                //y = y + Tau * (Alpha * x1 + Delta * y + Fi *Math.Exp(y));
                x = Tau * (Math.Exp(Epsilon * x + Lambda * y)) + Alpha * Math.Cos(Beta * x) + Fi;
                y = Tau * Math.Sqrt(Gamma + V * x) + Epsilon * Math.Exp(y) + Fi;
                list1.Add(x, y);
            }

            PointPairList list2 = new PointPairList();

            list2.Add(x0, y0);

            x = x0; y = y0;

            for (int par = 0; par < n; par++)
            {
                x1 = x;
                //x = x - Tau * (Beta * y + Epsilon * x + Psi);
                //y = y - Tau * (Alpha * x1 + Delta * y + Fi * Math.Exp(y));
                x = (Math.Exp(Epsilon*x+Lambda*y))+Alpha*Math.Cos(Beta*x)+Fi;
                y = Math.Sqrt(Gamma+V*x)+Epsilon*Math.Exp(y)+Fi;
                list2.Add(x, y);
            }

            Random rnd = new Random();

            Color curveColor = _colors[rnd.Next(_colors.Length)];

            Graph.GraphPane.AddCurve("", list1, curveColor, SymbolType.None); // Создадим кривую
            Graph.GraphPane.AddCurve("", list2, curveColor, SymbolType.None); // Создадим кривую

            Graph.AxisChange();

            Graph.Invalidate(); // Обновляем график
        }


        private void Graph_MouseClick(object sender, MouseEventArgs e)//считавание координат клика мышкой
        {
            // Пересчитываем пиксели в координаты на графике
            // У ZedGraph есть несколько перегруженных методов ReverseTransform.
            Graph.GraphPane.ReverseTransform(e.Location, out x0, out y0);
            
            method_of_EulerX();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }

}

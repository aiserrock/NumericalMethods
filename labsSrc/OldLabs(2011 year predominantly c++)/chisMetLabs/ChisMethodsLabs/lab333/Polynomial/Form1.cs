using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ZedGraph;

namespace Polynomial
{
    public partial class Form1 : Form
    {
        private const int count = 800;
        double x0, y0;

        PointPairList list = new PointPairList();// Создадим списки точек из которых будут формироваться графики
        Color[] _colors = new Color[] 
        {
            Color.Black, 
            Color.Blue, 
            Color.Brown,
            Color.Gray,
            Color.Green,
            Color.Indigo,
            Color.Orange,
            Color.Red,
        };
        public Form1()
        {
            InitializeComponent();
            Draw_Axis();
        }
        private void Draw_Axis()
        {
            GraphPane pane = zedGraph.GraphPane;
            // Ось X будет пересекаться с осью Y на уровне Y = 0
            pane.XAxis.Cross = 0.0;

            // Ось Y будет пересекаться с осью X на уровне X = 0
            pane.YAxis.Cross = 0.0;

            // Отключим отображение первых и последних меток по осям
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.XAxis.Scale.IsSkipCrossLabel = true;

            // Отключим отображение первых и последних меток по осям
            pane.YAxis.Scale.IsSkipFirstLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;

            // Спрячем заголовки осей
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;

            pane.XAxis.Scale.Min = (double)A.Value;
            pane.XAxis.Scale.Max = (double)B.Value;

            pane.YAxis.Scale.Min = (double)C.Value;
            pane.YAxis.Scale.Max = (double)D.Value;

            // Включим отображение сетки
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Рисование одной кривой
        /// </summary>
        /// <param name="points">Точки для кривой</param>
        /// <param name="color">Цвет для кривой</param>
        private void DrawGraph(PointPairList points, Color color, string name)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            // Создадим кривую, в названии которой содержится 
            // количество фактически отображаемых точек
            pane.AddCurve(name,
                points,
                color,
                SymbolType.None).Line.IsSmooth = true;
            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        enum Parametr 
        {
            epsilon,
            alfa,
            betta,
            gamma
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            max_n.Text = "";
            GraphPane pane = zedGraph.GraphPane;

            // Если есть что удалять
            if (pane.CurveList.Count > 0)
            {
                pane.CurveList.Clear();
            }

            Draw_Axis();

            // Обновим график
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void zedGraph_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            GraphPane pane = sender.GraphPane;

            if (pane.XAxis.Scale.Min <= (double)A.Value)
            {
                pane.XAxis.Scale.Min = (double)A.Value;
            }

            if (pane.XAxis.Scale.Max >= (double)B.Value)
            {
                pane.XAxis.Scale.Max = (double)B.Value;
            }

            if (pane.YAxis.Scale.Min <= (double)C.Value)
            {
                pane.YAxis.Scale.Min = (double)C.Value;
            }

            if (pane.YAxis.Scale.Max >= (double)D.Value)
            {
                pane.YAxis.Scale.Max = (double)D.Value;
            }
        }


        void method_of_EulerX()//рисует интегральную кривую и выводит n_max
        {
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            double x = x0, y = y0;
            double x_minus = x0, y_minus = y0;

            list1.Add(x0, y0);
            list2.Add(x0, y0);

            double Alpha = (double)alfa.Value;
            double Beta =  (double)beta.Value;
            double Epsilon = (double)epsilon.Value;
            double Lambda = (double)lambda.Value;
            double Fi = (double)fi.Value;
            double Psi = (double)psi.Value;
            double Gamma = (double)gamma.Value;
            double Nu = (double)nu.Value;

            for (int par = 0; par < n.Value; par++)
            {
                double x1 = x;
                x = x + (double)delta.Value * (Math.Pow(Math.E, (Epsilon * x + Lambda * y)) + Alpha * Math.Cos(Beta * x) + Fi);
                y = y + (double)delta.Value * (Math.Sqrt(Gamma + Nu * x1) + Epsilon * Math.Pow(Math.E, y) + Psi);
                list1.Add(x, y);

                double x1_minus = x_minus;

                x_minus = x_minus - (double)delta.Value * (Math.Pow(Math.E, (Epsilon * x_minus + Lambda * y_minus)) + Alpha * Math.Cos(Beta * x_minus) + Fi);
                y_minus = y_minus - (double)delta.Value * (Math.Sqrt(Gamma + Nu * x1_minus) + Epsilon * Math.Pow(Math.E, y_minus) + Psi);
                list2.Add(x_minus, y_minus);
            }


            //for (int par = 0; par < n.Value; par++)
            //{
            //    double x1 = x;
            //    x = x - (double)delta.Value * (Math.Pow(Math.E, (Epsilon * x + Lambda * y)) + Alpha * Math.Cos(Beta * x) + Fi);
            //    y = y - (double)delta.Value * (Math.Sqrt(Gamma + Nu * x1) + Epsilon * Math.Pow(Math.E, y) + Psi);
            //    list2.Add(x, y);
            //}

            Random rnd = new Random();

            Color curveColor = _colors[rnd.Next(_colors.Length)];

            zedGraph.GraphPane.AddCurve("", list1, curveColor, SymbolType.None); // Создадим кривую
            zedGraph.GraphPane.AddCurve("", list2, curveColor, SymbolType.None); // Создадим кривую

            zedGraph.AxisChange();

            zedGraph.Invalidate(); // Обновляем график
        }

        private void zedGraph_MouseClick_1(object sender, MouseEventArgs e)
        {
            zedGraph.GraphPane.ReverseTransform(e.Location, out x0, out y0);

            method_of_EulerX();
        }  
    }
}

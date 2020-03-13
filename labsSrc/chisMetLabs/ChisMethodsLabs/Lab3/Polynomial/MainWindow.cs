using System;
using System.Drawing;
using System.Windows.Forms;

using ZedGraph;

namespace Polynomial
{
    public partial class MainWindow : Form
    {
        private double _x0, _y0;

        private double _alpha, _delta, _epsilon, _sigma, _ro, _lambda, _eta, _fi, _dr;

        private readonly Color[] _colors = {
            Color.Black, 
            Color.Blue, 
            Color.Brown,
            Color.Gray,
            Color.Green,
            Color.Indigo,
            Color.Orange,
            Color.Red,
        };

        public MainWindow()
        {
            InitializeComponent();
            SetupGraph();
        }

        private void SetupGraph()
        {
            var pane = zedGraph.GraphPane;

            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;

            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;

            pane.Title.Text = "График";

            pane.XAxis.Scale.IsSkipCrossLabel = true;
            pane.YAxis.Scale.IsSkipFirstLabel = true;

            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;

            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            
            UpdateGraph();
        }

        private void SetAxisValues()
        {
            var pane = zedGraph.GraphPane;
            pane.XAxis.Scale.Min = (double)numericA.Value;
            pane.XAxis.Scale.Max = (double)numericB.Value;

            pane.YAxis.Scale.Min = (double)numericC.Value;
            pane.YAxis.Scale.Max = (double)numericD.Value;
        }

        private void UpdateGraph()
        {
            SetAxisValues();
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            if (pane.CurveList.Count > 0)
            {
                pane.CurveList.Clear();
            }
            UpdateGraph();
        }

        private double Function1(double x, double y)
        {
            return _alpha * Math.Pow(x, 2) + _delta * y + _epsilon;
        }

        private double Function2(double x, double y)
        {
            return ((_sigma * x + _ro * y) * (_lambda * x + _eta * y + _fi));
        }

        private void GetFunctionParameters()
        {
            _alpha = (double) numericAlfa.Value;
            _delta = (double) numericDelta.Value;
            _epsilon = (double) numericEpsilon.Value;
            _lambda = (double) numericLambda.Value;
            _fi = (double) numericFi.Value;
            _sigma = (double) numericSigma.Value;
            _ro = (double) numericRo.Value;
            _eta = (double) numericEta.Value;
            _dr = (double) numericDR.Value;
        }

        private void MethodOfEuler()
        {
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            double x = _x0, y = _y0;
            double xMinus = _x0, yMinus = _y0;

            list1.Add(_x0, _y0);
            list2.Add(_x0, _y0);

            GetFunctionParameters();
            
            for (int i = 0; i < numericN.Value; i++)
            {
                double x1 = x;
                x += _dr * Function1(x, y);
                y += _dr * Function2(x1, y);
                list1.Add(x, y);

                double x1Minus = xMinus;
                xMinus -= _dr * Function2(xMinus, yMinus);
                yMinus -= _dr * Function2(x1Minus, yMinus);
                list2.Add(xMinus, yMinus);
            }

            Random random = new Random();

            Color curveColor = _colors[random.Next(_colors.Length)];

            zedGraph.GraphPane.AddCurve("", list1, curveColor, SymbolType.None);
            zedGraph.GraphPane.AddCurve("", list2, curveColor, SymbolType.None);

            UpdateGraph();
        }

        private void ZedGraphMouseClick(object sender, MouseEventArgs e)
        {
            zedGraph.GraphPane.ReverseTransform(e.Location, out _x0, out _y0);
            MethodOfEuler();
        }
    }
}

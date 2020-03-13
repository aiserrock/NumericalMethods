using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace ODUSystems
{
    public partial class MainForm : Form
    {
        public readonly GraphPane pane;
        private double _alpha, _beta, _gama, _delta, _phi, _a, _b, _c, _d, _tau;
        private int _n;
        public MainForm()
        {
            InitializeComponent();
            pane = graph.GraphPane;
            GraphView("X", "Y", "");
            SetValues();
        }

        void zedGraph_CursorChanged(object sender, EventArgs e)
        {
            if (!graph.Capture)
            {
                graph.Cursor = Cursors.Arrow;
            }
        }

        void zedGraph_ContextMenuBuilder(ZedGraphControl sender,
        ContextMenuStrip menuStrip,
        Point mousePt,
        ZedGraphControl.ContextMenuObjectState objState)
        {
            menuStrip.Items[1].Text = "Сохранить как изоображение…";
            menuStrip.Items[3].Text = "Печать…";
            menuStrip.Items[4].Text = "Показывать значения в точках…";
            menuStrip.Items[6].Text = "Установить масштаб в исходное состояние";
            menuStrip.Items[7].Text = "Установить масштаб по умолчанию…";

            for (int i = 0; i < 2; i++)
            {
                menuStrip.Items.RemoveAt(i);
            }
        }

        public void GraphView(string xAxisText, string yAxisText, string titleText)
        {
            graph.CursorChanged += new EventHandler(zedGraph_CursorChanged);
            graph.ContextMenuBuilder +=
            new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
            graph.IsEnableZoom = false;

            pane.CurveList.Clear();
            pane.XAxis.Title.Text = xAxisText;
            pane.YAxis.Title.Text = yAxisText;
            pane.Title.Text = titleText;

            pane.XAxis.Scale.FontSpec.Size = 10;
            pane.YAxis.Scale.FontSpec.Size = 10;
            pane.XAxis.Scale.MajorStep = 10;
            pane.XAxis.Scale.MinorStep = 1;
            pane.YAxis.Scale.MajorStep = 10;
            pane.YAxis.Scale.MinorStep = 1;
            pane.YAxis.MajorGrid.IsZeroLine = false;
        }

        public void CLearPane()
        {
            graph.GraphPane.CurveList.Clear();
            graph.GraphPane.GraphObjList.Clear();
            graph.Invalidate();
        }

        public void ABCDWindow(double a, double b, double c, double d)
        {
            pane.XAxis.Scale.Min = a;
            pane.XAxis.Scale.Max = b;

            pane.YAxis.Scale.Min = c;
            pane.YAxis.Scale.Max = d;
        }

        public void DrawPoints(PointPairList list, Color color)
        {
            LineItem nLine = pane.AddCurve("", list, color, SymbolType.Diamond);
            nLine.Symbol.Size = 1;
            nLine.Symbol.Fill.Type = FillType.Solid;
            nLine.Symbol.Fill.Color = color;
            nLine.Line.IsVisible = false;
        }

        public void DrawLine(PointPairList list, Color color)
        {
            var secondLine = pane.AddCurve("", list, color, SymbolType.None);
            secondLine.Line.Width = 2.0F;
            secondLine.Line.IsSmooth = true;
        }

        private double GetX(double x, double y, double alpha, double delta, double phi, double gama, double beta)
        {
            return ( beta * (alpha * x + gama) * ( delta * y + phi) );
            //return y;
        }

        private double GetY(double x, double y, double delta, double phi)
        {
            return (delta * Math.Pow(x, 2) + phi * Math.Pow(y, 2) );
           //return -x;
        }

        private void GetValues()
        {
            try
            {
                _alpha = double.Parse(alphaTextBox.Text);
                _beta = double.Parse(betaTextBox.Text);
                _gama = double.Parse(gamaTextBox.Text);
                _delta = double.Parse(etaTextBox.Text);
                _phi = double.Parse(phiTextBox.Text);
                _a = double.Parse(aTextBox.Text);
                _b = double.Parse(bTextBox.Text);
                _c = double.Parse(cTextBox.Text);
                _d = double.Parse(dTextBox.Text);
                _tau = double.Parse(tauСomboBox.Text);
                _n = int.Parse(nTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите данные", "Ошибка ввода", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetValues()
        {
            alphaTextBox.Text = "3";
            betaTextBox.Text = "-1";
            gamaTextBox.Text = "4";
            etaTextBox.Text = "1";
            phiTextBox.Text = "2";
            aTextBox.Text = "-10";
            bTextBox.Text = "10";
            cTextBox.Text = "-10";
            dTextBox.Text = "10";
            nTextBox.Text = "10000";

            double[] mGamma = { 1, 0.1, 0.01, 0.001, 0.0001 };
            foreach (double t in mGamma)
            {
                tauСomboBox.Items.Add(t);
            }
            tauСomboBox.SelectedIndex = tauСomboBox.FindString("0,001");
        }

        private static void InputValidation(double alpha, double beta, double gama, 
            double delta, double phi, double a, double b, double c, double d, int n)
        {
            var param = new Parameters
            {
                Alpha = alpha,
                Beta = beta,
                Gama = gama,
                Delta = delta,
                Phi = phi,
                A = a,
                B = b,
                C = c,
                D = d,
                N = n,
            };
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            GetValues();
            InputValidation(_alpha, _beta, _gama,  _delta, _phi, _a, _b, _c, _d, _n);
            ABCDWindow(_a, _b, _c, _d);
            graph.Invalidate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CLearPane();
        }

        private void graph_MouseClick(object sender, MouseEventArgs e)
        {
            double x0, y0;
            pane.ReverseTransform(e.Location, out x0, out y0);
            double prevfX = x0, prevfY = y0, curfX, curfY, prevbX = x0, prevbY = y0, curbX, curbY;
            var forwardList = new PointPairList();
            var backwardList = new PointPairList();
            forwardList.Add(x0, y0);
            backwardList.Add(x0, y0);

            for (double i = 0; i < _n; i++)
            {
                curfX = GetX(prevfX, prevfY, _beta, _alpha, _gama, _delta, _phi)  * _tau + prevfX;
                curfY = GetY(prevbX, prevbY, _delta, _phi)  *_tau + prevfY;
                forwardList.Add(curfX, curfY);
                prevfX = curfX;
                prevfY = curfY;

                curbX = prevbX - GetX(prevfX, prevfY, _beta, _alpha, _gama, _delta, _phi) *_tau;
                curbY = prevbY - GetY(prevbX, prevbY, _delta, _phi) *_tau;
                backwardList.Add(curbX, curbY);
                prevbX = curbX;
                prevbY = curbY;
            }
            var random = new Random();
            var forwardColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            DrawLine(forwardList, forwardColor);

            var backwardColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            DrawLine(backwardList, backwardColor);
            graph.Invalidate();
        }
    }
}

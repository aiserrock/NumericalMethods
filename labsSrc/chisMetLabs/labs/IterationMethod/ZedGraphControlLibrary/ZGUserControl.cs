using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace ZedGraphControlLibrary
{
    public partial class ZGUserControl: UserControl
    {
        public readonly GraphPane pane;
        public ZGUserControl()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane;
        }

        public new int Width
        {
            get { return zedGraphControl.Width; }
            set { zedGraphControl.Width = value; }
        }
        public new int Height
        {
            get { return zedGraphControl.Height; }
            set { zedGraphControl.Height = value; }
        }

        void zedGraph_CursorChanged(object sender, EventArgs e)
        {
            if (!zedGraphControl.Capture)
            {
                zedGraphControl.Cursor = Cursors.Arrow;
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
            zedGraphControl.CursorChanged += new EventHandler(zedGraph_CursorChanged);
            zedGraphControl.ContextMenuBuilder +=
            new ZedGraphControl.ContextMenuBuilderEventHandler(zedGraph_ContextMenuBuilder);
            zedGraphControl.IsEnableZoom = false;

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
            zedGraphControl.GraphPane.CurveList.Clear();
            zedGraphControl.GraphPane.GraphObjList.Clear();
            zedGraphControl.Invalidate();
        }

        public void ABCDWindow(double a, double b, double c, double d)
        {
            // Устанавливаем интересующий интервал по оси X
            pane.XAxis.Scale.Min = a;
            pane.XAxis.Scale.Max = b;

            // Устанавливаем интересующий интервал по оси Y
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
    }
}

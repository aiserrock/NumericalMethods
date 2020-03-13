using System;
using System.Drawing;
using System.Windows;
using ZedGraph;
using ZedGraphControlLibrary;

namespace IterationMethod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ZGUserControl graph;
        private double _beta, _gamma, _delta, _eps, 
            _a, _b, _c, _d, _xo; 
        private int _n, _m, _p;
        public MainWindow()
        {
            InitializeComponent();
            graph = new ZGUserControl();
            graph.GraphView("α", "X", "α*sin(tg(βx)) * sin(γ*x)");
            FormsHost.Child = graph;
            SetValues();
        }

        public double Func(double x, double alfa, double beta, double gamma)
        {
            return (x == gamma || beta == 0 || (beta / (x - gamma)) == 0) ? 0 :
                alfa * Math.Sin(Math.Tan(beta*x)) * Math.Sin(gamma * x);
        }

        private void GetValues()
        {
            try
            {
                _beta = double.Parse(betaTextBox.Text);
                if (_beta < -100 || _beta > 100) MessageBox.Show("Параметр β должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _gamma = double.Parse(gammaTextBox.Text);
                if (_gamma < -100 || _gamma > 100) MessageBox.Show("Параметр γ должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //_delta = double.Parse(deltaTextBox.Text);
                //if (_delta < -100 || _delta > 100) MessageBox.Show("Параметр δ должен принадлежать промежутку от [-100, 100]",
                //    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //_eps = double.Parse(epsilonTextBox.Text);
                if (_eps < -100 || _eps > 100) MessageBox.Show("Параметр ε должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _a = double.Parse(aTextBox.Text);
                if (_a < -100 || _a > 100) MessageBox.Show("Параметр A должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _b = double.Parse(bTextBox.Text);
                if (_b < -100 || _b > 100) MessageBox.Show("Параметр B должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _c = double.Parse(cTextBox.Text);
                if (_c < -100 || _c > 100) MessageBox.Show("Параметр C должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _d = double.Parse(dTextBox.Text);
                if (_d < -100 || _d > 100) MessageBox.Show("Параметр D должен принадлежать промежутку от [-100, 100]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _xo = double.Parse(xoTextBox.Text);
                if (_xo < _c || _xo > _d) MessageBox.Show("Параметр Xo должен принадлежать промежутку от [C, D]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _n = int.Parse(nTextBox.Text);
                if (_n < 0 || _n > 500) MessageBox.Show("Параметр n должен принадлежать промежутку от (0, 500]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _m = int.Parse(mTextBox.Text);
                if (_m < 0 || _m > 500) MessageBox.Show("Параметр m должен принадлежать промежутку от (0, 500]",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                _p = int.Parse(pComboBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите данные", "Ошибка ввода",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SetValues()
        {
            betaTextBox.Text = "69";
            gammaTextBox.Text = "-34";
            //deltaTextBox.Text = "67";
            //epsilonTextBox.Text = "64";
            aTextBox.Text = "-24";
            bTextBox.Text = "24";
            cTextBox.Text = "-100";
            dTextBox.Text = "100";
            xoTextBox.Text = "25";
            nTextBox.Text = "268";
            mTextBox.Text = "40";

            for (int i = 1; i <= 25; i++)
            {
                pComboBox.Items.Add(i);
            }
            pComboBox.SelectedIndex = 0;
        }

        private void Calculation(double a, double b, double beta, double gamma, double delta,
            double eps, double xo, int n, int m, int p)
        {
            var pList = new PointPairList();
            var nList = new PointPairList();
            var step = (b - a) / graph.Width;

            for (double alpha = a; alpha < b; alpha += step)
            {
                double xn = xo;
                for (int i = 0; i < m; i++)
                {
                    xn = Func(xn, alpha, beta, gamma);
                }

                for (int j = 0; j < n; j++)
                {
                    xn = Func(xn, alpha, beta, gamma);
                    if (j % p == 0 && j != 0)
                    {
                        //orange points
                        pList.Add(alpha, xn);
                    }
                    else
                    {
                        //black points
                        nList.Add(alpha, xn);
                    }
                }
            }
            graph.DrawPoints(pList, Color.Black);
            graph.DrawPoints(nList, Color.Orange);
        }
        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            graph.CLearPane();
            GetValues();
            Calculation(_a, _b, _beta, _gamma, _delta, _eps, _xo, _n, _m, _p);
            graph.ABCDWindow(_a, _b, _c, _d);  
        }

        private void FormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}

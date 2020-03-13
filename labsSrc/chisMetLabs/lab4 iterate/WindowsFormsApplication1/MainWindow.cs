using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class MainWindow : Form
	{
		public string Param;

		public MainWindow()
		{
			InitializeComponent();
			ParA.Value = -20;
			ParB.Value = 20;
			ParC.Value = -20;
			ParD.Value = 20;
			Par_n.Value = 20;
			Par_Alf.Value = 5;
			Par_Bet.Value = -3;
			Par_Mu.Value = 9;
			Par_Eps.Value = -3;
			Par_p.Value = 3;
			Par_m.Value = 30;
			Par_x0.Value = 10;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (var ch = 0; ch <= 1; ch++)
			{
				chart1.Series[ch].Points.Clear();
				chart1.Series[ch].Points.Clear();
			}

			double a = 4;
			double b = 20;
			const double step = 0.1; // шаг (1, 0.1 и т д)

			var A = (double)ParA.Value;
			var B = (double)ParB.Value;
			var C = (double)ParC.Value;
			var D = (double)ParD.Value;

			var n = (int)Par_n.Value;
			var m = (int)Par_m.Value;
			var p = (int)Par_p.Value;
			var x0 = (double)Par_x0.Value;

			if (A >= B || C >= D)//проверка на коректность, иначе сбрасываем по умолчанию
			{
				MessageBox.Show(A >= B
					? "Значение А не может быть больше (либо равно) В"
					: "Значение C не может быть больше (либо равно) D");
				A = -1;
				B = 1;
				C = -1;
				D = 1;
				ParA.Value = -1;
				ParB.Value = 1;
				ParC.Value = -1;
				ParD.Value = 1;
			}

			if (p > 25 || p < 1)
			{
				MessageBox.Show("Значение p должно быть натуральным числом от 1 до 25");
				Par_p.Value = 3;
			}

			if (x0 > D || x0 < C)
			{
				MessageBox.Show("Значение x0 должно быть входить в область [C,D]");
				Par_x0.Value = 10;
			}

			if (a >= b)
			{
				MessageBox.Show("Значение a не может быть больше (либо равно) b");
			}
			var alf = (double)Par_Alf.Value;
			var bet = (double)Par_Bet.Value;
			var gama = (double)Par_Mu.Value;
			var eps = (double)Par_Eps.Value;

			Param = Convert.ToString(comboBox2.Text);
			var func = new Functions(alf, bet, gama, eps, A, B, C, D, n, m, p, x0, Param);

			func.BuildIterationResults(1);
			var nx = func.Nx;
			var ny = func.Ny;
			var px = func.Px;
			var py = func.Py;
			var lenN = func.LenN;
			var lenP = func.LenP;
			BuildGraphic(nx, ny, px, py, lenN, lenP, 0, step, A, B, C, D);

		}

		public void BuildGraphic(double[] nx, double[] ny, double[] px, double[] py, int lenN, int lenP, int arg, double step, double a, double b, double c, double d)
		{
			int i;
			chart1.Series[0].LegendText = " n ";
			chart1.Series[1].LegendText = " p ";

			for (i = 0; i <= lenN; i++)
			{
				if (ny[i] <= d && ny[i] >= c)
					chart1.Series[0].Points.AddXY(nx[i], ny[i]);
			}

			for (var t = 0; t <= lenP; t++)
			{
				if (py[t] <= d && py[t] >= c)
					chart1.Series[1].Points.AddXY(px[t], py[t]);
			}
		}
	}
}

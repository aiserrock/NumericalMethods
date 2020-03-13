using System;

namespace WindowsFormsApplication1
{
	class Functions
	{ 
		private double alpha, beta, gama, epsilon, delta, A, B, C, D, x0;
		public int NMax;
		int n, m, p;

		readonly string _parstr;
		int NMAX = 5000;
		int MMAX = 1000;
		public int LenN, LenP;

		public double[] Nx;
		public double[] Ny;
		public double[] Px;
		public double[] Py;

		public void InitArrays()
		{
			Nx = new double[NMAX * MMAX + 1];
			Px = new double[NMAX * MMAX + 1];
			Ny = new double[NMAX * MMAX + 1];
			Py = new double[NMAX * MMAX + 1];
		}

		private static double Fx(double x, double al, double betta, double gamma, double eps, double delta)
		{
            return eps * Math.Sin(Math.Tan(al /((x - betta)*(x - gamma)*(x - delta))));
		}

		public double Function(double x, double param)
		{
			switch (_parstr)
			{
				case "α":
					return Fx(x, param, beta, gama, epsilon, delta);
				case "β":
					return Fx(x, alpha, param, gama, epsilon, delta);
				case "γ":
					return Fx(x, alpha, beta, param, epsilon, delta);
				case "ε":
					return Fx(x, alpha, beta, gama, param, delta);
                case "δ":
                    return Fx(x, alpha, beta, gama, epsilon, param);
            }
			return 0;
		}

		public void BuildIterationResults(int numOfPar)
		{
			var l = B - A;
			var h = l / NMAX;
			for (var i = 0; i <= NMAX; i++)
			{
				var absc = A + i * h;
				var yord = x0;
				for (var j = 0; j < m; j++)
					yord = Function(yord, absc);

				for (var j = 0; j < n; j++)
				{
					Nx[LenN] = absc;
					yord = Function(yord, absc);
					Ny[LenN] = yord;
					if (LenN % p == 0)
					{
						Px[LenP] = Nx[LenN];
						Py[LenP] = yord;
						LenP++;
					}
					LenN++;
				}
			}
		}

		public Functions(double alpha, double beta, double gama, double epsilon, double delta,
			double a, double b, double c, double d, int n, int m, int p, double x0, string par)
		{
			this.alpha = alpha;
			this.beta = beta;
			this.gama = gama;
			this.epsilon = epsilon;
            this.delta = delta;
			A = a;
			B = b;
			C = c;
			D = d;
			this.n = n;
			this.m = m;
			this.p = p;
			this.x0 = x0;
			_parstr = par;

			NMax = 0;
			InitArrays();
			LenN = 0;
			LenP = 0;
		}
	}
}

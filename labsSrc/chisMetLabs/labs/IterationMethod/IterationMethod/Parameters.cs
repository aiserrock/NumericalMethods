using System;

namespace IterationMethod
{
    class Parameters
    {
        private double _beta, _gamma, _delta, _epsilon, _a, _b, _c, _d, _xo;
        private int _m, _n;

        public double Beta
        {
            get { return _beta; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _beta = value;
            }
        }

        public double Gamma
        {
            get { return _gamma; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _gamma = value;
            }
        }

        public double Delta
        {
            get { return _delta; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _delta = value;
            }
        }

        public double Epsilon
        {
            get { return _epsilon; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _epsilon = value;
            }
        }

        public double A
        {
            get { return _a; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _a = value;
            }
        }

        public double B
        {
            get { return _b; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _b = value;
            }
        }

        public double C
        {
            get { return _c; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _c = value;
            }
        }

        public double D
        {
            get { return _d; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _d = value;
            }
        }

        public int M
        {
            get { return _m; }
            set
            {
                if (value < 0 || value > 500) throw new Exception("Параметр должен принадлежать промежутку (0; 500]");
                _m = value;
            }
        }

        public int N
        {
            get { return _n; }
            set
            {
                if (value < 0 || value > 500) throw new Exception("Параметр должен принадлежать промежутку (0; 500]");
                _n = value;
            }
        }

        public double Xo
        {
            get { return _xo; }
            set
            {
                if (value < C || value > D) throw new Exception("Параметр должен принадлежать промежутку [C;D]");
                _xo = value;
            }
        }
    }
}

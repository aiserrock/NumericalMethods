using System;

namespace ODUSystems
{
    class Parameters
    {
        private double _alpha, _beta, _gama,  _delta, _phi, _a, _b, _c, _d;
        private int _n;

        public double Alpha
        {
            get { return _alpha; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _alpha = value;
            }
        }

        public double Beta
        {
            get { return _beta; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _beta = value;
            }
        }

        public double Gama
        {
            get { return _gama; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _gama = value;
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

        public double Phi
        {
            get { return _phi; }
            set
            {
                if (value > 100 || value < -100) throw new Exception("Параметр должен принадлежать промежутку [-100; 100]");
                _phi = value;
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

        public int N
        {
            get { return _n; }
            set
            {
                if (value < 0 || value > 10000) throw new Exception("Параметр должен принадлежать промежутку (0; 10000]");
                _n = value;
            }
        }
    }
}

//---------------------------------------------------------------------------

#ifndef cCorH
#define cCorH
#include <math.h>
#include "cMainForm.h"
//---------------------------------------------------------------------------

const double PI = 3.1415926;
bool CheckNumber(char *num);
bool ChekPoint(char *num);
bool IsOk(TEdit *TextEdit, char Key);
void IsApply(TEdit *TextEdit);
const int SPACE = 20;
const int LINES_COUNT = 21;

class Interpolation
{
private:
        double c_Alpha;
        double c_Betta;
        double c_Gamma;
        double c_Delta;
        double c_Eps;
        double c_Mui;
        bool IsCashid;

        double c_A;                           
        double c_B;
        double c_C;
        double c_D;

        int c_N;
        double c_H;
        long double c_Steep;

        long double *c_Uzli;
        long double *c_Difference;
        long int *c_Factors;
public:
        Interpolation();
        ~Interpolation();
        TImage *IGraphs;
	TImage *IBackground;

        void ClearGraphs();
	void ClearBackground();
	void DrawAxes();
	void PrintScale();

        double F(double x);
        double DF(double x);
        double P(double x);
        double DP(double x);
        double R(double x);

        void SetAlpha(double _alpha){if(_alpha >= -100 && _alpha <= 100) c_Alpha = _alpha;}
        void SetBetta(double _betta){if(_betta >= -100 && _betta <= 100) c_Betta = _betta;}
        void SetGamma(double _gamma){if(_gamma >= -100 && _gamma <= 100) c_Gamma = _gamma;}
        void SetDelta(double _delta){if(_delta >= -100 && _delta <= 100) c_Delta = _delta;}
        void SetEps(double _eps){if(_eps >= -100 && _eps <= 100) c_Eps = _eps;}
        void SetMui(double _mui){if(_mui >= -100 && _mui <= 100) c_Mui = _mui;}

        void SetA(double _a){if(_a >= -100 && _a <= 100) c_A = _a;}
        void SetB(double _b){if(_b >= -100 && _b <= 100) c_B = _b;}
        void SetC(double _c){if(_c >= -100 && _c <= 100) c_C = _c;}
        void SetD(double _d){if(_d >= -100 && _d <= 100) c_D = _d;}

        void SetN(int _n){if(_n > 1 && _n <= 200) c_N = _n;}
        void SetH(double _h){c_H = _h;}
                               
        void Print_F();
        void Print_P();
        void Print_R();
        void Print_DF();
        void Print_DP();

        void Update();
        void GenerateFinalDifference();
        int Convert(int Degree, int k);
        void Point(TColor color, int x, int y );

        double Abs( double p )
        {
	        if( p > 0 )
		        return p;
	        return -p;
        }

        double Round( double p )
        {
	        double rez;

	        rez = ( int )( p * 1000 ) / 1000.;

	        if( ( int )( Abs( p * 10000 ) ) % 10 >= 5 )
	        {
		        if( p > 0 )
			        rez += 0.001;
		        else
			        rez -= 0.001;
	        }

	        return rez;
        }

};
#endif

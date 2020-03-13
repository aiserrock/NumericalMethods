
#include<QtGUI>
#include<math.h>
#define N 200
class Risynok : public QDialog
{
	Q_OBJECT
public:
	Risynok();
	double alfa1,beta1,gamm1,Hg,Wh,Ch,Dh,qq,ww,ee,rr,delta,del1;
	double retWh();
        double retHg();
        double retCh();
        double retDh();
	bool fxCheck,dfxCheck,PnxCheck,rnxCheck,dPnxCheck;
	void setCheck(bool ,bool,bool,bool,bool);	
	void setDelta(double);
	void setCordRis(double A,double B);
	void setC(double C, double r);
	void setXYZH(double x,double y,double z,double h);
	void set_n(int);

private:
	int nn;
	double h;
	double MasDelta[N][N];
	double retFX(double); 
        double polynom(double);
	void setMasN();
protected:
	void paintEvent(QPaintEvent *event);
	
};
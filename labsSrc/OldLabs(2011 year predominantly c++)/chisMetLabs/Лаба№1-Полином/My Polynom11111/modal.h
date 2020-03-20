
#include<QtGUI>
class Param : public QDialog
{
	Q_OBJECT
private:
	float A,B,C,D,a,b,e,y,n;
	QPushButton *bOk,*Otm,*inf;
	QDoubleSpinBox *AE,*BE,*CE,*DE,*Lalfa,*Lbeta,*Lyy,*Ldelta;
	QSpinBox *spn;
	QCheckBox *fx,*pnx,*rnx,*dfx,*dpnx;
	QRadioButton *d1,*d01,*d001,*d0001,*d00001;
	

public:
	Param();
	QPushButton* Ret_Otm();
	QPushButton* Ret_bOk();
	QPushButton* Ret_inf();
	QDoubleSpinBox* Ret_AE();
	QDoubleSpinBox* Ret_BE();
	QDoubleSpinBox* Ret_CE();
	QDoubleSpinBox* Ret_DE();
	QDoubleSpinBox* Ret_alfa();
	QDoubleSpinBox* Ret_beta();
	QDoubleSpinBox* Ret_yy();
	QDoubleSpinBox* Ret_delta();
	QSpinBox* Ret_Spn();
	double retDELT();
	bool ret_fx();
        bool ret_dfx();
        bool ret_Pnx();
        bool ret_rnx();
        bool ret_dPnx();
};
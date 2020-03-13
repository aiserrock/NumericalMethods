
#include"modal.h"
Param::Param()
{
	QLabel *lb,*n,*Lgranici,*m4,*m5,*A,*B,*C,*D,*delta,*Koef,*alfa,*beta,*yy,*FX,*m1,*m2,*m3;
	QFrame *f;
	f=new QFrame(this);	f->resize(400,50);	f->move(0,332);	
	f->show();
	f->setFrameStyle(QFrame::HLine | QFrame::Sunken);
	f->setLineWidth(1);
	lb=new QLabel(this);
	lb->setText("<h2>Vvod parametrov programmi</h2>");	
	n=new QLabel(this);
	n->setText("<h4>Vvedite parametr uzlov interpoliacii:</h4>");	
	lb->move(25,10);
	n->move(25,50);
	spn=new QSpinBox(this);
	spn->setMinimum(0);	
	spn->setMaximum(100);
	spn->move(330,50);
	Lgranici=new QLabel(this);
	Lgranici->setText("<h4>Ukazhite granici</h4>");
	Lgranici->move(25,80);
	A=new QLabel(this);	A->setText("A = ");	A->move(150,97);
	B=new QLabel(this);	B->setText("B = ");	B->move(150,122);
	C=new QLabel(this);	C->setText("C = ");	C->move(268,97);
	D=new QLabel(this);	D->setText("D = ");	D->move(268,122);
        AE=new QDoubleSpinBox(this);	AE->move(175,94);	AE->resize(70,17);AE->setMinimum(-100);AE->setMaximum(100);
	BE=new QDoubleSpinBox(this);	BE->move(175,121);	BE->resize(70,17);BE->setMinimum(-100);BE->setMaximum(100);
	CE=new QDoubleSpinBox(this);	CE->move(298,94);	CE->resize(70,17);CE->setMinimum(-100);CE->setMaximum(100);
	DE=new QDoubleSpinBox(this);	DE->move(298,121);	DE->resize(70,17);DE->setMinimum(-100);DE->setMaximum(100);
        
	Koef=new QLabel(this);
	Koef->setText("<h4>Vvedite koeficienti dlia <font color=green> &#945;sin(tg(&#946;/(x-y)))+&#948;*cos(&#949;x)</font>:</h4>");
	Koef->move(25,155);
	alfa=new QLabel(this);	alfa->setText("<h1></h1>&#945; =");	alfa->move(25,178);
	beta=new QLabel(this);	beta->setText("<h1></h1>&#946; =");	beta->move(25,203);
	yy=new QLabel(this);	yy->setText("<h1></h1>&#948; =");	yy->move(143,178);
	delta=new QLabel(this);	delta->setText("<h1></h1>&#949; =");	delta->move(143,203);
	Lalfa=new QDoubleSpinBox(this);	Lalfa->move(50,178);	Lalfa->resize(70,17);Lalfa->setMinimum(-100);Lalfa->setMaximum(100);
	Lbeta=new QDoubleSpinBox(this);	Lbeta->move(50,203);	Lbeta->resize(70,17);Lbeta->setMinimum(-100);Lbeta->setMaximum(100);
	Lyy=new QDoubleSpinBox(this);	Lyy->move(173,178);		Lyy->resize(70,17);Lyy->setMinimum(-100);Lyy->setMaximum(100);
	Ldelta=new QDoubleSpinBox(this);	Ldelta->move(173,203);		Ldelta->resize(70,17);Ldelta->setMinimum(-100);Ldelta->setMaximum(100);
	FX=new QLabel(this);
	FX->setText("<h4>Viberite funkcii dlia otobrazhenia:</h4>");
	FX->move(25,235);
	m1=new QLabel(this);	m1->setText("<h4>f(x)</h4>");	m1->move(186,257);
	m2=new QLabel(this);	m2->setText("<h4>df(x)</h4>");	m2->move(257,257);
	m3=new QLabel(this);	m3->setText("<h4>rn(x)</h4>");	m3->move(332,257);
	m4=new QLabel(this);	m4->setText("<h4>dPn(x)</h4>");	m4->move(98,257);
	m5=new QLabel(this);	m5->setText("<h4>Pn(x)</h4>");	m5->move(25,257);
	fx=new QCheckBox(this);		fx->move(190,273);
	dfx=new QCheckBox(this);	dfx->move(263,273);
	pnx=new QCheckBox(this);	pnx->move(31,273);
	dpnx=new QCheckBox(this);	dpnx->move(108,273);
	rnx=new QCheckBox(this);	rnx->move(339,273);
	QLabel *dl=new QLabel(this);	dl->setText("<h4>Viberite del'ta:</h4>");	dl->move(25,300);
	QLabel *d11=new QLabel(this);	d11->setText("1");	d11->move(135,320);
	QLabel *d2=new QLabel(this);	d2->setText("0.1");	d2->move(170,320);
	QLabel *d3=new QLabel(this);	d3->setText("0.01");	d3->move(215,320);
	QLabel *d4=new QLabel(this);	d4->setText("0.001");	d4->move(262,320);
	QLabel *d5=new QLabel(this);	d5->setText("0.0001");	d5->move(317,320);
	d1=new QRadioButton(this);		d1->move(142,320);	d1->setChecked(true);
	d01=new QRadioButton(this);		d01->move(188,320);
	d001=new QRadioButton(this);	d001->move(238,320);
	d0001=new QRadioButton(this);d0001->move(290,320);
	d00001=new QRadioButton(this);d00001->move(353,320);

	dl->show();
	bOk=new QPushButton(this);
	bOk->setText("Pokazat' grafik");
	bOk->resize(100,25);
	bOk->move(296,361);
	inf=new QPushButton(this);
	inf->setText("O sozdatele");
	inf->resize(100,25);
	inf->move(106,361);
	Otm=new QPushButton(this);
	Otm->setText("Vihod");
	Otm->resize(75,25);
	Otm->move(4,361);
	setFixedSize(400,390);
}
QPushButton* Param::Ret_Otm()
{	return Otm;	}
QPushButton* Param::Ret_bOk()
{	return bOk;	}
QPushButton* Param::Ret_inf()
{	return inf;	}
QDoubleSpinBox* Param::Ret_AE()
{	return AE;	}
QDoubleSpinBox* Param::Ret_BE()
{	return BE;	}
QDoubleSpinBox* Param::Ret_CE()
{	return CE;	}
QDoubleSpinBox* Param::Ret_DE()
{	return DE;	}
QSpinBox* Param::Ret_Spn()
{	return spn;	}
QDoubleSpinBox* Param::Ret_alfa()
{	return Lalfa;	}
QDoubleSpinBox* Param::Ret_beta()
{	return Lbeta;	}
QDoubleSpinBox* Param::Ret_yy()
{	return Lyy;	}
QDoubleSpinBox* Param::Ret_delta()
{	return Ldelta;	}

bool Param::ret_dfx()
{	return dfx->isChecked();	}

bool Param::ret_fx()
{	return fx->isChecked();	}

bool Param::ret_dPnx()
{	return dpnx->isChecked();	}

bool Param::ret_rnx()
{	return rnx->isChecked();	}

bool Param::ret_Pnx()
{	return pnx->isChecked();	}
double Param::retDELT()
{
	if(d1->isChecked())
		return 1;
	if(d01->isChecked())
		return 0.1;
	if(d001->isChecked())
		return 0.01;
	if(d0001->isChecked())
		return 0.001;
	if(d00001->isChecked())
		return 0.0001;
	return -1;
}
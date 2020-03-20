
#include"kontroller.h"
#include"iostream"
using namespace std;
pain::pain(QObject *parent)
{

}
pain::pain(QApplication *aa)
{
	param.show();
	connect(info.Ret_B(),SIGNAL(clicked()),&info,SLOT(hide()));
	connect(param.Ret_Otm(),SIGNAL(clicked()),SLOT(Clear()));
	connect(param.Ret_bOk(),SIGNAL(clicked()),SLOT(go()));
	connect(param.Ret_inf(),SIGNAL(clicked()),&info,SLOT(show()));
	connect(param.Ret_Otm(),SIGNAL(clicked()),aa,SLOT(quit()));
	connect(graph.ret_But(),SIGNAL(clicked()),&graph,SLOT(hide()));
	xx.setText("Parametri A i C dolzhni bit' sootvetstvenno men'she B i D.");
}

void pain::Clear()
{	
	param.Ret_AE()->clear();
	param.Ret_BE()->clear();
	param.Ret_CE()->clear();
	param.Ret_DE()->clear();
	param.Ret_Spn()->setValue(1);
	param.hide();
}
void pain::go()
{
	graph.Ret_rise()->setCheck(param.ret_fx(),param.ret_dfx(),param.ret_Pnx(),param.ret_dPnx(),param.ret_rnx());
	graph.Ret_rise()->setDelta(param.retDELT());

	graph.Ret_rise()->set_n(param.Ret_Spn()->value());
	QString AA,BB,CC,DD;

	AA=param.Ret_AE()->text();
	BB=param.Ret_BE()->text();
	CC=param.Ret_CE()->text();
	DD=param.Ret_DE()->text();

	a=0;b=0;c=0;d=0;

	a=AA.toDouble();	
	b=BB.toDouble();	
	c=CC.toDouble();	
	d=DD.toDouble();
	if(a>=b||c>=d)
	{
		xx.show();
		return;
	}

	AA=param.Ret_alfa()->text();
	BB=param.Ret_beta()->text();
	CC=param.Ret_yy()->text();
	DD=param.Ret_delta()->text();

	alf=AA.toDouble();	
	bet=BB.toDouble();		
	gam=CC.toDouble();
	del=DD.toDouble();
	

	graph.Ret_rise()->setC(c,d);
	graph.Ret_rise()->setCordRis(a,b);
	graph.Ret_rise()->setXYZH(alf,bet,gam,del);
	graph.Ret_rise()->update();
	graph.Ret_rise()->setFixedSize(400,400);
	graph.update();
	graph.show();
}


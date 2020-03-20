
#include"vid.h"
Graph::Graph()
{
	setFixedSize(465,545);
	dlg=new QFrame(this);
	dlg->resize(401,401);
	QLabel *lab=new QLabel(this);
	lab->setText("<h3>Grafiki vibrannih funkcyi  </h3>");
	QLabel *FX=new QLabel(this);	FX->setText("<font color=red><h2>f(x)</h2></font>");	FX->move(40,45);	FX->show();
	QLabel *dFX=new QLabel(this);	dFX->setText("<font color=Lime><h2>df(x)</h2></font>");	dFX->move(120,45);	dFX->show();
	QLabel *dpnx=new QLabel(this);	dpnx->setText("<font color=yellow><h2>dPn(x)</h2></font>");	dpnx->move(200,45);	dpnx->show();
	QLabel *pnx=new QLabel(this);	pnx->setText("<font color=blue><h2>Pn(x)</h2></font>");	pnx->move(300,45);	pnx->show();
	QLabel *rnx=new QLabel(this);	rnx->setText("<h2>rn(x)</h2>");	rnx->move(380,45);	rnx->show();	
	lab->move(120,15);
	dlg->setFrameStyle(QFrame::Panel | QFrame::Plain);
	dlg->setLineWidth(1);
	dlg->show();
	dlg->move(40,75);
	rise.setParent(this);
	rise.move(40,75);
	bt=new QPushButton(this);
	bt->setText("Ok");
	bt->move(195,510);
	
}
void Graph::paintEvent(QPaintEvent*)
{
	QPainter painCifr;
	painCifr.begin(this);
	double m,n,shag,WH=rise.retWh(),HG=rise.retHg(),CH=rise.retCh(),DH=rise.retDh();
	int WhInt=rise.retWh(),HgInt=rise.retHg(),WER;
	WER=WhInt;
	m=(HG-WH)/400;
	if(m>=0.5)
	{
		shag=15;
		while(WER%10&&WER%5)
			WER++;
	}
	if(m==1)
	{
		shag=20;
		while(WER%10)
			WER++;
	}
	if(m>=0.2&&m<0.5)
	{
		shag=10;
		while(WER%10)
			WER++;
	}
	if(m>=0.05&&m<0.2)
	{
		shag=5;
		while(WER%5)
			WER++;
	}
	if(m<0.05)
		shag=1;
	for(double x=WER;x<=HgInt;x+=shag)
	{
		QString t;
		t.setNum(x);
		painCifr.drawText(QPoint( ((x-WH)*400)/(HG-WH)+40 ,490),t);
	}

	int DhInt=rise.retDh(),ChInt=rise.retCh();

	WER=ChInt;
	n=(DH-CH)/400;
	if(n>=0.5)
	{
		shag=15;
		while(WER%10&&WER%5)
			WER++;
	}
	if(n==1)
	{
		shag=20;
		while(WER%10)
			WER++;
	}
	if(n>=0.2&&n<0.5)
	{
		while(WER%10)
			WER++;
		shag=10;
	}
	if(n>=0.05&&n<0.2)
	{
		while(WER%5)
			WER++;
		shag=5;
	}
	if(n<0.05)
		shag=1;
	for(double y=WER;y<=DhInt;y+=shag)
	{
		QString t;
		t.setNum(y);
		painCifr.drawText(QPoint( 15 ,400 -((y-CH)*400)/(DH-CH)+ 75  ) ,t);
	}
	painCifr.end();
}
Risynok* Graph::Ret_rise()
{	return &rise;	}
QPushButton* Graph::ret_But()
{	return bt;	}
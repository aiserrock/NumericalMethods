
#include"grClass.h"
#include<iostream>
#include<math.h>
using namespace std;
Risynok::Risynok()
{
	fxCheck=0,dfxCheck=0,PnxCheck=0,rnxCheck=0,dPnxCheck=0;
}
void Risynok::setCordRis(double A,double B)
{
	Wh=A;	
	Hg=B;
	this->resize(B-A,Dh-Ch);
}

void Risynok::paintEvent(QPaintEvent*)
{
	double i,j,cou=(Hg-Wh)/100;
	if(fxCheck)
	{
		QPainter painter;
		painter.begin(this);
		painter.setPen(QPen(Qt::red));
		//double sdvA=200+Wh,sdvC=200+Ch;
		i=Wh;
		j=retFX(i);
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			j=retFX(i);
			p1.setX( ((i+200-(200+Wh))/(Hg-Wh))*width() );		
			p1.setY(((200-j-(200-Dh))/(Dh-Ch))*height());
			painter.drawLine(p,p1);
			p=p1;
		}
		painter.end();
	}
	if(dfxCheck)
	{
		QPainter painter;
		painter.begin(this);
		painter.setPen(QPen(Qt::green));
		//double sdvA=200+Wh,sdvC=200+Ch;
		i=Wh;
		j=(retFX(i+delta)-retFX(i))/delta;
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			j=(retFX(i+delta)-retFX(i))/delta;
			p1.setX( ((i+200-(200+Wh))/(Hg-Wh))*width() );		
			p1.setY(((200-j-(200-Dh))/(Dh-Ch))*height());
			painter.drawLine(p,p1);
			p=p1;
		}
		painter.end();
	}
	if(PnxCheck)
	{
		h=(Hg-Wh)/(2*nn);
		setMasN();
		QPainter painter;
		painter.begin(this);
		painter.setPen(QPen(Qt::blue));
		painter.setRenderHint(QPainter::Antialiasing);
		//double sdvA=200+Wh,sdvC=200+Ch;
		i=Wh;
		j=polynom(i);
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			j=polynom(i);
			p1.setX( ((i+200-(200+Wh))/(Hg-Wh))*width() );		
			p1.setY(((200-j-(200-Dh))/(Dh-Ch))*height());
			painter.drawLine(p,p1);
			p=p1;
		}
		painter.end();
	}
	if(dPnxCheck)
	{
		h=(Hg-Wh)/(2*nn);
		setMasN();
		QPainter painter;
		painter.begin(this);
		painter.setPen(QPen(Qt::yellow));
		painter.setRenderHint(QPainter::Antialiasing);
		//double sdvA=200+Wh,sdvC=200+Ch;
		i=Wh;
		j=(polynom(i+delta)-polynom(i))/delta;
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			j=(polynom(i+delta)-polynom(i))/delta;
			p1.setX( ((i+200-(200+Wh))/(Hg-Wh))*width() );		
			p1.setY(((200-j-(200-Dh))/(Dh-Ch))*height());
			painter.drawLine(p,p1);
			p=p1;
		}
		painter.end();
	}
	if(rnxCheck)
	{
		h=(Hg-Wh)/(2*nn);
		setMasN();
		QPainter painter;
		painter.begin(this);
		painter.setPen(QPen(Qt::black));
		painter.setRenderHint(QPainter::Antialiasing);
		//double sdvA=200+Wh,sdvC=200+Ch;
		i=Wh;
		j=polynom(i)-retFX(i);
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			j=polynom(i)-retFX(i);
			p1.setX( ((i+200-(200+Wh))/(Hg-Wh))*width() );		
			p1.setY(((200-j-(200-Dh))/(Dh-Ch))*height());
			painter.drawLine(p,p1);
			p=p1;
		}
		painter.end();
	}
	if(PnxCheck&&fxCheck)
	{
		QPainter painter;
		painter.begin(this);

		double pogr=0,yyy=0;
		i=Wh;
		j=polynom(i)-retFX(i);
		QPoint p( ((i+200-(200+Wh))/(Hg-Wh))*width()  ,((200-j-(200-Dh))/(Dh-Ch))*height());
		QPoint p1( ((i+200-(200+Wh))/(Hg-Wh))*width() ,((200-j-(200-Dh))/(Dh-Ch))*height());
		i+=cou;
		for(;i<Hg;i+=cou)
		{
			if( abs(polynom(i)-retFX(i) )>pogr)
			{
				pogr=abs(polynom(i)-retFX(i));
				yyy=i;
			}

			painter.drawLine(p,p1);
			p=p1;
		}
		QString t("Pogreshnost':");
		QString t1;
		t1.setNum(pogr);
		painter.drawText(15,15,t);
		painter.drawText(95,15,t1);
		painter.setPen(QPen(Qt::red));
		painter.drawLine(QPoint(((yyy+200-(200+Wh))/(Hg-Wh))*width(),0),QPoint(((yyy+200-(200+Wh))/(Hg-Wh))*width(),400));
		painter.end();
	}

	QPainter painLine;
	painLine.begin(this);
	painLine.setPen(QPen(Qt::DotLine));
	double m,n,shag;
	int WhInt=Wh,HgInt=Hg,WER=Wh;
	m=(Hg-Wh)/400;
	if(m>=0.5)
		shag=15;
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
		painLine.drawLine(QPoint(  ((x-Wh)*400)/(Hg-Wh)  ,0),QPoint( ((x-Wh)*400)/(Hg-Wh) ,400));	
	int DhInt=Dh,ChInt=Ch;
	WER=ChInt;
	n=(Dh-Ch)/400;
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
		painLine.drawLine(QPoint( 400,400 -((y-Ch)*400)/(Dh-Ch)  ),QPoint(0  ,400 -((y-Ch)*400)/(Dh-Ch) ) );	

	painLine.end();
}
void Risynok::setXYZH(double x,double y,double z,double h)
{
	alfa1=x;
	beta1=y;
	gamm1=z;
	del1=h;
}
void Risynok::setC(double C,double r)
{
	Ch=C;
	Dh=r;
}
double Risynok::retWh()
{	return Wh;	}
double Risynok::retHg()
{	return Hg;	}
double Risynok::retCh()
{	return Ch;	}
double Risynok::retDh()
{	return Dh;	}
void Risynok::setCheck(bool a1,bool a2,bool a3,bool a4,bool a5)
{
	fxCheck=a1;
	dfxCheck=a2;
	PnxCheck=a3;
	rnxCheck=a5;
	dPnxCheck=a4;
}
void Risynok::setDelta(double x)
{	delta=x;	}
double Risynok::retFX(double x)
{	return alfa1*(sin(tan(beta1*x)))+gamm1*(cos(del1*x));	}
void Risynok::set_n(int x)
{	nn=x;	}

double Risynok::polynom(double x)
{
	double t=(x-Wh-nn*h)/h,sum=0,fac=1,TT;
	sum=MasDelta[nn][0];
	int p=1,v=0;
	TT=t;
	fac=1;
	for(int k=1;k<=nn;k++,p=1)
	{
		//if (k!=1)
		//	fac/=(2*k-2)*(2*k-1);
		for(fac=1;p<2*k;p++)
			fac/=p;
			//fac*=1/p;
		for(TT=t,v=1;v<k;v++)
			TT*=(t-v)*(t+v);
		sum+=fac*TT*(MasDelta[nn-k][2*k-1]+MasDelta[nn-k+1][2*k-1])/2;
		sum+=(fac/(2*k))*TT*t*(MasDelta[nn-k][2*k]);
	}
	return sum;
}
void Risynok::setMasN()
{
	int z=0;
	for(double x=Wh;z<=2*nn;x+=h,z++)
		MasDelta[z][0]=retFX(x);
	for(int j=1;j<=2*nn;j++)
		for(int i=0;i<=2*nn-j;i++)
			MasDelta[i][j]=MasDelta[i+1][j-1]-MasDelta[i][j-1];	
}

//---------------------------------------------------------------------------

#include <vcl.h>
#include <math.h>
#pragma hdrstop

#include "Umain.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
//#pragma resource "*.bmp"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::BitBtn1Click(TObject *Sender)
{
   int l,j;

   try{
  a=StrToFloat(Ed_a->Text);
  b=StrToFloat(Ed_b->Text);
  c=StrToFloat(Ed_c->Text);
  d=StrToFloat(Ed_d->Text);
  E=StrToFloat(Ed_E->Text);
  A=StrToFloat(EdkA->Text);
  B=StrToFloat(EdkB->Text);
  C=StrToFloat(EdkC->Text);
  D=StrToFloat(EdkD->Text);
  n=StrToFloat(Ed_n->Text);
  h=StrToFloat(Ed_h->Text);

  Chart1->LeftAxis->Maximum=D;
  Chart1->LeftAxis->Minimum=C;
  Chart1->BottomAxis->Maximum=B;
  Chart1->BottomAxis->Minimum=A;
   }
  catch(...)
  {
  }

 try {
 if(A<-1000 || A>1000 || B<-1000 || B>1000 || C<-1000 || C>1000 || D<-1000 || D>1000 || n<0 || n>100 || a<-100 || a>100 ||b<-100 || b>100 ||c<-100 || c>100 || d<-100 || d>100 || E<-100 || E>100 || h>2)
 throw Exception("");
     }
 catch(...)
 {

  ShowMessage(" Ошибка при вводе параметров задачи. \n  A,B,C,D - действительные числа от -1000 до 1000\n  E, a, b, c, d - действительные числа от -100 до 100\n  Количество узлов интерполирования n может принимать значение 0 или любое натуральное число до 100\n  Приращение h=1, 0.1, 0.01, 0.001,...\n Повторите ввод.");
  Ed_E->SetFocus();
  Ed_E->Text=1;
  Ed_a->Text=1;Ed_b->Text=1;Ed_c->Text=1;Ed_d->Text=1;
  EdkA->Text=-10;EdkB->Text=10;EdkC->Text=10;EdkD->Text=10;
  Ed_n->Text=17;Ed_h->Text=0.1;
  return;
 }


// вычисление расстояния между узлами интерполирования
  step=(B-A)/(2*n+1);

// вычисление значений функции в узлах интерполирования
   for(l=0;l<2*n+2;l++)
  {
    DY[0][l]=fun(A+l*step);
  }

// построение таблицы конечных разностей
  for(l=1;l<2*n+2;l++)
  for(j=0;j<2*n+2-l;j++)
    DY[l][j]=DY[l-1][j+1]-DY[l-1][j];



  Draw();

}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   int l,j;

   G1=1;G2=0;G3=0;G4=0;G5=0;G6=0;
   a=1;b=1;c=1;d=1;E=1;
   n=17;A=-10;B=10;C=-10;D=10;
   h=0.1;

// вычисление расстояния между узлами интерполирования
  step=(B-A)/(2*n+1);

// вычисление значений функции в узлах интерполирования
   for(l=0;l<2*n+2;l++)
  {
    DY[0][l]=fun(A+l*step);
  }

// построение таблицы конечных разностей
  for(l=1;l<2*n+2;l++)
  for(j=0;j<2*n+2-l;j++)
    DY[l][j]=DY[l-1][j+1]-DY[l-1][j];

   Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Draw()
{
  Series1->Clear();
  Series2->Clear();
  Series3->Clear();
  Series4->Clear();
  Series5->Clear();
  Series6->Clear();


    float X;
    int PX,PY;
    maxRn=0;

    for(PX=0;PX<=Chart1->Width;PX++)
    {
     X=A+PX*(B-A)/Chart1->Width;

     if(G1==1) Series1->AddXY(X, fun(X),"",clRed);
     if(G4==1) Series2->AddXY(X, (fun(X+h)-fun(X))/h, "", clRed);
     if(G2==1) Series3->AddXY(X, Pn(X),"",clRed);
     if(G5==1) Series4->AddXY(X, (Pn(X+h)-Pn(X))/h, "", clRed);
     if(G3==1) Series5->AddXY(X, fun(X)-Pn(X), "", clRed);
     if(fabs(fun(X)-Pn(X))>=maxRn) maxRn=X;

    }

   if(G6==1)
   {
    Series6->AddXY(maxRn,C,"",clRed);
    Series6->AddXY(maxRn,D,"",clRed);
   }
}

//---------------------------------------------------------------------------
float __fastcall TForm1::Pn(double x)
{
  int i;
  double x0, sum, p, q;

  p=1;
  x0=A+n*(B-A)/(2*n+1);
  q=(x-x0)*(2*n+1)/(B-A);
  sum=(DY[0][n]+DY[0][n+1])/2;
  sum=sum+(q-0.5)*DY[1][n];

  for(i=1;i<n+1;i++)
  {
    p=p*(q+i-1)*(q-i)/(2*i);
    sum=sum+p*(DY[2*i][n-i]+DY[2*i][n-i+1])/2;
    p=p/(2*i+1);
    sum=sum+(q-0.5)*p*DY[2*i+1][n-i];
  }
 Pn1=sum;
 return Pn1;
}

//---------------------------------------------------------------------------

float __fastcall TForm1::fun(double t)
{
	float tmp; // результат
	if(t-c==0)
		tmp=1;
	else tmp= t-c;

	return a*sin(tan(b/tmp))+E*cos(d*t);
}

//---------------------------------------------------------------------------

void __fastcall TForm1::BitBtn2Click(TObject *Sender)
{
 Close();        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton1Click(TObject *Sender)
{
  if(SpeedButton1->Down==true) G1=1; else G1=0;
  Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton2Click(TObject *Sender)
{
  if(SpeedButton2->Down==true) G2=1; else G2=0;
  Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton3Click(TObject *Sender)
{
  if(SpeedButton3->Down==true) G3=1; else G3=0;
  Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton4Click(TObject *Sender)
{
  if(SpeedButton4->Down==true) G4=1; else G4=0;
  Draw();
}

//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton5Click(TObject *Sender)
{
  if(SpeedButton5->Down==true) G5=1; else G5=0;
  Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::SpeedButton6Click(TObject *Sender)
{
  //if(SpeedButton6->Down==true) G6=1; else G6=0;
  Draw();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::BitBtn3Click(TObject *Sender)
{
  Series1->Clear();
  Series2->Clear();
  Series3->Clear();
  Series4->Clear();
  Series5->Clear();
  Series6->Clear();
  SpeedButton1->Down=false;
  SpeedButton2->Down=false;
  SpeedButton3->Down=false;
  SpeedButton4->Down=false;
  SpeedButton5->Down=false;
  //SpeedButton6->Down=false;
  G1=0;G2=0;G3=0;G4=0;G5=0;G6=0;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::N3Click(TObject *Sender)
{
  Series1->Clear();
  Series2->Clear();
  Series3->Clear();
  Series4->Clear();
  Series5->Clear();
  Series6->Clear();
  SpeedButton1->Down=false;
  SpeedButton2->Down=false;
  SpeedButton3->Down=false;
  SpeedButton4->Down=false;
  SpeedButton5->Down=false;
 // SpeedButton6->Down=false;
  G1=0;G2=0;G3=0;G4=0;G5=0;G6=0;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::N4Click(TObject *Sender)
{
 Close();        
}
//---------------------------------------------------------------------------




void __fastcall TForm1::Image2Click(TObject *Sender)
{
        //Series1->Clear();
       //  Image2->Picture->Clear();
}
//---------------------------------------------------------------------------




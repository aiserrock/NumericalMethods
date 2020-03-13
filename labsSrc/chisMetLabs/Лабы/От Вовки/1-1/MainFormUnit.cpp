//---------------------------------------------------------------------------

#include <vcl.h>
#include <math.h>
#pragma hdrstop

#include "MainFormUnit.h"
#include "OptionsFormUnit.h"
#include "AboutFormUnit.h"
#include "UslFormUnit.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMainForm *MainForm;
double Table[4][101];
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
        : TForm(Owner)
{alpha=0;
 beta=1;
 gamma=1;
 delta=1;
 h=1;
 n=5;
 H=(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/n;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::MainFormOnResize(TObject *Sender)
{ImageT->Top=Chart->Height/10+86;
 CheckBox1->Top=ImageT->Top+3;
 CheckBox2->Top=ImageT->Top+3+17;
 CheckBox3->Top=ImageT->Top+3+17*2;
 CheckBox4->Top=ImageT->Top+3+17*3;
 CheckBox5->Top=ImageT->Top+3+17*4;
 ImageT->Left=Chart->Width*0.99-155;
 CheckBox1->Left=ImageT->Left+5;
 CheckBox2->Left=ImageT->Left+5;
 CheckBox3->Left=ImageT->Left+5;
 CheckBox4->Left=ImageT->Left+5;
 CheckBox5->Left=ImageT->Left+5;
 ImageFormula->Left=MainForm->ClientWidth*0.01+18;
 ImageFormula->Width=MainForm->ClientWidth*0.9525-173.5;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::N2Click(TObject *Sender)
{OptionsForm->ShowModal();
 if(CheckBox1->Checked==true)
 {Series1->Clear();
  DrawSeries1();
 }
 if(CheckBox2->Checked==true)
 {Series2->Clear();
  DrawSeries2();
 }
 if(CheckBox3->Checked==true)
 {Series3->Clear();
  DrawSeries3();
 }
 if(CheckBox4->Checked==true)
 {Series4->Clear();
  DrawSeries4();
 }
 if(CheckBox5->Checked==true)
 {Series5->Clear();
  DrawSeries5();
 }
}
//---------------------------------------------------------------------------

double TMainForm::Function(double x)
{return alpha*sin(tan(beta*x))+gamma*cos(delta*x);
}
//---------------------------------------------------------------------------

void TMainForm::FillTable()
{int i;
 for(i=0;i<n+1;i++)
  Table[3][i]=Chart->BottomAxis->Minimum+(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/n*i;
 for(i=0;i<n+1;i++)
  Table[1][i]=Function(Table[3][i]);
 Table[0][0]=Table[1][0];
 for(int j=0;j<n;j++)
 {for(i=0;i<n-j;i++)
   Table[2][i]=Table[1][i+1]-Table[1][i];
  for(i=0;i<n-j;i++)
   Table[1][i]=Table[2][i];
  Table[0][j+1]=Table[1][0];
 }
}
//---------------------------------------------------------------------------

double TMainForm::Polinom(double x)
{double P=Table[0][0],xx,f,HH;
 int i,j;
 for(i=1;i<=n;i++)
 {for(xx=1,j=1;j<=i;j++)
   xx=xx*(x-Table[3][j-1]);
  for(f=1,j=1;j<=i;j++)
   f=f*j;
  for(HH=1,j=1;j<=i;j++)
   HH=HH*H;
  P=P+Table[0][i]/(f*HH)*xx;
 }
 return P;
}
//---------------------------------------------------------------------------

void TMainForm::DrawSeries1()
{double x;
 for(int i=0;i<Chart->Width;i++)
 {x=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  Series1->AddXY(x,Function(x),"",Series1->SeriesColor);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckBox1OnClick(TObject *Sender)
{if(CheckBox1->Checked==true)
  DrawSeries1();
 else
  Series1->Clear();
}

//---------------------------------------------------------------------------
void TMainForm::DrawSeries2()
{double x;
 FillTable();
 for(int i=0;i<Chart->Width;i++)
 {x=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  Series2->AddXY(x,Polinom(x),"",Series2->SeriesColor);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckBox2OnClick(TObject *Sender)
{if(CheckBox2->Checked==true)
  DrawSeries2();
 else
  Series2->Clear();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::MainFormOnShow(TObject *Sender)
{DrawSeries1();
 DrawSeries2();
}
//---------------------------------------------------------------------------

void TMainForm::DrawSeries3()
{double x;
 for(int i=0;i<Chart->Width;i++)
 {x=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  Series3->AddXY(x,(Function(x+h)-Function(x))/h,"",Series3->SeriesColor);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckBox3OnClick(TObject *Sender)
{if(CheckBox3->Checked==true)
  DrawSeries3();
 else
  Series3->Clear();
}
//---------------------------------------------------------------------------

 void TMainForm::DrawSeries4()
{double x;
 FillTable();
 for(int i=0;i<Chart->Width;i++)
 {x=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  Series4->AddXY(x,(Polinom(x+h)-Polinom(x))/h,"",Series4->SeriesColor);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckBox4OnClick(TObject *Sender)
{if(CheckBox4->Checked==true)
  DrawSeries4();
 else
  Series4->Clear();
}
//---------------------------------------------------------------------------

void TMainForm::DrawSeries5()
{double x;
 FillTable();
 for(int i=0;i<Chart->Width;i++)
 {x=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  Series5->AddXY(x,Function(x)-Polinom(x),"",Series5->SeriesColor);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckBox5OnClick(TObject *Sender)
{if(CheckBox5->Checked==true)
  DrawSeries5();
 else
  Series5->Clear();
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::N4Click(TObject *Sender)
{MainForm->Close();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::MainFormOnClose(TObject *Sender,
      TCloseAction &Action)
{if(Application->MessageBox("Вы действительно хотите выйти?","Выход",MB_ICONQUESTION+MB_YESNO)==IDNO)
  Action=caNone;

}
//---------------------------------------------------------------------------

void __fastcall TMainForm::N7Click(TObject *Sender)
{AboutForm->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::N6Click(TObject *Sender)
{UslForm->ShowModal();
}
//---------------------------------------------------------------------------


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
int NMax;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
        : TForm(Owner)
{alpha=1;
 gamma=3;
 delta=4;
 a=0;
 b=5;
 h=1;
 n=1;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::MainFormOnClose(TObject *Sender,
      TCloseAction &Action)
{if(Application->MessageBox("Вы действительно хотите выйти?","Выход",MB_ICONQUESTION+MB_YESNO)==IDNO)
  Action=caNone;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::MenuClick(TObject *Sender)
{if(Sender==N2||Sender==SpeedButton1){OptionsForm->ShowModal();
                if(check)
                {Series1->Clear();
                 DrawSeries1();
                }
                return;
               }
 if(Sender==N4){MainForm->Close();
                return;
               }
 if(Sender==N6||Sender==SpeedButton2){UslForm->ShowModal();
                return;
               }
 if(Sender==N7||Sender==SpeedButton3){AboutForm->ShowModal();
                return;
               }
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::MainFormOnShow(TObject *Sender)
{DrawSeries1();
}
//---------------------------------------------------------------------------
void TMainForm::DrawSeries1()
{double N,I_N,I_2N;
 NMax=0;
 for(int i=0;i<Chart->Width;i++)
 {beta=Chart->BottomAxis->Minimum+i*(Chart->BottomAxis->Maximum-Chart->BottomAxis->Minimum)/Chart->Width;
  N=n;
  I_N=Integral(N);
  I_2N=Integral(2*N);
  while(fabs(I_2N-I_N)>h)
  {I_N=I_2N;
   N*=2;
   I_2N=Integral(2*N);
  }
  if(N>NMax)
  NMax=N;
  Series1->AddXY(beta,I_N,"",Series1->SeriesColor);
 }
 Chart->Title->Text->Clear();
 Chart->Title->Text->Add("n-max = "+IntToStr(NMax));
}
//---------------------------------------------------------------------------
double TMainForm::Integral(double N)
{double I;
 I=Function(a)/2+Function(b)/2;
 for(int i=1;i<N;i++)
  I+=Function(a+i*(b-a)/N);
 I*=(b-a)/N;
 return I;
}
//---------------------------------------------------------------------------
double TMainForm::Function(double x)
{return alpha*sin(tan(beta*x))+gamma*cos(delta*x);
 /*if(x-beta==0)
 x+=0.00001;
 return epsilon*sin(tan(alpha/(x-beta)*(x-gamma)*(x-delta)));*/
}
//---------------------------------------------------------------------------


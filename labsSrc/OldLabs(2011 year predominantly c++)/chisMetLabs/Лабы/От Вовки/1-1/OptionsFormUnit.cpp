//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "OptionsFormUnit.h"
#include "MainFormUnit.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TOptionsForm *OptionsForm;
double alpha,beta,gamma,delta,A,B,C,D;
int n;
//---------------------------------------------------------------------------
__fastcall TOptionsForm::TOptionsForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::OptionsFormOnShow(TObject *Sender)
{char temp[5];
 EditAlpha->Text=MainForm->alpha;
 EditBeta->Text=MainForm->beta;
 EditGamma->Text=MainForm->gamma;
 EditDelta->Text=MainForm->delta;
 EditA->Text=MainForm->Chart->BottomAxis->Minimum;
 EditB->Text=MainForm->Chart->BottomAxis->Maximum;
 EditC->Text=MainForm->Chart->LeftAxis->Minimum;
 EditD->Text=MainForm->Chart->LeftAxis->Maximum;
 EditN->Text=MainForm->n;
 itoa(MainForm->h*10000,temp,10);       //Сам потом не вспомню как сделал :)
 ComboBoxH->ItemIndex=5-StrLen(temp);
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::BitBtnOkOnClick(TObject *Sender)
{double h=0.0001;
 if(!(TryStrToFloat(EditAlpha->Text,alpha)&&alpha>=-100&&alpha<=100))
 {Application->MessageBox("Неверное значение параметра альфа","Внимание",MB_ICONERROR);
  EditAlpha->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditBeta->Text,beta)&&beta>=-100&&beta<=100))
 {Application->MessageBox("Неверное значение параметра бета","Внимание",MB_ICONERROR);
  EditBeta->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditGamma->Text,gamma)&&gamma>=-100&&gamma<=100))
 {Application->MessageBox("Неверное значение параметра гамма","Внимание",MB_ICONERROR);
  EditGamma->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditDelta->Text,delta)&&delta>=-100&&delta<=100))
 {Application->MessageBox("Неверное значение параметра дельта","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditA->Text,A)&&A>=-1000&&A<=1000))
 {Application->MessageBox("Неверное значение параметра A","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditB->Text,B)&&B>=A&&B<=1000))
 {Application->MessageBox("Неверное значение параметра B","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditC->Text,C)&&C>=-1000&&C<=1000))
 {Application->MessageBox("Неверное значение параметра C","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditD->Text,D)&&D>=C&&D<=1000))
 {Application->MessageBox("Неверное значение параметра D","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 if(!(TryStrToInt(EditN->Text,n)&&n>0&&n<=100))
 {Application->MessageBox("Неверное значение параметра n","Внимание",MB_ICONERROR);
  EditDelta->SetFocus();
  return;
 }
 MainForm->alpha=alpha;
 MainForm->beta=beta;
 MainForm->gamma=gamma;
 MainForm->delta=delta;
 MainForm->Chart->BottomAxis->Maximum=1000;
 MainForm->Chart->LeftAxis->Maximum=1000;
 MainForm->Chart->BottomAxis->Minimum=A;
 MainForm->Chart->BottomAxis->Maximum=B;
 MainForm->Chart->LeftAxis->Minimum=C;
 MainForm->Chart->LeftAxis->Maximum=D;
 MainForm->n=n;
 for(int i=0;i<4-ComboBoxH->ItemIndex;i++)
  h*=10;
 MainForm->h=h;
 MainForm->H=(B-A)/n;
 OptionsForm->Close();
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::BitBtnCancelOnClick(TObject *Sender)
{OptionsForm->Close();
}
//---------------------------------------------------------------------------


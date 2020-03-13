//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "OptionsFormUnit.h"
#include "MainFormUnit.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TOptionsForm *OptionsForm;
double alpha,gamma,delta,A,B,C,D,a,b;
int n;
//---------------------------------------------------------------------------
__fastcall TOptionsForm::TOptionsForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::OptionsFormOnShow(TObject *Sender)
{char temp[6];
 EditAlpha->Text=MainForm->alpha;
 EditGamma->Text=MainForm->gamma;
 EditDelta->Text=MainForm->delta;
 EditA->Text=MainForm->Chart->BottomAxis->Minimum;
 EditB->Text=MainForm->Chart->BottomAxis->Maximum;
 EditC->Text=MainForm->Chart->LeftAxis->Minimum;
 EditD->Text=MainForm->Chart->LeftAxis->Maximum;
 Edit_a->Text=MainForm->a;
 Edit_b->Text=MainForm->b;
 EditN->Text=MainForm->n;
 itoa(MainForm->h*100000,temp,10);       //Сам потом не вспомню как сделал :)
 ComboBoxH->ItemIndex=6-StrLen(temp);
 MainForm->check=0;
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::BitBtnOkOnClick(TObject *Sender)
{double h=0.00001;
 if(!(TryStrToFloat(EditAlpha->Text,alpha)&&alpha>=-100&&alpha<=100))
 {Application->MessageBox("Неверное значение параметра альфа","Внимание",MB_ICONERROR);
  EditAlpha->SetFocus();
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
  EditA->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditB->Text,B)&&B>=A&&B<=1000))
 {Application->MessageBox("Неверное значение параметра B","Внимание",MB_ICONERROR);
  EditB->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditC->Text,C)&&C>=-1000&&C<=1000))
 {Application->MessageBox("Неверное значение параметра C","Внимание",MB_ICONERROR);
  EditC->SetFocus();
  return;
 }
 if(!(TryStrToFloat(EditD->Text,D)&&D>=C&&D<=1000))
 {Application->MessageBox("Неверное значение параметра D","Внимание",MB_ICONERROR);
  EditD->SetFocus();
  return;
 }
 if(!(TryStrToFloat(Edit_a->Text,a)&&a>=-100&&a<=100))
 {Application->MessageBox("Неверное значение параметра a","Внимание",MB_ICONERROR);
  Edit_a->SetFocus();
  return;
 }
 if(!(TryStrToFloat(Edit_b->Text,b)&&b>=a&&b<=100))
 {Application->MessageBox("Неверное значение параметра b","Внимание",MB_ICONERROR);
  Edit_b->SetFocus();
  return;
 }
 if(!(TryStrToInt(EditN->Text,n)&&n>0&&n<=500))
 {Application->MessageBox("Неверное значение параметра n","Внимание",MB_ICONERROR);
  EditN->SetFocus();
  return;
 }
 for(int i=0;i<5-ComboBoxH->ItemIndex;i++)
  h*=10;
 if(h<0.001)
  if(Application->MessageBox("Такая точность может повесить ваш компьютер.\nВы уверены что хотите ее оставить?","Предупреждение",MB_ICONWARNING+MB_YESNO)==IDNO)
  {ComboBoxH->SetFocus();
   return;
  } 
 MainForm->alpha=alpha;
 MainForm->gamma=gamma;
 MainForm->delta=delta;
 MainForm->Chart->BottomAxis->Minimum=A;
 MainForm->Chart->BottomAxis->Maximum=B;
 MainForm->Chart->LeftAxis->Minimum=C;
 MainForm->Chart->LeftAxis->Maximum=D;
 MainForm->a=a;
 MainForm->b=b;
 MainForm->n=n;
 MainForm->h=h;
 OptionsForm->Close();
 MainForm->check=1;
}
//---------------------------------------------------------------------------

void __fastcall TOptionsForm::BitBtnCancelOnClick(TObject *Sender)
{OptionsForm->Close();
}
//---------------------------------------------------------------------------


//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MainUnit.h"
#include "Math.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "CSPIN"
#pragma link "SHDocVw_OCX"
#pragma resource "*.dfm"
TMainForm *MainForm;
long double x,y,Dots[2][50],alpha=1,beta=2,gamma=3,delta=4,fi=5,p=6,A=-2,B=2,C=-2,D=2,H=0.01,x02,y02;
int N=500,DotsCount=0,error=0;
TColor ColorPlus,ColorMinus;
//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
        : TForm(Owner)
{AnsiString LabPath=GetCurrentDir();
 LabPath=LabPath + "\\task";
 //CppWebBrowser->Navigate(WideString(LabPath));
 ColorPlus=clGreen;
 ColorMinus=clMaroon;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::OnClick(TObject *Sender)
{if(Sender==SPOptions||Sender==N11)
  if(PanelOptions->Visible==true)
  {Chart->Width=MainForm->ClientWidth;
   PanelOptions->Visible=false;
   return;
  }
  else
  {Chart->Width=MainForm->ClientWidth-PanelOptions->Width;
   PanelOptions->Visible=true;
   return;
  }
 if(Sender==N12)
 {Chart->SeriesList->Clear();
  TLineSeries *ShtobBylo=new TLineSeries(Application);
  Chart->AddSeries(ShtobBylo);
  Chart->Refresh();
  DotsCount=0;
  return;
 }
 if(Sender==N13)
  MainForm->Close();
 /*if(Sender==SPTask||Sender==PanelTask||Sender==LTaskTitle||Sender==N21)
  if(PanelTask->Visible==true)
  {PanelTask->Visible=false;
   return;
  }
  else
  {PanelAbout->Visible=false;
   PanelTask->Visible=true;
   return;
  }*/
 if(Sender==PanelAbout||Sender==LAboutTitle||Sender==MemoAbout||
    Sender==PanelPhoto||Sender==ImagePhoto||Sender==N22)
  if(PanelAbout->Visible==true)
  {PanelAbout->Visible=false;
   return;
  }
  else
  {
   PanelAbout->Visible=true;
   return;
  }
 if(Sender==LColorPlus)
 {ColorDialog->Color=ColorPlus;
  if(ColorDialog->Execute())
  {ColorPlus=ColorDialog->Color;
   LColorPlus->Font->Color=ColorPlus;
  }
  return;
 }
 if(Sender==LColorMinus)
 {ColorDialog->Color=ColorMinus;
  if(ColorDialog->Execute())
  {ColorMinus=ColorDialog->Color;
   LColorMinus->Font->Color=ColorMinus;
  }
  return;
 }
 if(Sender==ButtonApply)
 {{double test;
   if(!TryStrToFloat(EditAlpha->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра Альфа","Внимание!",MB_ICONWARNING);
    EditAlpha->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditBeta->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра Бэта","Внимание!",MB_ICONWARNING);
    EditBeta->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditGamma->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра Гамма","Внимание!",MB_ICONWARNING);
    EditGamma->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditDelta->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра Дельта","Внимание!",MB_ICONWARNING);
    EditDelta->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditFi->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра Фи","Внимание!",MB_ICONWARNING);
    EditFi->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditP->Text,test)||test<-100||test>100)
   {Application->MessageBoxA("Неверное значение параметра П","Внимание!",MB_ICONWARNING);
    EditP->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditA->Text,test)||test<-1000||test>1000)
   {Application->MessageBoxA("Неверное значение параметра A","Внимание!",MB_ICONWARNING);
    EditA->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditB->Text,test)||test<=StrToFloat(EditA->Text)||test>1000)
   {Application->MessageBoxA("Неверное значение параметра B","Внимание!",MB_ICONWARNING);
    EditB->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditC->Text,test)||test<-1000||test>1000)
   {Application->MessageBoxA("Неверное значение параметра C","Внимание!",MB_ICONWARNING);
    EditC->SetFocus();
    return;
   }
   if(!TryStrToFloat(EditD->Text,test)||test<=StrToFloat(EditC->Text)||test>1000)
   {Application->MessageBoxA("Неверное значение параметра D","Внимание!",MB_ICONWARNING);
    EditD->SetFocus();
    return;
   }
  }
  {int test;
   if(!TryStrToInt(EditN->Text,test)||test<1||test>10000)
   {Application->MessageBoxA("Неверное значение параметра N","Внимание!",MB_ICONWARNING);
    EditD->SetFocus();
    return;
   }
  }
  alpha=StrToFloat(EditAlpha->Text);
  beta=StrToFloat(EditBeta->Text);
  gamma=StrToFloat(EditGamma->Text);
  delta=StrToFloat(EditDelta->Text);
  fi=StrToFloat(EditFi->Text);
  p=StrToFloat(EditP->Text);
  Chart->BottomAxis->Minimum=A=StrToFloat(EditA->Text);
  Chart->BottomAxis->Maximum=B=StrToFloat(EditB->Text);
  Chart->LeftAxis->Minimum=C=StrToFloat(EditC->Text);
  Chart->LeftAxis->Maximum=D=StrToFloat(EditD->Text);
  N=StrToInt(EditN->Text);
  H=StrToFloat(ComboBoxH->Text);
  Chart->SeriesList->Clear();
  if(!DotsCount)
  {TLineSeries *ShtobBylo=new TLineSeries(Application);
   Chart->AddSeries(ShtobBylo);
   Chart->Refresh();
  }
  else
   for(int i=0;i<DotsCount;i++)
    DrawSeries(Dots[0][i],Dots[1][i]);
 }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormResize(TObject *Sender)
{PanelAbout->Left=(MainForm->ClientWidth-PanelAbout->Width)/4;
 PanelAbout->Top=(MainForm->ClientHeight-PanelAbout->Height)/4;
 //PanelTask->Left=PanelAbout->Left;
 //PanelTask->Top=PanelAbout->Top;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormClose(TObject *Sender, TCloseAction &Action)
{if(Application->MessageBox("Лабу делал Бритнев. Выйти?","Выход",MB_ICONQUESTION+MB_YESNO)==IDNO)
  Action=caNone;
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::ChartMouseDown(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{if(DotsCount==50)
  return;
 int symb;
 if(abs(A)>abs(B))
  symb=IntToStr(abs(A)).Length();
 else
  symb=IntToStr(abs(B)).Length();
 x=A+(B-A)/(Chart->ClientWidth*0.98-22)*(X-X*0.01-16-6*symb);
 y=C+(D-C)/(Chart->ClientHeight*0.98-22)*(Chart->ClientHeight-Y+Y*0.01-28);
 Dots[0][DotsCount]=x;
 Dots[1][DotsCount]=y;
 DrawSeries(x,y);
 DotsCount++;
}
//---------------------------------------------------------------------------

void TMainForm::DrawSeries(long double x0,long double y0)
{int i;
 long double x2,integer,stepen,temp;
 x2=x=x0;
 y=y0;
 TLineSeries *PlusSeries, *MinusSeries;
 PlusSeries=new TLineSeries(Application);
 Chart->AddSeries(PlusSeries);
 PlusSeries->XValues->Order=loNone;
 PlusSeries->AddXY(x0,y0,"",ColorPlus);
 error=0;
 for(i=1;i<=N;i++)
 {if(x>1000||x<-1000||y>1000||y<-1000)
   break;
  x+=((alpha*x+beta*y)*(alpha*x+beta*y)+gamma)*H;
  y+=((p*x+delta*y)*(p*x+delta*y)+fi)*H;
  if(error==1) break;
  PlusSeries->AddXY(x,y,"",ColorPlus);
  x2=x;
 }
 x2=x=x0;
 y=y0;
 MinusSeries=new TLineSeries(Application);
 Chart->AddSeries(MinusSeries);
 MinusSeries->XValues->Order=loNone;
 MinusSeries->AddXY(x,y,"",ColorMinus);
 error=0;
 for(i=-1;i>=-N;i--)
 {if(x>1000||x<-1000||y>1000||y<-1000)
   break;

  x-=((alpha*x+beta*y)*(alpha*x+beta*y)+gamma)*H;
  y-=((p*x+delta*y)*(p*x+delta*y)+fi)*H;
  if(error==1) break;
  MinusSeries->AddXY(x,y,"",ColorMinus);
  x2=x;
 }
}
//----------------------------------------------------------------------------

int _matherrl (struct _exceptionl *e)
{e->retval=1;
 error=1;
 return 1;
}







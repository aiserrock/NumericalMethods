//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "cMainForm.h"
#include "cDataModule.h"
#include "cCor.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMainForm *MainForm;
Interpolation Polinom;

//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::AlphaEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(AlphaEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::AlphaEditExit(TObject *Sender)
{
        IsApply(AlphaEdit);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::BettaEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(BettaEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::BettaEditExit(TObject *Sender)
{
        IsApply(BettaEdit);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::GammaEditExit(TObject *Sender)
{
        IsApply(GammaEdit);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::GammaEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(GammaEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DeltaEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(DeltaEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DeltaEditExit(TObject *Sender)
{
        IsApply(DeltaEdit);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormShow(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------



void __fastcall TMainForm::CheckFClick(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckPClick(TObject *Sender)
{
        Polinom.Update();        
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckRClick(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckdFClick(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CheckdPClick(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::F_XChange(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::P_XChange(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::R_XChange(TObject *Sender)
{
        Polinom.Update();        
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::dF_XChange(TObject *Sender)
{
        Polinom.Update();        
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::dP_XChange(TObject *Sender)
{
        Polinom.Update();        
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::AEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(AEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::BEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(BEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(CEdit, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DEditKeyPress(TObject *Sender, char &Key)
{
        if(!IsOk(DEdit, Key))
                Key=NULL;       
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::AEditExit(TObject *Sender)
{
        IsApply(AEdit);

        if(AEdit->Text.ToDouble() >= BEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'A' должно быть меньше значения параметра 'B'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                AEdit->SetFocus();
        }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::BEditExit(TObject *Sender)
{
        IsApply(BEdit);

        if(AEdit->Text.ToDouble() >= BEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'A' должно быть меньше значения параметра 'B'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                BEdit->SetFocus();
        }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::CEditExit(TObject *Sender)
{
        IsApply(CEdit);

        if(CEdit->Text.ToDouble() >= DEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'C' должно быть меньше значения параметра 'D'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                CEdit->SetFocus();
        }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::DEditExit(TObject *Sender)
{
        IsApply(DEdit);

        if(CEdit->Text.ToDouble() >= DEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'C' должно быть меньше значения параметра 'D'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                DEdit->SetFocus();
        }
}
//---------------------------------------------------------------------------



void __fastcall TMainForm::MainGraphicUndoZoom(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::NEditKeyPress(TObject *Sender, char &Key)
{
        if(!(Key >= '0' && Key <= '9') && Key != '\b')
        {
                Key = NULL;                            
                Beep(500,50);
        }
        else if (NEdit->Text.Length() > 5 && Key != '\b')
        {
                Key = NULL;
                Beep(500,50);
        }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::NEditExit(TObject *Sender)
{
        if(NEdit->Text.Length() > 0)
        {
                if(NEdit->Text.ToInt() < 2)
                {
                        Beep(500,50);
                        NEdit->Text = "2";
                }
                else if(NEdit->Text.ToInt() > 200)
                {
                        Beep(500,50);
                        NEdit->Text = "200";
                }
        }
        else
        {
                Beep(500,50);
                NEdit->Text = "2";
        }
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::HComboBoxKeyPress(TObject *Sender, char &Key)
{
        Key = NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::HComboBoxChange(TObject *Sender)
{
        Polinom.Update();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::ShowUzelClick(TObject *Sender)
{
        Polinom.Update();        
}
//---------------------------------------------------------------------------



void __fastcall TMainForm::FormCreate(TObject *Sender)
{
        Polinom.IGraphs = MainForm->Graphic;
        Polinom.IBackground = MainForm->Background;  
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormResize(TObject *Sender)
{
        // перерисовываем координатную сетку

        Polinom.IBackground->Left = 0;
	Polinom.IBackground->Top = 0;
	Polinom.IBackground->Width = 2000;
	Polinom.IBackground->Height = 2000;

    	Polinom.ClearBackground();
	Polinom.DrawAxes();
      	Polinom.PrintScale();

    	// выставляем область рисования графиков в соответствии с координатной сеткой
	Polinom.IGraphs->Left = Polinom.IBackground->Left + 2 * SPACE;
	Polinom.IGraphs->Top = Polinom.IBackground->Top + SPACE;
	Polinom.IGraphs->Width = Polinom.IBackground->Width - 3 * SPACE;
	Polinom.IGraphs->Height = Polinom.IBackground->Height - 3 * SPACE;

        Polinom.ClearGraphs();

        // серое пунктирное перо одинарной толщины
	Polinom.IGraphs->Canvas->Pen->Color = clGray;
	Polinom.IGraphs->Canvas->Pen->Width = 1;
	Polinom.IGraphs->Canvas->Pen->Style = psDot;

	// координатная сетка
	for( int i = 0; i < LINES_COUNT; i++ )
	{
		// вертикальные линии
		Polinom.IGraphs->Canvas->MoveTo( (Polinom.IGraphs->Width - 1 ) * i / ( LINES_COUNT - 1 ), 0 );
		Polinom.IGraphs->Canvas->LineTo( (Polinom.IGraphs->Width - 1 ) * i / ( LINES_COUNT - 1 ), Polinom.IGraphs->Height );

		// горизонтальные линии
		Polinom.IGraphs->Canvas->MoveTo( 0, (Polinom.IGraphs->Height - 1) * i / ( LINES_COUNT - 1 ) );
		Polinom.IGraphs->Canvas->LineTo( Polinom.IGraphs->Width, (Polinom.IGraphs->Height - 1 )* i / ( LINES_COUNT - 1 ) );
	}

        if(MainForm->CheckF->Checked)
                Polinom.Print_F();
                                       
        if(MainForm->CheckP->Checked)
                Polinom.Print_P();

        if(MainForm->CheckR->Checked)
                Polinom.Print_R();

        if(MainForm->CheckdF->Checked)
                Polinom.Print_DF();
                                        
        if(MainForm->CheckdP->Checked)
                Polinom.Print_DP();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::Edit1Exit(TObject *Sender, char &Key)
{
        if(!IsOk(Edit1, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::Edit1KeyPress(TObject *Sender)
{
        IsApply(Edit1);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::Edit2Exit(TObject *Sender, char &Key)
{
        if(!IsOk(Edit2, Key))
                Key=NULL;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::Edit2KeyPress(TObject *Sender)
{
        IsApply(Edit2);
}

void __fastcall TMainForm::Button1Click(TObject *Sender)
{
        IsApply(AlphaEdit);
        IsApply(BettaEdit);
        IsApply(GammaEdit);                
        IsApply(DeltaEdit);

        IsApply(AEdit);
        if(AEdit->Text.ToDouble() >= BEdit->Text.ToDouble())
        {                                    
                Application->MessageBox("Значение параметра 'A' должно быть меньше значения параметра 'B'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                AEdit->SetFocus();
        }

        IsApply(BEdit);
        if(AEdit->Text.ToDouble() >= BEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'A' должно быть меньше значения параметра 'B'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                BEdit->SetFocus();
        }

        IsApply(CEdit);
        if(CEdit->Text.ToDouble() >= DEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'C' должно быть меньше значения параметра 'D'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                CEdit->SetFocus();
        }
        
        IsApply(DEdit);
        if(CEdit->Text.ToDouble() >= DEdit->Text.ToDouble())
        {
                Application->MessageBox("Значение параметра 'C' должно быть меньше значения параметра 'D'","Некорректный параметр",MB_ICONINFORMATION + MB_OK);
                DEdit->SetFocus();
        }
        
        if(NEdit->Text.Length() > 0)
        {
                if(NEdit->Text.ToInt() < 2)
                {
                        Beep(500,50);
                        NEdit->Text = "2";
                }
                else if(NEdit->Text.ToInt() > 200)
                {
                        Beep(500,50);
                        NEdit->Text = "200";
                }
        }
        else
        {
                Beep(500,50);
                NEdit->Text = "2";
        }

        //-------------------------------------------------------------------

        Polinom.Update();        
}
//---------------------------------------------------------------------------


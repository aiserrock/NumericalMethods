//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "cDataModule.h"
#include "cMainForm.h"
#include "cAbout.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMainDataModule *MainDataModule;
//---------------------------------------------------------------------------
__fastcall TMainDataModule::TMainDataModule(TComponent* Owner)
        : TDataModule(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainDataModule::N3Click(TObject *Sender)
{
        Application->Terminate();        
}
//---------------------------------------------------------------------------

void __fastcall TMainDataModule::N4Click(TObject *Sender)
{
        AboutForm->ShowModal();
}
//---------------------------------------------------------------------------


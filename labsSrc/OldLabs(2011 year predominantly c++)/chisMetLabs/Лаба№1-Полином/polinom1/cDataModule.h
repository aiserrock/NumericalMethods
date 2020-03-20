//---------------------------------------------------------------------------

#ifndef cDataModuleH
#define cDataModuleH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Menus.hpp>
//---------------------------------------------------------------------------
class TMainDataModule : public TDataModule
{
__published:	// IDE-managed Components
        void __fastcall N3Click(TObject *Sender);
        void __fastcall N4Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TMainDataModule(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainDataModule *MainDataModule;
//---------------------------------------------------------------------------
#endif

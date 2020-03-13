//---------------------------------------------------------------------------

#ifndef UslFormUnitH
#define UslFormUnitH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TUslForm : public TForm
{
__published:	// IDE-managed Components
        TMemo *Memo;
private:	// User declarations
public:		// User declarations
        __fastcall TUslForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TUslForm *UslForm;
//---------------------------------------------------------------------------
#endif

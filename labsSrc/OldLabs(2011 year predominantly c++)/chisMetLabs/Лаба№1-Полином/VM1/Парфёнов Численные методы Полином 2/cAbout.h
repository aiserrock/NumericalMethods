//---------------------------------------------------------------------------

#ifndef cAboutH
#define cAboutH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <jpeg.hpp>
//---------------------------------------------------------------------------
class TAboutForm : public TForm
{
__published:	// IDE-managed Components
        TPanel *PhotoPanel;
        TImage *Image1;
        TPanel *AboutPanel;
private:	// User declarations
public:		// User declarations
        __fastcall TAboutForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TAboutForm *AboutForm;
//---------------------------------------------------------------------------
#endif

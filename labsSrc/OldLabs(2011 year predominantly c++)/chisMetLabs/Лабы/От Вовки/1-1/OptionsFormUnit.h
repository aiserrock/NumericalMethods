//---------------------------------------------------------------------------

#ifndef OptionsFormUnitH
#define OptionsFormUnitH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Buttons.hpp>
//---------------------------------------------------------------------------
class TOptionsForm : public TForm
{
__published:	// IDE-managed Components
        TGroupBox *GroupBoxFunction;
        TImage *ImageFunction;
        TEdit *EditAlpha;
        TEdit *EditBeta;
        TEdit *EditGamma;
        TEdit *EditDelta;
        TLabel *LabelAlpha;
        TLabel *LabelBeta;
        TLabel *LabelGamma;
        TLabel *LabelDelta;
        TLabel *LabelL;
        TGroupBox *GroupBoxChart;
        TLabel *LabelABCD;
        TLabel *LabelD;
        TLabel *LabelC;
        TLabel *LabelB;
        TLabel *LabelA;
        TEdit *EditD;
        TEdit *EditC;
        TEdit *EditB;
        TEdit *EditA;
        TGroupBox *GroupBoxOthers;
        TLabel *LabelNH;
        TLabel *LabelH;
        TLabel *LabelN;
        TEdit *EditN;
        TComboBox *ComboBoxH;
        TBitBtn *BitBtnOk;
        TBitBtn *BitBtnCancel;
        void __fastcall OptionsFormOnShow(TObject *Sender);
        void __fastcall BitBtnOkOnClick(TObject *Sender);
        void __fastcall BitBtnCancelOnClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TOptionsForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TOptionsForm *OptionsForm;
//---------------------------------------------------------------------------
#endif

//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Chart.hpp>
#include <ExtCtrls.hpp>
#include <Menus.hpp>
#include <Series.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <math.h>
#include <ComCtrls.hpp>
#include "CGAUGES.h"
#include <vector>

using namespace std;
//---------------------------------------------------------------------------
class TFormMain : public TForm
{
__published:	// IDE-managed Components
        TMainMenu *MainMenu1;
        TMenuItem *N1;
        TMenuItem *N4;
        TMenuItem *N5;
        TChart *Chart1;
        TLineSeries *Series1;
        TGroupBox *GroupBox1;
        TEdit *AlphaEdit;
        TEdit *BetaEdit;
        TEdit *GammaEdit;
        TEdit *DeltaEdit;
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TEdit *AEdit;
        TLabel *Label6;
        TEdit *BEdit;
        TLabel *Label7;
        TEdit *CEdit;
        TLabel *Label8;
        TEdit *DEdit;
        TLabel *Label9;
        TEdit *nEdit;
        TLabel *Label10;
        TComboBox *ComboBox1;
        TButton *Button1;
        TEdit *maxrEdit;
        TLabel *Label11;
        TLabel *Label12;
        TEdit *a_Edit;
        TEdit *b_Edit;
        TLabel *Label13;
        TLabel *Label14;
        TLabel *Label15;
        TRadioButton *RadioButtonAlpha;
        TRadioButton *RadioButtonBeta;
        TRadioButton *RadioButtonGamma;
        TRadioButton *RadioButtonDelta;
        TLabel *Label16;
        TButton *Button2;
        TCGauge *CGauge1;
        TLabel *Label17;
        TEdit *EpsilonEdit;
        TLabel *Label18;
        TRadioButton *RadioButtonEpsilon;
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall N4Click(TObject *Sender);
        void __fastcall N5Click(TObject *Sender);
        void __fastcall N3Click(TObject *Sender);
        void __fastcall Button2Click(TObject *Sender);
        void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
private:
        bool cancel;
        double abs_d(double x);
        double f(double x, double Alpha, double Beta, double Gamma, double Delta, double Epsilon);
        double integral(double a, double b, double Alpha, double Beta, double Gamma, double Delta, double Epsilon, int n);
public:		// User declarations
        __fastcall TFormMain(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormMain *FormMain;
//---------------------------------------------------------------------------
#endif

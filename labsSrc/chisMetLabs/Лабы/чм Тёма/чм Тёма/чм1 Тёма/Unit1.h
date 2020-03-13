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
#include <vector>

using namespace std;
//---------------------------------------------------------------------------
class TFormMain : public TForm
{
__published:	// IDE-managed Components
        TMainMenu *MainMenu1;
        TMenuItem *N1;
        TMenuItem *N2;
        TMenuItem *N3;
        TMenuItem *N4;
        TMenuItem *N5;
        TChart *Chart1;
        TLineSeries *Series1;
        TGroupBox *GroupBox1;
        TLineSeries *Series2;
        TLineSeries *Series3;
        TLineSeries *Series4;
        TLineSeries *Series5;
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
        TCheckBox *CheckBoxf;
        TCheckBox *CheckBoxPn;
        TCheckBox *CheckBoxrn;
        TCheckBox *CheckBoxdf;
        TCheckBox *CheckBoxdPn;
        TButton *Button1;
        TEdit *maxrEdit;
        TEdit *maxrxEdit;
        TLabel *Label11;
        TLabel *Label12;
        TEdit *EpsilonEdit;
        TLabel *Label13;
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall N4Click(TObject *Sender);
        void __fastcall N5Click(TObject *Sender);
        void __fastcall N3Click(TObject *Sender);
private:
        double abs_d(double x);
        double f(double x);
        double Pn(double x, int n, vector<vector<double> > &Tablrazn);
public:		// User declarations
        __fastcall TFormMain(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormMain *FormMain;
//---------------------------------------------------------------------------
#endif

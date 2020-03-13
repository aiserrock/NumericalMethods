//---------------------------------------------------------------------------

#ifndef MainFormUnitH
#define MainFormUnitH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Menus.hpp>
#include <Chart.hpp>
#include <ExtCtrls.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <Series.hpp>
#include <Graphics.hpp>
#include <Buttons.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TForm
{
__published:	// IDE-managed Components
        TMainMenu *MainMenu;
        TMenuItem *N1;
        TMenuItem *N2;
        TMenuItem *N4;
        TMenuItem *N5;
        TMenuItem *N6;
        TMenuItem *N7;
        TChart *Chart;
        TLineSeries *Series1;
        TLineSeries *Series2;
        TLineSeries *Series3;
        TLineSeries *Series4;
        TLineSeries *Series5;
        TPanel *PanelFormula;
        TImage *ImageFormula;
        TCheckBox *CheckBox1;
        TCheckBox *CheckBox2;
        TCheckBox *CheckBox3;
        TCheckBox *CheckBox4;
        TCheckBox *CheckBox5;
        TImage *ImageT;
        TSpeedButton *SpeedButton1;
        TSpeedButton *SpeedButton2;
        TSpeedButton *SpeedButton3;
        void __fastcall MainFormOnResize(TObject *Sender);
        void __fastcall N2Click(TObject *Sender);
        void __fastcall CheckBox1OnClick(TObject *Sender);
        void __fastcall CheckBox2OnClick(TObject *Sender);
        void __fastcall MainFormOnShow(TObject *Sender);
        void __fastcall CheckBox3OnClick(TObject *Sender);
        void __fastcall CheckBox4OnClick(TObject *Sender);
        void __fastcall CheckBox5OnClick(TObject *Sender);
        void __fastcall N4Click(TObject *Sender);
        void __fastcall MainFormOnClose(TObject *Sender,
          TCloseAction &Action);
        void __fastcall N7Click(TObject *Sender);
        void __fastcall N6Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        double alpha,beta,gamma,delta,H,h;
        int n;
        __fastcall TMainForm(TComponent* Owner);
        void FillTable();
        double Function(double x);
        double Polinom(double x);
        void DrawSeries1();
        void DrawSeries2();
        void DrawSeries3();
        void DrawSeries4();
        void DrawSeries5();
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif

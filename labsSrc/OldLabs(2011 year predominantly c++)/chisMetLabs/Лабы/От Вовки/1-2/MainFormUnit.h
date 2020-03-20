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
        TPanel *PanelFormula;
        TImage *ImageFormula;
        TSpeedButton *SpeedButton1;
        TSpeedButton *SpeedButton2;
        TSpeedButton *SpeedButton3;
        void __fastcall MenuClick(TObject *Sender);
        void __fastcall MainFormOnShow(TObject *Sender);
        void __fastcall MainFormOnClose(TObject *Sender,
          TCloseAction &Action);
private:	// User declarations
public:		// User declarations
        double alpha,beta,gamma,delta,h,a,b;
        int n,check;
        __fastcall TMainForm(TComponent* Owner);
        void DrawSeries1();
        double Integral(double N);
        double Function(double x);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif

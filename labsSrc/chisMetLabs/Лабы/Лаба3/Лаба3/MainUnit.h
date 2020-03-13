//---------------------------------------------------------------------------

#ifndef MainUnitH
#define MainUnitH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Buttons.hpp>
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Menus.hpp>
#include <Chart.hpp>
#include <Series.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include "CSPIN.h"
#include <jpeg.hpp>
#include "SHDocVw_OCX.h"
#include <OleCtrls.hpp>
#include <Dialogs.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TForm
{
__published:	// IDE-managed Components
        TMainMenu *MainMenu;
        TMenuItem *N1;
        TMenuItem *N11;
        TMenuItem *N13;
        TPanel *PanelOptions;
        TChart *Chart;
        TGroupBox *GBFunction;
        TMenuItem *N12;
        TEdit *EditAlpha;
        TLabel *LabelAlpha;
        TLabel *LabelBeta;
        TEdit *EditBeta;
        TLabel *LabelGamma;
        TEdit *EditGamma;
        TLabel *LabelDelta;
        TEdit *EditDelta;
        TGroupBox *GBField;
        TLabel *LabelC;
        TLabel *LabelB;
        TLabel *LabelA;
        TLabel *LabelD;
        TEdit *EditA;
        TEdit *EditB;
        TEdit *EditC;
        TEdit *EditD;
        TGroupBox *GBOthers;
        TLabel *LabelH;
        TLabel *LabelN;
        TButton *ButtonApply;
        TPanel *PanelAbout;
        TPanel *PanelPhoto;
        TImage *ImagePhoto;
        TLabel *LAboutTitle;
        TMemo *MemoAbout;
        TPanel *PanelTask;
        TLabel *LTaskTitle;
        TCppWebBrowser *CppWebBrowser;
        TGroupBox *GBColor;
        TLabel *LColorPlus;
        TLabel *LColorMinus;
        TColorDialog *ColorDialog;
        TLabel *LabelEpsilon;
        TEdit *EditEpsilon;
        TEdit *EditN;
        TComboBox *ComboBoxH;
        TLineSeries *Series1;
        void __fastcall OnClick(TObject *Sender);
        void __fastcall FormResize(TObject *Sender);
        void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
        void __fastcall ChartMouseDown(TObject *Sender,
          TMouseButton Button, TShiftState Shift, int X, int Y);
private:	// User declarations
public:		// User declarations
        __fastcall TMainForm(TComponent* Owner);
        void DrawSeries(long double x0,long double y0);
        int _matherrl (struct _exceptionl *e);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif

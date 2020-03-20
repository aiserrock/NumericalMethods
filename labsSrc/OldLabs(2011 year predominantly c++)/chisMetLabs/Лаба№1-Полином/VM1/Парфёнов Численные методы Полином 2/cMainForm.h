//---------------------------------------------------------------------------

#ifndef cMainFormH
#define cMainFormH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
#include <Chart.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <Series.hpp>
#include <jpeg.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TForm
{
__published:	// IDE-managed Components
        TPanel *FunctionPanel;
        TGroupBox *FunctionBox;
        TImage *FunctionPic;
        TEdit *AlphaEdit;
        TEdit *BettaEdit;
        TEdit *GammaEdit;
        TEdit *DeltaEdit;
        TGroupBox *ConfigBox;
        TPanel *GraphicsPanel;
        TEdit *AEdit;
        TEdit *BEdit;
        TEdit *CEdit;
        TEdit *DEdit;
        TEdit *NEdit;
        TComboBox *HComboBox;
        TGroupBox *GraphicsBox;
        TImage *GraphicsImage;
        TCheckBox *CheckF;
        TCheckBox *CheckP;
        TCheckBox *CheckR;
        TCheckBox *CheckdF;
        TCheckBox *CheckdP;
        TImage *GraphicView;
        TImage *Background;
        TImage *Graphic;
        TEdit *Edit1;
        TPanel *Panel2;
        TLabel *Label4;
        TLabel *Label6;
        TLabel *Label5;
        TLabel *Label7;
        TLabel *Label10;
        TLabel *Label11;
        TLabel *Label12;
        TLabel *Label13;
        TLabel *Label14;
        TLabel *Label15;
        TPanel *Panel1;
        TLabel *CureFunction;
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        void __fastcall AlphaEditKeyPress(TObject *Sender, char &Key);
        void __fastcall AlphaEditExit(TObject *Sender);
        void __fastcall BettaEditKeyPress(TObject *Sender, char &Key);
        void __fastcall BettaEditExit(TObject *Sender);
        void __fastcall GammaEditExit(TObject *Sender);
        void __fastcall GammaEditKeyPress(TObject *Sender, char &Key);
        void __fastcall DeltaEditKeyPress(TObject *Sender, char &Key);
        void __fastcall DeltaEditExit(TObject *Sender);
        void __fastcall GraphicViewClick(TObject *Sender);
        void __fastcall FormShow(TObject *Sender);
        void __fastcall CheckFClick(TObject *Sender);
        void __fastcall CheckPClick(TObject *Sender);
        void __fastcall CheckRClick(TObject *Sender);
        void __fastcall CheckdFClick(TObject *Sender);
        void __fastcall CheckdPClick(TObject *Sender);
        void __fastcall F_XChange(TObject *Sender);
        void __fastcall P_XChange(TObject *Sender);
        void __fastcall R_XChange(TObject *Sender);
        void __fastcall dF_XChange(TObject *Sender);
        void __fastcall dP_XChange(TObject *Sender);
        void __fastcall AEditKeyPress(TObject *Sender, char &Key);
        void __fastcall BEditKeyPress(TObject *Sender, char &Key);
        void __fastcall CEditKeyPress(TObject *Sender, char &Key);
        void __fastcall DEditKeyPress(TObject *Sender, char &Key);
        void __fastcall AEditExit(TObject *Sender);
        void __fastcall BEditExit(TObject *Sender);
        void __fastcall CEditExit(TObject *Sender);
        void __fastcall DEditExit(TObject *Sender);
        void __fastcall MainGraphicUndoZoom(TObject *Sender);
        void __fastcall NEditKeyPress(TObject *Sender, char &Key);
        void __fastcall NEditExit(TObject *Sender);
        void __fastcall HComboBoxKeyPress(TObject *Sender, char &Key);
        void __fastcall HComboBoxChange(TObject *Sender);
        void __fastcall ShowUzelClick(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall FormResize(TObject *Sender);
        void __fastcall Edit1Exit(TObject *Sender, char &Key);
        void __fastcall Edit1KeyPress(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TMainForm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif

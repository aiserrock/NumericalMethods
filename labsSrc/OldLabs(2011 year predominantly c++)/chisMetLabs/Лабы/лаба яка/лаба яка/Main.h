//---------------------------------------------------------------------------

#ifndef MainH
#define MainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <Chart.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <Series.hpp>
#include <jpeg.hpp>
#include "CSPIN.h"


#define MAXPARAM 100
#define MAXSIZE 1000
#define MAXNODECOUNT 200
#define MINNODECOUNT 2




//---------------------------------------------------------------------------
class TMainF : public TForm
{
__published:	// IDE-managed Components
    TPanel *Panel1;
    TButton *ExitB;
    TGroupBox *Opttions;
    TChart *Chart;
    TLineSeries *Fun;
    TGroupBox *Window;
    TGroupBox *Params;
    TGroupBox *WhatPaint;
    TGroupBox *ErrorP;
    TButton *DrawB;
    TCheckBox *FunG;
    TCheckBox *PolG;
    TCheckBox *DirFunG;
    TCheckBox *DirPolG;
    TCheckBox *ErrorG;
    TImage *Image;
    TEdit *AlphaT;
    TLabel *Label3;
    TLabel *Label4;
    TEdit *BetaT;
    TEdit *GammaT;
    TLabel *Label5;
    TLabel *Label2;
    TEdit *DeltaT;
    TComboBox *DX;
    TLabel *Label1;
    TLabeledEdit *MaxErrorP;
    TLabeledEdit *MaxError;
    TLabeledEdit *minXT;
    TLabeledEdit *minYT;
    TLabeledEdit *maxYT;
    TLabeledEdit *maxXT;
    TLabel *Label6;
    TLineSeries *DirFun;
    TLineSeries *Pol;
    TLineSeries *DirPol;
    TLineSeries *Error;
    TPointSeries *MError;
    TGroupBox *GroupBox1;
    TLabel *Label7;
    TLabel *Label8;
    TEdit *NodeCount;
    void __fastcall ExitBClick(TObject *Sender);
    void __fastcall DrawBClick(TObject *Sender);
    void __fastcall FormCreate(TObject *Sender);

private:
    double start, end, alpha, beta, gamma, delta, step,dx, h;
    int nodeCount;
    double *ValInNodes;
    double *DeltaY0;



    double Function (double arg);
    double DirFunction (double arg);
    double DirPolinom (double arg);
    double PolinomVal(double arg);
    int CheckData(void);
    void ApplyData(void);
    void DrawFunctions(void);
    void Preparation(void);
    void BuildPolinom(void);
    double CalcDeltaYi(int i);
public:		// User declarations
    __fastcall TMainF(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TMainF *MainF;
//---------------------------------------------------------------------------
#endif

//---------------------------------------------------------------------------

#ifndef UmainH
#define UmainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Buttons.hpp>
#include <Chart.hpp>
#include <ExtCtrls.hpp>
#include <Series.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <Menus.hpp>
#include <jpeg.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TPanel *Panel1;
        TPanel *Panel2;
        TChart *Chart1;
        TGroupBox *GroupBox1;
        TGroupBox *GroupBox2;
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TEdit *Ed_E;
        TEdit *Ed_a;
        TEdit *Ed_b;
        TLabel *Label6;
        TEdit *Ed_c;
        TEdit *Ed_d;
        TLabel *Label7;
        TLabel *Label8;
        TLabel *Label9;
        TEdit *EdkA;
        TEdit *EdkB;
        TEdit *EdkC;
        TEdit *EdkD;
        TLabel *Label10;
        TLabel *Label11;
        TEdit *Ed_n;
        TBitBtn *BitBtn1;
        TSpeedButton *SpeedButton1;
        TSpeedButton *SpeedButton2;
        TSpeedButton *SpeedButton3;
        TSpeedButton *SpeedButton4;
        TSpeedButton *SpeedButton5;
        TBitBtn *BitBtn2;
        TBitBtn *BitBtn3;
        TFastLineSeries *Series1;
        TFastLineSeries *Series2;
        TFastLineSeries *Series3;
        TFastLineSeries *Series4;
        TFastLineSeries *Series5;
        TFastLineSeries *Series6;
        TMainMenu *MainMenu1;
        TMenuItem *N1;
        TMenuItem *N3;
        TMenuItem *N4;
        TComboBox *Ed_h;
        TImage *Image1;
	TLabel *Label12;
        void __fastcall BitBtn1Click(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);

        float  __fastcall Pn(double x);
        float __fastcall fun(double t);

        void __fastcall BitBtn2Click(TObject *Sender);
        void __fastcall SpeedButton1Click(TObject *Sender);
        void __fastcall SpeedButton2Click(TObject *Sender);
        void __fastcall SpeedButton3Click(TObject *Sender);
        void __fastcall SpeedButton4Click(TObject *Sender);
        void __fastcall SpeedButton5Click(TObject *Sender);
        void __fastcall SpeedButton6Click(TObject *Sender);
        void __fastcall BitBtn3Click(TObject *Sender);
        void __fastcall N3Click(TObject *Sender);
        void __fastcall N4Click(TObject *Sender);
        void __fastcall Image2Click(TObject *Sender);
private:	// User declarations
public:
            long double A,B,C,D,E,a,b,c,d,h,step;
            int n;
            long double DY[200][200];
            long double Pn1, fun1, maxRn;
            int G1,G2,G3,G4,G5,G6;

            void __fastcall Draw();
	// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif

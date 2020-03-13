//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormMain *FormMain;
//---------------------------------------------------------------------------
__fastcall TFormMain::TFormMain(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

double TFormMain::abs_d(double x)
{
    return x >= 0 ? x : -x;
}

double TFormMain::f(double x)
{
    double arg1 = (x - StrToFloat(GammaEdit->Text))*(x - StrToFloat(GammaEdit->Text));
    if(arg1 < 0.000001)
        arg1 = 0.000001;
    return StrToFloat(AlphaEdit->Text)*sin(StrToFloat(BetaEdit->Text)/arg1) + StrToFloat(DeltaEdit->Text)*cos(StrToFloat(EpsilonEdit->Text)*x);
}

double TFormMain::Pn(double x, int n, vector<vector<double> > &Tablrazn)
{
    double a = Chart1->BottomAxis->Minimum;
    double h = (Chart1->BottomAxis->Maximum - a)/n;
    double x1 = (x - a)/h;
    double k = 1, k1, rez = Tablrazn[0][0];
    for (int i = 1; i <= n; ++i)
    {
        k1 = (double)(x1 - (i - 1))/(double)i;
        k *= k1;
        rez += Tablrazn[0][i]*k;
    }

    return rez;
}


void __fastcall TFormMain::Button1Click(TObject *Sender)
{
    int n;
    double Alpha, Beta, Gamma, Delta, Epsilon;
    double A,B,C,D;
    double shag, fx, Pnx, rnx, maxr = 0, maxrx, dx, h;
    vector<vector<double> > Tablrazn;
    vector<double> v;
    if (!TryStrToFloat(AEdit->Text, A) || !TryStrToFloat(BEdit->Text, B) || !TryStrToFloat(CEdit->Text, C) || !TryStrToFloat(DEdit->Text, D))
        Application->MessageBox("Неверно заданы параметры масштаба!", "Ошибка!", MB_OK);
    else
    if (A > 100 || A < -100 || B > 100 || B < -100 || C > 100 || C < -100 || D > 100 || D < -100)
        Application->MessageBox("Параметры масштаба должны быть от -100 до 100!", "Ошибка!", MB_OK);
    else
    if (A >= B || C >= D)
        Application->MessageBox("Неверно заданы параметры масштаба!", "Ошибка!", MB_OK);
    else
    if (!TryStrToFloat(AlphaEdit->Text, Alpha) || !TryStrToFloat(BetaEdit->Text, Beta) || !TryStrToFloat(GammaEdit->Text, Gamma) || !TryStrToFloat(DeltaEdit->Text, Delta) || !TryStrToFloat(EpsilonEdit->Text, Epsilon))
        Application->MessageBox("Неверно заданы параметры функции!", "Ошибка!", MB_OK);
    else
    if (Alpha > 100 || Alpha < -100 || Beta > 100 || Beta < -100 || Gamma > 100 || Gamma < -100 || Delta > 100 || Delta < -100 || Epsilon > 100 || Epsilon < -100)
        Application->MessageBox("Параметры функции должны быть от -100 до 100!", "Ошибка!", MB_OK);
    else
    if (!TryStrToInt(nEdit->Text, n))
        Application->MessageBox("Неверно задано число узлов интерполяции!", "Ошибка!", MB_OK);
    else
    if (n <= 0 || n > 200)
        Application->MessageBox("Число узлов интерполяции должно быть от 1 до 200!", "Ошибка!", MB_OK);
    else
    if(!TryStrToFloat(ComboBox1->Text, dx))
        Application->MessageBox("Неверно задано приращение!", "Ошибка!", MB_OK);
    else
    {
        shag = (B - A)/Chart1->Width;
        Chart1->Series[0]->Clear();
        Chart1->Series[1]->Clear();
        Chart1->Series[2]->Clear();
        Chart1->Series[3]->Clear();
        Chart1->Series[4]->Clear();
        if (A > Chart1->BottomAxis->Maximum)
        {
            Chart1->BottomAxis->Maximum = B;
            Chart1->BottomAxis->Minimum = A;
        }
        else
        {
            Chart1->BottomAxis->Minimum = A;
            Chart1->BottomAxis->Maximum = B;
        }
        if(C > Chart1->LeftAxis->Maximum)
        {
            Chart1->LeftAxis->Maximum = D;
            Chart1->LeftAxis->Minimum = C;
        }
        else
        {
            Chart1->LeftAxis->Minimum = C;
            Chart1->LeftAxis->Maximum = D;
        }
        h = (B - A)/n;
        for (int i = 0; i <= n; ++i)
            v.push_back(0);
        for (int i = 0; i <= n; ++i)
            Tablrazn.push_back(v);
        for (int i = 0; i <= n; ++i)
            Tablrazn[i][0] = f(A + i*h);
        for (int i = 1; i <= n; ++i)
            for (int j = 0; j <= n - i; ++j)
                Tablrazn[j][i] = Tablrazn[j + 1][i - 1] - Tablrazn[j][i - 1];
        for (double x = A; x <= B; x += shag)
        {
            fx = f(x);
            if (CheckBoxf->Checked)
                Chart1->Series[0]->AddXY(x, fx);
            Pnx = Pn(x, n, Tablrazn);
            if (CheckBoxPn->Checked)
                Chart1->Series[1]->AddXY(x, Pnx);
            rnx = Pnx - fx;
            if (CheckBoxrn->Checked)
                Chart1->Series[2]->AddXY(x, rnx);
            if (CheckBoxdf->Checked)
                Chart1->Series[3]->AddXY(x, (f(x + dx) - f(x))/dx);
            if (CheckBoxdPn->Checked)
                Chart1->Series[4]->AddXY(x, (Pn(x + dx, n, Tablrazn) - Pnx)/dx);
            if (abs_d(rnx) >= maxr)
            {
                maxr = abs_d(rnx);
                maxrx = x;
            }
        }
        maxrEdit->Text = FloatToStr(maxr);
        maxrxEdit->Text = FloatToStr(maxrx);
    }
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::N4Click(TObject *Sender)
{
    this->Button1Click(this);
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::N5Click(TObject *Sender)
{
    Application->Terminate();        
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::N3Click(TObject *Sender)
{
    FormAbout->Show();
}
//---------------------------------------------------------------------------


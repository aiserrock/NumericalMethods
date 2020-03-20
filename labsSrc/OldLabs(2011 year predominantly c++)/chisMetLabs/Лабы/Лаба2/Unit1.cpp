//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "CGAUGES"
#pragma resource "*.dfm"
TFormMain *FormMain;
//---------------------------------------------------------------------------
__fastcall TFormMain::TFormMain(TComponent* Owner)
        : TForm(Owner)
{
    cancel = 0;
}
//---------------------------------------------------------------------------

double TFormMain::abs_d(double x)
{
    return x >= 0 ? x : -x;
}

double TFormMain::f(double x, double Alpha, double Beta, double Gamma, double Delta, double Epsilon)
{
    double arg1 = (x - Gamma)*(x - Gamma);
    if(arg1 < 0.000001)
        arg1 = 0.000001;
    return Alpha*sin(Beta/arg1) + Delta*cos(Epsilon*x);
}

double TFormMain::integral(double a, double b, double Alpha, double Beta, double Gamma, double Delta, double Epsilon, int n)
{
    double h = (b - a)/n;
    double rez = 0;
    rez = (f(a, Alpha, Beta, Gamma, Delta, Epsilon) + f(b, Alpha, Beta, Gamma, Delta, Epsilon))/2;
    for(double x = a + h; x < b; x += h)
        rez += f(x, Alpha, Beta, Gamma, Delta, Epsilon);
    for(double x = a; x < b; x += h)
        rez += 2*f((x + x + h)/2, Alpha, Beta, Gamma, Delta, Epsilon);
    rez *= (h/3);
    return rez;
}

void __fastcall TFormMain::Button1Click(TObject *Sender)
{
    int n, n1, maxn = 0;
    double Alpha, Beta, Gamma, Delta, Epsilon, a1, b1;
    double A,B,C,D;
    double shag, I1, I2, rnx, dx;
    cancel = 0;
    if (!TryStrToFloat(AEdit->Text, A) || !TryStrToFloat(BEdit->Text, B) || !TryStrToFloat(CEdit->Text, C) || !TryStrToFloat(DEdit->Text, D))
        Application->MessageBox("Неверно заданы действительные параметры окна!", "Ошибка!", MB_OK);
    else
    if (A > 100 || A < -100 || B > 100 || B < -100 || C > 100 || C < -100 || D > 100 || D < -100)
        Application->MessageBox("Действительные параметры окна должны быть от -100 до 100!", "Ошибка!", MB_OK);
    else
    if (A >= B || C >= D)
        Application->MessageBox("Неверно заданы действительные параметры окна!", "Ошибка!", MB_OK);
    else
    if (!TryStrToFloat(AlphaEdit->Text, Alpha) || !TryStrToFloat(BetaEdit->Text, Beta) || !TryStrToFloat(GammaEdit->Text, Gamma) || !TryStrToFloat(DeltaEdit->Text, Delta) || !TryStrToFloat(EpsilonEdit->Text, Epsilon) || !TryStrToFloat(a_Edit->Text, a1) || !TryStrToFloat(b_Edit->Text, b1))
        Application->MessageBox("Неверно заданы действительные параметры!", "Ошибка!", MB_OK);
    else
    if (Alpha > 100 || Alpha < -100 || Beta > 100 || Beta < -100 || Gamma > 100 || Gamma < -100 || Delta > 100 || Delta < -100 || Epsilon > 100 || Epsilon < -100 || a1 > 100 || a1 < -100 || b1 > 100 || b1 < -100)
        Application->MessageBox("Действительные параметры должны быть от -100 до 100!", "Ошибка!", MB_OK);
    else
    if (!TryStrToInt(nEdit->Text, n))
        Application->MessageBox("Неверно задано начальное число разбиений!", "Ошибка!", MB_OK);
    else
    if (n <= 0 || n > 1000)
        Application->MessageBox("Начальное число разбиений должно быть от 1 до 1000!", "Ошибка!", MB_OK);
    else
    if(!TryStrToFloat(ComboBox1->Text, dx))
        Application->MessageBox("Неверно задана точность!", "Ошибка!", MB_OK);
    else
    {
        Button1->Enabled = 0;
        a_Edit->Enabled = 0;
        b_Edit->Enabled = 0;
        AlphaEdit->Enabled = 0;
        BetaEdit->Enabled = 0;
        GammaEdit->Enabled = 0;
        DeltaEdit->Enabled = 0;
        EpsilonEdit->Enabled = 0;
        AEdit->Enabled = 0;
        BEdit->Enabled = 0;
        CEdit->Enabled = 0;
        DEdit->Enabled = 0;
        nEdit->Enabled = 0;
        ComboBox1->Enabled = 0;
        RadioButtonAlpha->Enabled = 0;
        RadioButtonBeta->Enabled = 0;
        RadioButtonGamma->Enabled = 0;
        RadioButtonDelta->Enabled = 0;
        RadioButtonEpsilon->Enabled = 0;
        //MainMenu1->Items[2].Enabled = 0;
        CGauge1->ShowText = 1;
        shag = (B - A)/Chart1->Width;
        Chart1->Series[0]->Clear();
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
        if(RadioButtonAlpha->Checked)
        {
            Chart1->BottomAxis->Title->Caption = "Альфа";
            Chart1->LeftAxis->Title->Caption = "I (Альфа)";
            for(Alpha = A; Alpha <= B; Alpha += shag)
            {
                if(cancel)
                {
                    cancel = 0;
                    break;
                }
                Application->ProcessMessages();
                n1=n;
                while(1)
                {
                    Application->ProcessMessages();
                    if(cancel)
                        break;
                    if(n1 == n)
                        I1 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, n1);
                    I2 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, 2*n1);
                    if(abs_d(I1 - I2) < dx)
                    {
                        if (maxn < n1)
                            maxn = n1;
                        break;
                    }
                    else
                    {
                        I1 = I2;
                        n1 = 2*n1;
                    }
                }
                CGauge1->Progress = 100*(Alpha - A)/(B - A) + 1;
                Chart1->Series[0]->AddXY(Alpha, I2);
                maxrEdit->Text = IntToStr(maxn);
            }
        }
        if(RadioButtonBeta->Checked)
        {
            Chart1->BottomAxis->Title->Caption = "Бета";
            Chart1->LeftAxis->Title->Caption = "I (Бета)";
            for(Beta = A; Beta <= B; Beta += shag)
            {
                if(cancel)
                {
                    cancel = 0;
                    break;
                }
                Application->ProcessMessages();
                n1=n;
                while(1)
                {
                    Application->ProcessMessages();
                    if(cancel)
                        break;
                    if(n1 == n)
                        I1 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, n1);
                    I2 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, 2*n1);
                    if(abs_d(I1 - I2) < dx)
                    {
                        if (maxn < n1)
                            maxn = n1;
                        break;
                    }
                    else
                    {
                        I1 = I2;
                        n1 = 2*n1;
                    }
                }
                CGauge1->Progress = 100*(Beta - A)/(B - A) + 1;
                Chart1->Series[0]->AddXY(Beta, I2);
                maxrEdit->Text = IntToStr(maxn);
            }
        }
        if(RadioButtonGamma->Checked)
        {
            Chart1->BottomAxis->Title->Caption = "Гамма";
            Chart1->LeftAxis->Title->Caption = "I (Гамма)";
            for(Gamma = A; Gamma <= B; Gamma += shag)
            {
                if(cancel)
                {
                    cancel = 0;
                    break;
                }
                Application->ProcessMessages();
                n1=n;
                while(1)
                {
                    Application->ProcessMessages();
                    if(cancel)
                        break;
                    if(n1 == n)
                        I1 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, n1);
                    I2 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, 2*n1);
                    if(abs_d(I1 - I2) < dx)
                    {
                        if (maxn < n1)
                            maxn = n1;
                        break;
                    }
                    else
                    {
                        I1 = I2;
                        n1 = 2*n1;
                    }
                }
                CGauge1->Progress = 100*(Gamma - A)/(B - A) + 1;
                Chart1->Series[0]->AddXY(Gamma, I2);
                maxrEdit->Text = IntToStr(maxn);
            }
        }
        if(RadioButtonDelta->Checked)
        {
            Chart1->BottomAxis->Title->Caption = "Дельта";
            Chart1->LeftAxis->Title->Caption = "I (Дельта)";
            for(Delta = A; Delta <= B; Delta += shag)
            {
                if(cancel)
                {
                    cancel = 0;
                    break;
                }
                Application->ProcessMessages();
                n1=n;
                while(1)
                {
                    Application->ProcessMessages();
                    if(cancel)
                        break;
                    if(n1 == n)
                        I1 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, n1);
                    I2 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, 2*n1);
                    if(abs_d(I1 - I2) < dx)
                    {
                        if (maxn < n1)
                            maxn = n1;
                        break;
                    }
                    else
                    {
                        I1 = I2;
                        n1 = 2*n1;
                    }
                }
                CGauge1->Progress = 100*(Delta - A)/(B - A) + 1;
                Chart1->Series[0]->AddXY(Delta, I2);
                maxrEdit->Text = IntToStr(maxn);
            }
        }
        if(RadioButtonEpsilon->Checked)
        {
            Chart1->BottomAxis->Title->Caption = "Эпсилон";
            Chart1->LeftAxis->Title->Caption = "I (Эпсилон)";
            for(Epsilon = A; Epsilon <= B; Epsilon += shag)
            {
                if(cancel)
                {
                    cancel = 0;
                    break;
                }
                Application->ProcessMessages();
                n1=n;
                while(1)
                {
                    Application->ProcessMessages();
                    if(cancel)
                        break;
                    if(n1 == n)
                        I1 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, n1);
                    I2 = integral(a1, b1, Alpha, Beta, Gamma, Delta, Epsilon, 2*n1);
                    if(abs_d(I1 - I2) < dx)
                    {
                        if (maxn < n1)
                            maxn = n1;
                        break;
                    }
                    else
                    {
                        I1 = I2;
                        n1 = 2*n1;
                    }
                }
                CGauge1->Progress = 100*(Epsilon - A)/(B - A) + 1;
                Chart1->Series[0]->AddXY(Epsilon, I2);
                maxrEdit->Text = IntToStr(maxn);
            }
        }
        Button1->Enabled = 1;
        a_Edit->Enabled = 1;
        b_Edit->Enabled = 1;
        AlphaEdit->Enabled = 1;
        BetaEdit->Enabled = 1;
        GammaEdit->Enabled = 1;
        DeltaEdit->Enabled = 1;
        EpsilonEdit->Enabled = 1;
        AEdit->Enabled = 1;
        BEdit->Enabled = 1;
        CEdit->Enabled = 1;
        DEdit->Enabled = 1;
        nEdit->Enabled = 1;
        ComboBox1->Enabled = 1;
        RadioButtonAlpha->Enabled = 1;
        RadioButtonBeta->Enabled = 1;
        RadioButtonGamma->Enabled = 1;
        RadioButtonDelta->Enabled = 1;
        RadioButtonEpsilon->Enabled = 1;
        //MainMenu1->Items[2].Enabled = 1;
        CGauge1->ShowText = 0;
        CGauge1->Progress = 0;
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
    this->Button2Click(this);
    Application->Terminate();
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::N3Click(TObject *Sender)
{
    FormAbout->Show();
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::Button2Click(TObject *Sender)
{
    cancel = 1;
}
//---------------------------------------------------------------------------

void __fastcall TFormMain::FormClose(TObject *Sender, TCloseAction &Action)
{
    this->Button2Click(this);
    Application->Terminate();
}
//---------------------------------------------------------------------------



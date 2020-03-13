//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Main.h"
#include <math.h>

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "CSPIN"
#pragma resource "*.dfm"
TMainF *MainF;
//---------------------------------------------------------------------------
__fastcall TMainF::TMainF(TComponent* Owner)
    : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainF::ExitBClick(TObject *Sender)
{
    MainF->Close();
}
//---------------------------------------------------------------------------
double TMainF::Function(double arg)
{

    double argCos;
    double temp = fabs(arg);
    try
    {
        argCos = pow(temp,delta);
        if(argCos == HUGE_VAL)
            argCos = 1;
    }
    catch(...)
    {
        argCos = 1;
    }
    double argSin = beta*arg;
    double val = alpha*sin(argSin)+gamma*cos(argCos);
    return val;



}
//---------------------------------------------------------------------------
double TMainF::PolinomVal(double arg)
{
    double sum;
    double buf;


    sum = DeltaY0[0];
    buf = 1.0;
    for(int i=1;i<nodeCount; i++)
    {
        if(fabs(buf)<0.00001)
            break;
        try
        {
            buf *= (arg - (start+(i-1)*h))/(i*h);
        }
        catch(...)
        {
            return sum;
        }
        sum +=  DeltaY0[i]*buf;
    }
    return sum;
}

//---------------------------------------------------------------------------

double TMainF::DirFunction(double  arg)
{
    double temp = Function(arg+dx)-Function(arg);
    return temp/dx;

}
//---------------------------------------------------------------------------
double TMainF::DirPolinom(double arg)
{
    double temp = PolinomVal(arg+dx)-PolinomVal(arg);
    return temp/dx;
}
//---------------------------------------------------------------------------
void TMainF::DrawFunctions(void)
{

    if(FunG->Checked)
        Fun->Active = true;
    if(DirFunG->Checked)
        DirFun->Active = true;
    if(PolG->Checked)
        Pol->Active = true;
    if(DirPolG->Checked)
        DirPol->Active = true;
    if(ErrorG->Checked)
        Error->Active = true;
    if(FunG->Checked || PolG->Checked || ErrorG->Checked)
        MError->Active = true;



    double f,df,p,dp,er;
    double maxYError, maxXError;
    maxYError=0.0;
    maxXError=0.0;
    for(int i=0;i<Chart->ChartWidth;i++)
    {
        if(FunG->Checked || PolG->Checked || ErrorG->Checked)
        {
            f = Function(start+i*step);
            p = PolinomVal(start+i*step);
            er = fabs(f-p);
            if(er>maxYError)
            {
                maxYError = er;
                maxXError = start+i*step;
            }

        }
        if(FunG->Checked)
        {
            f = Function(start+i*step);
            Fun->AddXY(start+i*step,f,"",Fun->SeriesColor);
        }

        if(DirFunG->Checked)
        {
            df = DirFunction(start+i*step);
            DirFun->AddXY(start+i*step,df,"",DirFun->SeriesColor);
        }
        if(PolG->Checked)
        {

            Pol->AddXY(start+i*step,p,"",Pol->SeriesColor);
        }
        if(DirPolG->Checked)
        {
            dp = DirPolinom(start+i*step);
            DirPol->AddXY(start+i*step,dp,"",DirPol->SeriesColor);
        }

        if(ErrorG->Checked)
           Error->AddXY(start+i*step,er,"",Error->SeriesColor);

    }

    MError->AddXY(maxXError,(Chart->LeftAxis->Minimum + Chart->LeftAxis->Maximum)/2,"",MError->SeriesColor);
    if(FunG->Checked || PolG->Checked || ErrorG->Checked)
    {
        MaxError->Text =  AnsiString(maxYError);
        MaxErrorP->Text = AnsiString(maxXError);
    }
}
//---------------------------------------------------------------------------
void TMainF::ApplyData(void)
{
    alpha = StrToFloat(AlphaT->Text);
    beta = StrToFloat(BetaT->Text);
    gamma = StrToFloat(GammaT->Text);
    delta = StrToFloat(DeltaT->Text);
    nodeCount = StrToInt(NodeCount->Text);
    start = StrToFloat(minXT->Text);
    end = StrToFloat(maxXT ->Text);

    switch (DX->ItemIndex)
    {
        case 0: dx = 1.0; break;
        case 1: dx = 0.1; break;
        case 2: dx = 0.01; break;
        case 3: dx = 0.001; break;
        case 4: dx = 0.0001;
    }
}
//---------------------------------------------------------------------------
void TMainF::Preparation(void)
{

    step = (end - start)/Chart->ChartWidth;

    Fun->Active = false;
    DirFun->Active = false;
    Pol->Active = false;
    DirPol->Active = false;
    Error->Active = false;
    MError->Active = false;

    Fun->Clear();
    DirFun->Clear();
    Pol->Clear();
    DirPol->Clear();
    Error->Clear();
    MError->Clear();

    minXT->Text = FloatToStr(start);
    maxXT ->Text = FloatToStr(end);
    minYT->Text = FloatToStr(StrToFloat(minYT->Text));
    maxYT->Text = FloatToStr(StrToFloat(maxYT->Text));
    try
    {
        Chart->LeftAxis->Minimum = StrToFloat(minYT->Text);
        Chart->LeftAxis->Maximum = StrToFloat(maxYT->Text);
        Chart->BottomAxis->Minimum = start;
        Chart->BottomAxis->Maximum = end;
    }
    catch (...)
    {
        Application->MessageBoxA("Проблемы с диапозоном","Внимание!",MB_ICONSTOP + MB_OK);
    }


}
//---------------------------------------------------------------------------
void TMainF::BuildPolinom(void)
{

    if(ValInNodes)
        delete [] ValInNodes;
    ValInNodes = new double [nodeCount];
   
    h = (end-start)/(nodeCount-1);
    int i;
    for (i=0;i<nodeCount;i++)
        ValInNodes[i] = Function(start+i*h);

    if(DeltaY0)
        delete [] DeltaY0;
    DeltaY0 = new double [nodeCount];

    for (i=0;i<nodeCount;i++)
       DeltaY0[i] = CalcDeltaYi(i);

    delete [] ValInNodes;


}

//---------------------------------------------------------------------------
double  TMainF::CalcDeltaYi(int k)
{
    if(!k)
        return ValInNodes[0];
    int i;
    double  *temp = new double  [nodeCount-k];
    for (i=1;i<nodeCount-k+1;i++)
        temp[i-1] = ValInNodes[i] - ValInNodes[i-1];
    delete[] ValInNodes;
    ValInNodes = temp;
    return ValInNodes[0];
}
//---------------------------------------------------------------------------
void __fastcall TMainF::DrawBClick(TObject *Sender)
{
    if(!CheckData())
        return;
    ApplyData();
    Preparation();
    BuildPolinom();
    DrawFunctions();
}
//---------------------------------------------------------------------------

int TMainF::CheckData(void)

{
    double temp;

    if(!TryStrToFloat((minXT->Text),temp))
    {
        Application->MessageBoxA((minXT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        minXT->Focused();
        return 0;
    }

    if(!TryStrToFloat((maxXT->Text),temp))
    {
        Application->MessageBoxA((maxXT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        maxXT->Focused();
        return 0;
    }

    if(!TryStrToFloat((minYT->Text),temp))
    {
        Application->MessageBoxA((minYT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        minYT->Focused();
        return 0;
    }

    if(!TryStrToFloat((maxYT->Text),temp))
    {
        Application->MessageBoxA((maxYT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        maxYT->Focused();
        return 0;
    }




    if(!TryStrToFloat((AlphaT->Text),temp))
    {
        Application->MessageBoxA((AlphaT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        AlphaT->Focused();
        return 0;
    }

    if(!TryStrToFloat((BetaT->Text),temp))
    {
        Application->MessageBoxA((BetaT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        BetaT->Focused();
        return 0;
    }

    if(!TryStrToFloat((DeltaT->Text),temp))
    {
        Application->MessageBoxA((DeltaT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        DeltaT->Focused();
        return 0;
    }

    if(!TryStrToFloat((GammaT->Text),temp))
    {
        Application->MessageBoxA((GammaT->Text + " не является числом с плавающей точкой").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        GammaT->Focused();
        return 0;
    }

    int t;
    if(!TryStrToInt(NodeCount->Text,t))
    {
        Application->MessageBoxA((NodeCount->Text + " не является целым числом").c_str(),"Внимание!",MB_ICONSTOP + MB_OK);
        GammaT->Focused();
        return 0;
    }

    if(!FunG->Checked && !PolG->Checked)
    if(!DirFunG->Checked && ! DirPolG->Checked)
    if(!ErrorG->Checked)
    {
        Application->MessageBoxA("Нужно отметить что рисовать","Внимание!",MB_ICONSTOP + MB_OK);
        FunG->Focused();
        return 0;
    }

    if(StrToFloat(minXT->Text) >= StrToFloat(maxXT->Text))
    {
        Application->MessageBoxA("Конец промежутка должен быть больше начала","Внимание!",MB_ICONSTOP + MB_OK);
        minXT->Focused();
        return 0;
    }

    if(StrToFloat(minYT->Text) >= StrToFloat(maxYT->Text))
    {
        Application->MessageBoxA("Конец промежутка должен быть больше начала","Внимание!",MB_ICONSTOP + MB_OK);
        minYT->Focused();
        return 0;
    }

    if(fabs(StrToFloat(minYT->Text))>MAXSIZE)
    {
        Application->MessageBoxA("Допустимые значения от -1000 до 1000","Внимание!",MB_ICONSTOP + MB_OK);
        minYT->Focused();
        return 0;
    }

    if(fabs(StrToFloat(maxYT->Text))>MAXSIZE)
    {
        Application->MessageBoxA("Допустимые значения от -1000 до 1000","Внимание!",MB_ICONSTOP + MB_OK);
        maxYT->Focused();
        return 0;
    }

    if(fabs(StrToFloat(minXT->Text))>MAXSIZE)
    {
        Application->MessageBoxA("Допустимые значения от -1000 до 1000","Внимание!",MB_ICONSTOP + MB_OK);
        minXT->Focused();
        return 0;
    }

    if(fabs(StrToFloat(maxXT->Text))>MAXSIZE)
    {
        Application->MessageBoxA("Допустимые значения от -1000 до 1000","Внимание!",MB_ICONSTOP + MB_OK);
        maxXT->Focused();
        return 0;
    }

    if(StrToInt(NodeCount->Text)<2 || StrToInt(NodeCount->Text)>200)
    {
        Application->MessageBoxA("Количество узлов лежит в диапозоне от 2 до 200","Внимание!",MB_ICONSTOP + MB_OK);
        maxXT->Focused();
        return 0;
    }


    if(fabs(StrToFloat(AlphaT->Text))>MAXPARAM)
    {
        Application->MessageBoxA("Параметр ALPHA должен быть по модулю меньше 100","Внимание!",MB_ICONSTOP + MB_OK);
        AlphaT->Focused();
        return 0;
    }

    if(fabs(StrToFloat(AlphaT->Text))>MAXPARAM)
    {
        Application->MessageBoxA("Параметр ALPHA должен быть по модулю меньше 100","Внимание!",MB_ICONSTOP + MB_OK);
        AlphaT->Focused();
        return 0;
    }
    if(fabs(StrToFloat(BetaT->Text))>MAXPARAM)
    {
        Application->MessageBoxA("Параметр BETA должен быть по модулю меньше 100","Внимание!",MB_ICONSTOP + MB_OK);
        BetaT->Focused();
        return 0;
    }
    if(fabs(StrToFloat(DeltaT->Text))>MAXPARAM)
    {
        Application->MessageBoxA("Параметр DELTA должен быть по модулю меньше 100","Внимание!",MB_ICONSTOP + MB_OK);
        DeltaT->Focused();
        return 0;
    }
    if(fabs(StrToFloat(GammaT->Text))>MAXPARAM)
    {
        Application->MessageBoxA("Параметр GAMMA должен быть по модулю меньше 100","Внимание!",MB_ICONSTOP + MB_OK);
        GammaT->Focused();
        return 0;
    }

    return 1;
}

//---------------------------------------------------------------------------

void __fastcall TMainF::FormCreate(TObject *Sender)
{
    ValInNodes = NULL;

    Fun->Active = false;
    DirFun->Active = false;
    Pol->Active = false;
    DirPol->Active = false;
    Error->Active = false;
    MError->Active = false;
}
//---------------------------------------------------------------------------





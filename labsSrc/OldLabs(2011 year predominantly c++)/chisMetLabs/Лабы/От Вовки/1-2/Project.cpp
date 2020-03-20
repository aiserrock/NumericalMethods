//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
//---------------------------------------------------------------------------
USEFORM("MainFormUnit.cpp", MainForm);
USEFORM("OptionsFormUnit.cpp", OptionsForm);
USEFORM("AboutFormUnit.cpp", AboutForm);
USEFORM("UslFormUnit.cpp", UslForm);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
        try
        {
                 Application->Initialize();
                 Application->CreateForm(__classid(TMainForm), &MainForm);
                 Application->CreateForm(__classid(TOptionsForm), &OptionsForm);
                 Application->CreateForm(__classid(TAboutForm), &AboutForm);
                 Application->CreateForm(__classid(TUslForm), &UslForm);
                 Application->Run();
        }
        catch (Exception &exception)
        {
                 Application->ShowException(&exception);
        }
        catch (...)
        {
                 try
                 {
                         throw Exception("");
                 }
                 catch (Exception &exception)
                 {
                         Application->ShowException(&exception);
                 }
        }
        return 0;
}
//---------------------------------------------------------------------------

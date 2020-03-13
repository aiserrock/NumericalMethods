//---------------------------------------------------------------------------


#pragma hdrstop

#include "cCor.h"

//---------------------------------------------------------------------------

#pragma package(smart_init)

bool CheckNumber(char *num)
{
        if(num[0] == '-')
                return true;
        else
                return false;
}

bool ChekPoint(char *num)
{
        for(int i = 0 ; num[i]!=NULL ; i++)
                if(num[i] == ',')
                        return true;;

        return false;
}

bool IsOk(TEdit *TextEdit, char Key)
{
        if(Key == '-')
        {
                if(CheckNumber(TextEdit->Text.c_str()) || TextEdit->Text.Length() > 0)
                {
                        Beep(500,50);
                        return false;
                }
        }
        else if(Key == ',')
        {
                if(ChekPoint(TextEdit->Text.c_str()))
                {
                        Beep(500,50);
                        return false;
                }
        }
        else  if(!(Key >= '0' && Key <= '9') && Key != '-' && Key != '\b' && Key != ',')
        {
                Beep(500,50);
                return false;
        }
        else if (TextEdit->Text.Length() > 5 && Key != '\b')
        {
                Beep(500,50);
                return false;
        }

        return true;
}

void IsApply(TEdit *TextEdit)
{
        if (TextEdit->Text.Length() > 1)
        {
                if(TextEdit->Text.ToDouble() < -100)
                {
                        Beep(500,50);
                        TextEdit->Text = "-100";
                }
                else if(TextEdit->Text.ToDouble() > 100)
                {
                        Beep(500,50);
                        TextEdit->Text = "100";
                }
        }
        else
        {
                if(TextEdit->Text.Length() == 1)
                {
                        if(CheckNumber(TextEdit->Text.c_str()))
                        {
                                TextEdit->Text = "1";
                                Beep(500,50);
                        }
                }
                else
                {
                        TextEdit->Text = "1";
                        Beep(500,50);
                }
        }
}

int Interpolation::Convert(int Degree, int k)
{
        return (k*c_N + Degree - 1);
}

void Interpolation::GenerateFinalDifference()
{
        if(c_Difference != NULL)
        {
                delete[] c_Difference;
                c_Difference = NULL;
        }

        c_Difference = new long double[(c_N - 1 ) * (c_N - 1) + 1];
                                                           
        int k = 0, _deg = 0;                            

        for(k = 0 ; k < (c_N - 1) ; k++)
                        c_Difference[Convert(1, k)] =  ( c_Uzli[k + 1] - c_Uzli[k] );

        for(_deg = 2 ; _deg < c_N ; _deg++)
                for(k = 0 ; k < (c_N - _deg) ; k++)
                        c_Difference[Convert(_deg, k)] =  (c_Difference[Convert(_deg - 1, k + 1)] - c_Difference[Convert(_deg - 1, k)]);

        c_Difference[(c_N - 1 ) * (c_N - 1)] = NULL;
}

Interpolation::Interpolation()
{
        c_Alpha = 1;
        c_Betta = 1;
        c_Gamma = 1;
        c_Delta = 1;
        c_Eps = 1;
        c_Mui = 1;

        c_A = -20;
        c_B = 20;
        c_C = -20;
        c_D = 20;

        IsCashid = false;

        c_N = 2;
        c_H = 1.0f;
        c_Steep = 1.0f;
        c_Uzli = NULL;
        c_Difference = NULL;

        IGraphs = NULL;
        IBackground = NULL;
}

Interpolation::~Interpolation()
{
        if(c_Uzli!=NULL)
        {
                delete[] c_Uzli;
                c_Uzli = NULL;
        }

        if(c_Difference != NULL)
        {
                delete[] c_Difference;
                c_Difference = NULL;
        }
}

void Interpolation::Point(TColor color, int x, int y )
{
	// сплошное перо тройной толщины
	IGraphs->Canvas->Pen->Color = color;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 3;

	// ставим "жирную" точку
	IGraphs->Canvas->Rectangle( x - 1, y - 1, x + 1, y + 1 );
}

void Interpolation::ClearBackground()
{
	IBackground->Canvas->Brush->Color = clWhite;

	IBackground->Canvas->FillRect( TRect( 0, 0, IBackground->Width, IBackground->Height ) );
}

void Interpolation::ClearGraphs()
{
	IGraphs->Canvas->Brush->Color = clWhite;

	IGraphs->Canvas->FillRect( TRect( 0, 0, IGraphs->Width, IGraphs->Height ) );
}

void Interpolation::DrawAxes()
{
	// черное сплошное перо тройной толщины
	IBackground->Canvas->Pen->Color = clBlack;
	IBackground->Canvas->Pen->Width = 2;
	IBackground->Canvas->Pen->Style = psSolid;

	// вертикальная ось
	IBackground->Canvas->MoveTo( 2 * SPACE - 10, SPACE );
	IBackground->Canvas->LineTo( 2 * SPACE - 10, IBackground->Height - 2 * SPACE );

	// горизонтальная ось
	IBackground->Canvas->MoveTo( 2 * SPACE, IBackground->Height - 2 * SPACE + 10 );
	IBackground->Canvas->LineTo( IBackground->Width - SPACE, IBackground->Height - 2 * SPACE + 10 );

	// зарубки на осях
	for( int i = 0; i < LINES_COUNT; i++ )
	{
		// на вертикальной оси
		IBackground->Canvas->MoveTo( 2 * SPACE - 10 ,
									 SPACE + ( IBackground->Height - 3 * SPACE ) * i / ( LINES_COUNT - 1 ) );
		IBackground->Canvas->LineTo( 2 * SPACE - 10 + 5,
									 SPACE + ( IBackground->Height - 3 * SPACE ) * i / ( LINES_COUNT - 1 ) );

		// на горизонтальной оси
		IBackground->Canvas->MoveTo( 2 * SPACE + ( IBackground->Width - 3 * SPACE ) * i / ( LINES_COUNT - 1 ),
									 IBackground->Height - 2 * SPACE + 10 - 5 );
		IBackground->Canvas->LineTo( 2 * SPACE + ( IBackground->Width - 3 * SPACE ) * i / ( LINES_COUNT - 1 ),
									 IBackground->Height - 2 * SPACE + 10  );
	}
           /*
	// серое пунктирное перо одинарной толщины
	IBackground->Canvas->Pen->Color = clGray;
	IBackground->Canvas->Pen->Width = 1;
	IBackground->Canvas->Pen->Style = psDot;

	// координатная сетка
	for( int i = 0; i < LINES_COUNT; i++ )
	{
		// вертикальные линии
		IBackground->Canvas->MoveTo( 2 * SPACE + ( IBackground->Width - 3 * SPACE ) * i / ( LINES_COUNT - 1 ),
									 SPACE );
		IBackground->Canvas->LineTo( 2 * SPACE + ( IBackground->Width - 3 * SPACE ) * i / ( LINES_COUNT - 1 ),
									 IBackground->Height - 2 * SPACE );

		// горизонтальные линии
		IBackground->Canvas->MoveTo( 2 * SPACE,
									 SPACE + ( IBackground->Height - 3 * SPACE ) * i / ( LINES_COUNT - 1 ) );
		IBackground->Canvas->LineTo( IBackground->Width - SPACE,
									 SPACE + ( IBackground->Height - 3 * SPACE ) * i / ( LINES_COUNT - 1 ) );
	} */
}

void Interpolation::PrintScale()
{
	AnsiString text; // текущее число в виде строки

	// значения на осях
	for( int i = 0; i < LINES_COUNT; i++ )
	{
		// горизонтальная ось
		text = AnsiString( Round( c_A + ( c_B - c_A ) * i / ( LINES_COUNT - 1 ) ) );
		IBackground->Canvas->TextOut( 2 * SPACE - IBackground->Canvas->TextWidth( text ) / 2 + ( IBackground->Width - 3 * SPACE ) * i / ( LINES_COUNT - 1 ),
									  IBackground->Height - 2 * SPACE + 10 + 10,
									  text );

		// вертикальная ось
		text = AnsiString( Round( c_D + ( c_C - c_D ) * i / ( LINES_COUNT - 1 ) ) );
		IBackground->Canvas->TextOut( 2 * SPACE - 10 - IBackground->Canvas->TextWidth( text ) - 10,
									  SPACE + ( IBackground->Height - 3 * SPACE ) * i / ( LINES_COUNT - 1 ) - 6,
									  text );
	}
}

double Interpolation::R( double x )
{
	double rez; // результат

	// считаем результат
	rez = F( x ) - P( x );

	// обрезаем его, если необходимо
	if( rez > 1000 )
		return 1111;
	if( rez < -1000 )
		return -1111;
	return rez;
}

double Interpolation::F(double x)
{
        long double rez = 0.0f; // результат

	long double xp = 0.0f; // промежуточный результат - модуль икса в степени бета

	if( x == 0.0f ) // а стоит ли вообще считать первое слагаемое: sin( 0 ) = 0
	{
		// считаем степень
                if(c_Delta == 0)
                {
                        xp = 1.0f;
                }
                else
                {
		        if(x >= 0)
		                xp = pow( x , c_Delta );
                        else
                                xp = pow( -x , c_Delta );
                }

		// и обрезаем ее, пользуясь тем, что косинус имеет период
	      	while( xp > 1e+10 * PI )
			xp /= 1e+10 * PI;

		// считаем окончательный результат
		rez = c_Gamma * cos( xp );
	}
	else
	{
		// считаем степень
                if(c_Delta == 0)
                {
                        xp = 1;
                }
                else
                {
		        if(x >= 0)
		                xp = pow( x , c_Delta );
                        else
                                xp = pow( -x , c_Delta );
                }

		// и обрезаем ее, пользуясь тем, что косинус имеет период
	      	while( xp > 1e+10 * PI )
			xp /= 1e+10 * PI;

		// считаем окончательный результат
                if((c_Gamma == x) || (c_Mui == x)) rez = 1001;
                else
                        rez = c_Alpha * sin( c_Betta / (x - c_Gamma) / (x - c_Gamma)) + c_Delta * cos( c_Eps / (x - c_Mui) / (x - c_Mui));
	}

     	// обрезаем его, если необходимо
        if( rez > 1000 )
		return 1111;
	if( rez < -1000 )
		return -1111;

	return rez;
}

double Interpolation::DF( double x )
{
	double rez; // результат

	// считаем результат
	rez = ( F( x + c_H ) - F( x ) ) / c_H;

	// обрезаем его, если необходимо
	if( rez > 1000 )
		return 1111;
	if( rez < -1000 )
		return -1111;
	return rez;
}

double Interpolation::P(double x)
{
        long double Result = 0.0f;     
        long double Chislitel = 1.0f;

        Result = c_Uzli[0];
        Chislitel = ( (x - c_A) / c_Steep );

        Result += Chislitel * c_Difference[Convert(1,0)];

        for(int i = 2 ; i < c_N; i++)
        {
                Chislitel *= ( (x - (c_Steep*(i - 1) + c_A)) / ( i * c_Steep ) );

                Result += Chislitel * c_Difference[Convert(i,0)];

        }

        if( Result > 1000 )
		return 1111;
	if( Result < -1000 )
		return -1111;

        return Result;
}

double Interpolation::DP( double x )
{
	double rez; // результат

	// считаем результат
	rez = ( P( x + c_H ) - P( x ) ) / c_H;

	// обрезаем его, если необходимо
	if( rez > 1000 )
		return 1111;
	if( rez < -1000 )
		return -1111;
	return rez;
}

void Interpolation::Print_F()
{
        double a, b, c, d; // границы области интерполирования
	double x = 0.0f, y; // логические координаты
	int u, v; // экранные координаты

	// сплошное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clMenuHighlight;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 1;

	// получаем константы
	a = c_A;
	b = c_B;
	c = c_C;
	d = c_D;

	// расчитываем начальные координаты
	x = a;                                       
	y = F( x );
	u = 0;

	v = IGraphs->Height * ( y - d ) / ( c - d );

	// и ставим перо в начальную точку
	IGraphs->Canvas->MoveTo( u, v );

	for( int i = 0; i < IGraphs->Width; i += 1 ) // идем по иксам и соединяем точки линиями
	{
		// пересчитываем координаты
		x = a + i * ( b - a ) / ( IGraphs->Width - 1 );
		y = F( x );
		u = i;
		v = IGraphs->Height * ( y - d ) / ( c - d );

		// и рисуем очередую линию, обрезая ее, если нужно, у границы экрана
		if( v < 0 )
			IGraphs->Canvas->LineTo( u, -1 );
		else if( v >= IGraphs->Height )
			IGraphs->Canvas->LineTo( u, IGraphs->Height );
		else
			IGraphs->Canvas->LineTo( u, v );
	}
}

void Interpolation::Print_DF()
{
        double a, b, c, d; // границы области интерполирования
	double x = 0.0f, y; // логические координаты
	int u, v; // экранные координаты

	// сплошное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clBlue;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 1;

	// получаем константы
        a = c_A;
	b = c_B;
	c = c_C;
	d = c_D;

	// расчитываем начальные координаты
	x = a;
	y = DF( x );
	u = 0;
	v = IGraphs->Height * ( y - d ) / ( c - d );

	// и ставим перо в начальную точку
	IGraphs->Canvas->MoveTo( u, v );

	for( int i = 0; i < IGraphs->Width; i += 1 ) // идем по иксам и соединяем точки линиями
	{
		// пересчитываем координаты
		x = a + i * ( b - a ) / ( IGraphs->Width - 1 );
		y = DF( x );
		u = i;
		v = IGraphs->Height * ( y - d ) / ( c - d );

		// и рисуем очередую линию, обрезая ее, если нужно, у границы экрана
		if( v < 0 )
			IGraphs->Canvas->LineTo( u, -1 );
		else if( v >= IGraphs->Height )
			IGraphs->Canvas->LineTo( u, IGraphs->Height );
		else
			IGraphs->Canvas->LineTo( u, v );
	}
}

void Interpolation::Print_P()
{
        double a, b, c, d; // границы области интерполирования
	double x = 0.0f, y; // логические координаты
	int u, v; // экранные координаты
	double p; // координаты опорных точек

	// сплошное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clRed;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 1;

	// получаем константы
	a = c_A;
	b = c_B;
	c = c_C;
	d = c_D;

	// расчитываем начальные координаты
	x = a;
	y = P( x );
	u = 0;
	v = IGraphs->Height * ( y - d ) / ( c - d );

	// и ставим перо в начальную точку
	IGraphs->Canvas->MoveTo( u, v );

	for( int i = 0; i < IGraphs->Width; i += 1 ) // идем по иксам и соединяем точки линиями
	{
		// пересчитываем координаты
		x = a + i * ( b - a ) / ( IGraphs->Width - 1 );
		y = P( x );
		u = i;
		v = IGraphs->Height * ( y - d ) / ( c - d );

		// и рисуем очередую линию, обрезая ее, если нужно, у границы экрана
		if( v < 0 )
			IGraphs->Canvas->LineTo( u, -1 );
		else if( v >= IGraphs->Height )
			IGraphs->Canvas->LineTo( u, IGraphs->Height );
		else
			IGraphs->Canvas->LineTo( u, v );
	}

	// рисуем опорные точки
	for( p = c_A; p <= c_B; p += ( c_B - c_A ) / ( c_N - 1 ) )
		Point(clRed, ( p - c_A ) * ( IGraphs->Width - 1 ) / ( c_B - c_A ), IGraphs->Height * ( F( p ) - c_D ) / ( c - c_D ) );

}

void Interpolation::Print_DP()
{
        double a, b, c, d; // границы области интерполирования
	double x = 0.0f, y; // логические координаты
	int u, v; // экранные координаты

	// сплошное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clFuchsia;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 1;

	// получаем константы
        a = c_A;
	b = c_B;
	c = c_C;
	d = c_D;

	// расчитываем начальные координаты
	x = a;
	y = DP( x );
	u = 0;
	v = IGraphs->Height * ( y - d ) / ( c - d );

	// и ставим перо в начальную точку
	IGraphs->Canvas->MoveTo( u, v );

	for( int i = 0; i < IGraphs->Width; i += 1 ) // идем по иксам и соединяем точки линиями
	{
		// пересчитываем координаты
		x = a + i * ( b - a ) / ( IGraphs->Width - 1 );
		y = DP( x );
		u = i;
		v = IGraphs->Height * ( y - d ) / ( c - d );

		// и рисуем очередую линию, обрезая ее, если нужно, у границы экрана
		if( v < 0 )
			IGraphs->Canvas->LineTo( u, -1 );
		else if( v >= IGraphs->Height )
			IGraphs->Canvas->LineTo( u, IGraphs->Height );
		else
			IGraphs->Canvas->LineTo( u, v );
	}
}

void Interpolation::Print_R()
{
        double a, b, c, d; // границы области интерполирования
	double x = 0.0f, y; // логические координаты
	int u, v; // экранные координаты
	double max_u, max_y, max_v, max_x; // координаты точки наибольшего отклонения

	// сплошное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clLime;
	IGraphs->Canvas->Pen->Style = psSolid;
	IGraphs->Canvas->Pen->Width = 1;

	// получаем константы
	a = c_A;
	b = c_B;
	c = c_C;
	d = c_D;

	// изначально считаем , что отклонения нет
	max_u = 0;
	max_y = 0;
        max_x = 0;

	// расчитываем начальные координаты
	x = a;
	y = R( x );
	u = 0;
	v = IGraphs->Height * ( y - d ) / ( c - d );

	// и ставим перо в начальную точку
	IGraphs->Canvas->MoveTo( u, v );

	for( int i = 0; i < IGraphs->Width; i += 1 ) // идем по иксам и соединяем точки линиями
	{
		// пересчитываем координаты
		x = a + i * ( b - a ) / ( IGraphs->Width - 1 );
		y = R( x );
		u = i;
		v = IGraphs->Height * ( y - d ) / ( c - d );

		// и рисуем очередую линию, обрезая ее, если нужно, у границы экрана
		if( v < 0 )
			IGraphs->Canvas->LineTo( u, -1 );
		else if( v >= IGraphs->Height )
			IGraphs->Canvas->LineTo( u, IGraphs->Height );
		else
			IGraphs->Canvas->LineTo( u, v );

		// сравниваем отклонение в текущей точке с уже полученным ранее максимальным отклонением
		if( max_y <= fabs( y ) )
		{
			max_u = u;
			max_y = fabs( y );
                        max_x = ( c_A + i*( (c_B - c_A)/IGraphs->Width) );
			max_v = v;
		}                                   
	}

	// отмечаем точку максимального отклонения на графике
	Point(clNavy, max_u, max_v );

        AnsiString _point;
        _point = "( ";
        _point += FloatToStrF(max_x,ffNumber,4,2);
        _point += "; ";
        _point += FloatToStrF(max_y,ffNumber,4,2);
        _point += ")";

        MainForm->Label2->Caption = _point.c_str();

	// и рисуем пунктирную вертикальную линию одинарной толщины
	IGraphs->Canvas->Pen->Color = clNavy;
	IGraphs->Canvas->Pen->Style = psDash;
	IGraphs->Canvas->Pen->Width = 1;
	IGraphs->Canvas->MoveTo( max_u, 0 );
	IGraphs->Canvas->LineTo( max_u, IGraphs->Height );
}

void Interpolation::Update()
{
        AnsiString FunctionString = NULL;
        FunctionString = "f(x)=";
        FunctionString += MainForm->AlphaEdit->Text;
        FunctionString += "*sin{tg[";
        FunctionString += MainForm->BettaEdit->Text;
        FunctionString += "/(x-";
        FunctionString += MainForm->GammaEdit->Text;
        FunctionString += ")]}+";
        FunctionString += MainForm->DeltaEdit->Text;
        FunctionString += "*cos(";
        FunctionString += MainForm->Edit1->Text;
        FunctionString += "*x)";

        SetAlpha(MainForm->AlphaEdit->Text.ToDouble());
        SetBetta(MainForm->BettaEdit->Text.ToDouble());
        SetGamma(MainForm->GammaEdit->Text.ToDouble());              
        SetDelta(MainForm->DeltaEdit->Text.ToDouble());
        SetEps(MainForm->Edit1->Text.ToDouble());

        SetA(MainForm->AEdit->Text.ToDouble());
        SetB(MainForm->BEdit->Text.ToDouble());
        SetC(MainForm->CEdit->Text.ToDouble());     
        SetD(MainForm->DEdit->Text.ToDouble());

        SetN(MainForm->NEdit->Text.ToInt());   
        SetH(MainForm->HComboBox->Text.ToDouble());

        MainForm->CureFunction->Caption = FunctionString.c_str();

        c_Steep = ( c_B - c_A ) / (c_N - 1);

        // ---------- Хэшируем значения узлов ---------------

        if(c_Uzli != NULL)
        {
                delete[] c_Uzli;
                c_Uzli = NULL;        
        }

        c_Uzli = new long double[c_N + 1];

        for(int i = 0 ; i < c_N ; i++)
                c_Uzli[i] = F(c_Steep*i + c_A);
                                      
        c_Uzli[c_N] = NULL;

        //------------ Хэшируем конечных разностей --------------

        GenerateFinalDifference();

        //-------------------------------------------------------

        // перерисовываем координатную сетку
	ClearBackground();
	DrawAxes();
   	PrintScale();

	// выставляем область рисования графиков в соответствии с координатной сеткой
        IBackground->Left = 0;
	IBackground->Top = 0;
	IBackground->Width = 2000;
	IBackground->Height = 2000;
        
	IGraphs->Left = IBackground->Left + 2 * SPACE;
	IGraphs->Top = IBackground->Top + SPACE;
	IGraphs->Width = IBackground->Width - 3 * SPACE;
	IGraphs->Height = IBackground->Height - 3 * SPACE;

        ClearGraphs();

	// серое пунктирное перо одинарной толщины
	IGraphs->Canvas->Pen->Color = clGray;
	IGraphs->Canvas->Pen->Width = 1;
	IGraphs->Canvas->Pen->Style = psDot;

	// координатная сетка
	for( int i = 0; i < LINES_COUNT; i++ )
	{
		// вертикальные линии
		IGraphs->Canvas->MoveTo( ( IGraphs->Width - 1)  * i / ( LINES_COUNT - 1 ),
									 0 );
		IGraphs->Canvas->LineTo( ( IGraphs->Width - 1)  * i / ( LINES_COUNT - 1 ),
									 IGraphs->Height );

		// горизонтальные линии
		IGraphs->Canvas->MoveTo( 0,
									 ( IGraphs->Height - 1) * i / ( LINES_COUNT - 1 ) );
		IGraphs->Canvas->LineTo( IGraphs->Width,
									 ( IGraphs->Height - 1) * i / ( LINES_COUNT - 1 ) );
	}

        if(MainForm->CheckF->Checked)
                Print_F();

        if(MainForm->CheckP->Checked)
                Print_P();

        if(MainForm->CheckR->Checked)
                Print_R();

        if(MainForm->CheckdF->Checked)
                Print_DF();
                                        
        if(MainForm->CheckdP->Checked)
                Print_DP();
}

#include "mainwindow.h"
#include <QFormLayout>
#include <QVBoxLayout>
#include <QHBoxLayout>
#include <QGridLayout>
#include <QMessageBox>
#include <QChar>
#include <QWidget>
#include <QSound>

#include <math.h>
#include <qwt_plot.h>
#include <qwt_plot_curve.h>

#define NMAX 8000
#define MMAX 1000

MainWindow::MainWindow(QApplication *ap) {
    this->initializeArrays();
    this->createPlot();
    this->createCurves();
    this->createGrid();
    this->createLabels();
    this->createSpinBoxes();
    this->createGroupBoxes();
    this->createRadioButtons();
    this->createButtons();
    this->createMenus(ap);
    this->setAxes();
    this->setStartStateProgram();
    this->assemblyElements();
    this->setWindowTitle("Iteration method"); // установка заголовка программы
    connect(button1, SIGNAL(clicked()), this, SLOT(checkPlotSize()));
    connect(button2, SIGNAL(toggled(bool)), this, SLOT(funcToggled(bool)));
}

void MainWindow::contextMenuEvent(QContextMenuEvent *contextmenuevent){
    contextMenu->exec(contextmenuevent->globalPos()); // вызов контекстного меню
}

void MainWindow::keyPressEvent(QKeyEvent *pressevent) {
   if (pressevent->key() == Qt::Key_F1) // вызов нужного событи€ по нажатию клавиши
        this->personalData();
}

void MainWindow::createMenus(QApplication *ap) {
    contextMenu = new QMenu;
    contextMenu->addAction("Personalization",this,SLOT(personalData())); // добавление действи€ дл€ программы
    contextMenu->addAction("About Qt",ap,SLOT(aboutQt()));
}

void MainWindow::personalData() {
    QWidget *about = new QWidget();
    QVBoxLayout *aboutlay = new QVBoxLayout(about);
    QLabel *lab1 = new QLabel("<h2>Iteration method</h1>");
    QLabel *lab2 = new QLabel("This application finds the solution of nonlinear equation of the form x=g(x) using the iteration method.");
    QLabel *lab3 = new QLabel("The program draws the graphic of numerical solution, depending on the sizes of drawing box, iterations values, starting \npoint, function parameters and selected parameter, defining image.");
    lab3->setWordWrap(true);
    //QImage *img = new QImage;
    //img->load("C:/Users/Leon/Documents/Qt Projects/Iteration_method/L.jpg");
    //QLabel *imglab = new QLabel;
    //imglab->setPixmap(QPixmap::fromImage(*img));
    QLabel *lab4 = new QLabel("<p><i>Student Semen Korneev, group IVT-41-SO, YarGU, Russia, 2013</i>");
    //QLabel *lab5 = new QLabel("<h4><p><i>Device: You'll never walk alone</i></h4>");
    aboutlay->addWidget(lab1);
    aboutlay->addWidget(lab2);
    aboutlay->addWidget(lab3);
    //aboutlay->addWidget(imglab);
    aboutlay->addWidget(lab4);
    //aboutlay->addWidget(lab5);
    about->setWindowTitle("About program");
    about->setAttribute(Qt::WA_DeleteOnClose,true);
    about->setLayout(aboutlay);
    about->setWindowFlags(Qt::WindowCloseButtonHint);
    about->show();
    //QSound::play("C:/Users/Leon/Documents/Qt Projects/Iteration_method/Saber.wav");
}

void MainWindow::createPlot() {
    plot = new QwtPlot();
    plot->setTitle("Iteration results"); // заголовок области рисовани€, написан над областью рисовани€
    plot->setAxisScale(QwtPlot::yLeft, -5, 5); // с,d
    plot->setAxisScale(QwtPlot::xBottom, -5, 5); // a,b
}

void MainWindow::createCurves() {
    QPen nPen = QPen(Qt::red); // цвет дл€ отрисовки графика
    nCurve = new QwtPlotCurve();
    nCurve->setRenderHint(QwtPlotItem::RenderAntialiased); // сглаживание линий графика
    nCurve->setPen(nPen);
    nCurve->setStyle(QwtPlotCurve::Dots);
    nCurve->attach(plot); // прив€зка графика к области рисовани€
    QPen pPen = QPen(Qt::blue);
    pCurve = new QwtPlotCurve();
    pCurve->setRenderHint(QwtPlotItem::RenderAntialiased);
    pCurve->setPen(pPen);
    pCurve->setStyle(QwtPlotCurve::Dots);
    pCurve->attach(plot);
    QPen oxyPen = QPen(Qt::darkGray);
    oxAxe = new QwtPlotCurve();
    oxAxe->setRenderHint(QwtPlotItem::RenderAntialiased);
    oxAxe->setPen(oxyPen);
    oxAxe->attach(plot);
    oyAxe = new QwtPlotCurve();
    oyAxe->setRenderHint(QwtPlotItem::RenderAntialiased);
    oyAxe->setPen(oxyPen);
    oyAxe->attach(plot);
}

void MainWindow::createGrid() {
    grid = new QwtPlotGrid();
    grid->enableXMin(true);
    grid->enableYMin(true);
    grid->setMajPen(QPen(Qt::lightGray,0,Qt::DashDotDotLine));
    grid->setMinPen(QPen(Qt::lightGray,0,Qt::DotLine));
    grid->attach(plot);
}

void MainWindow::initializeArrays() {
    nx = new double [NMAX*MMAX+1];
    px = new double [NMAX*MMAX+1];
    ny = new double [NMAX*MMAX+1];
    py = new double [NMAX*MMAX+1];
}

double MainWindow::Func(double X, int num_of_par, double par) {
    if (X == mu)
        return 0;
    switch (num_of_par) {
        case 1: return (par*sin(tan(beta*X))+eps*cos(mu*X)); // alpha
        case 2: return (alpha*sin(tan(par*X))+eps*cos(mu*X)); // beta
        case 3: return (alpha*sin(tan(beta*X))+par*cos(mu*X)); // epsilon
        case 4: return (alpha*sin(tan(beta*X))+eps*cos(par*X)); // mu
        default: return 0;
    }
    return 0;
}

void MainWindow::buildIterationResults(int num_of_par) {
    double L = b-a, h = L/NMAX;
    double absc = 0, yord = 0;
    for (int i = 0; i <= NMAX; i++) {
        absc = a+i*h;
        yord = x0;
        for (int j = 0; j < m; j++) // пропуск m предварительных значений итераций
            yord = Func(yord, num_of_par, absc);
        for (int j = 0; j < n; j++) { // подсчЄт n результатов операций-итераций
            nx[len_n] = absc;
            yord = Func(yord, num_of_par, absc);
            ny[len_n] = yord;
            if (len_n % p == 0) { // отдельное добавление каждой p-ой из n итераций в данные
                px[len_p] = nx[len_n];
                py[len_p] = yord;
                len_p++;
            }
            len_n++;
        }
    }
    nCurve->setData(nx, ny, len_n);
    pCurve->setData(px, py, len_p);
}

void MainWindow::dumpIterationsResults() {
    len_n = 0;
    len_p = 0;
}

void MainWindow::setAxes() {
    double xdata[3];
    double oxdata[3];
    xdata[1] = -100;
    xdata[2] = 100;
    oxdata[1] = oxdata[2] = 0;
    double ydata[3];
    double oydata[3];
    ydata[1] = ydata[2] = 0;
    oydata[1] = -100;
    oydata[2] = 100;
    oxAxe->setData(xdata, oxdata, 3);
    oyAxe->setData(ydata, oydata, 3);
}

void MainWindow::createLabels() {
    label1 = new QLabel("<u>Change parameters:</u>");
    label2 = new QLabel("<u>Resizing the window:</u>");
    label3 = new QLabel("<u>Display functions:</u>");
}

void MainWindow::createSpinBoxes() {
    alphaSpin = new QDoubleSpinBox;
    betaSpin = new QDoubleSpinBox;
    epsSpin = new QDoubleSpinBox;
    muSpin = new QDoubleSpinBox;
    xoSpin = new QDoubleSpinBox;
    ASizeSpin = new QDoubleSpinBox;
    BSizeSpin = new QDoubleSpinBox;
    CSizeSpin = new QDoubleSpinBox;
    DSizeSpin = new QDoubleSpinBox;
    nSpin = new QSpinBox;
    mSpin = new QSpinBox;
    pSpin = new QSpinBox;
    alphaSpin->setRange(-100,100);
    betaSpin->setRange(-100,100);
    epsSpin->setRange(-100,100);
    muSpin->setRange(-100,100);
    xoSpin->setRange(-100,100);
    ASizeSpin->setRange(-100,100);
    BSizeSpin->setRange(-100,100);
    CSizeSpin->setRange(-100,100);
    DSizeSpin->setRange(-100,100);
    nSpin->setRange(1,500);
    mSpin->setRange(0,500);
    pSpin->setRange(1,25);
    alphaSpin->setWrapping(true);
    betaSpin->setWrapping(true);
    epsSpin->setWrapping(true);
    muSpin->setWrapping(true);
    xoSpin->setWrapping(true);
    ASizeSpin->setWrapping(true);
    BSizeSpin->setWrapping(true);
    CSizeSpin->setWrapping(true);
    DSizeSpin->setWrapping(true);
    nSpin->setWrapping(true);
    mSpin->setWrapping(true);
    pSpin->setWrapping(true);
    alphaSpin->setSingleStep(0.1);
    betaSpin->setSingleStep(0.1);
    epsSpin->setSingleStep(0.1);
    muSpin->setSingleStep(0.1);
    xoSpin->setDecimals(3);
    xoSpin->setSingleStep(0.1);
    ASizeSpin->setSingleStep(0.1);
    BSizeSpin->setSingleStep(0.1);
    CSizeSpin->setSingleStep(0.1);
    DSizeSpin->setSingleStep(0.1);
    nSpin->setSingleStep(1);
    mSpin->setSingleStep(1);
    pSpin->setSingleStep(1);
    ASizeSpin->setValue(-5.00);
    BSizeSpin->setValue(5.00);
    CSizeSpin->setValue(-5.00);
    DSizeSpin->setValue(5.00);
    alphaSpin->setValue(1.00);
    betaSpin->setValue(1.00);
    epsSpin->setValue(1.00);
    muSpin->setValue(1.00);
    xoSpin->setValue(2.000);
    nSpin->setValue(20);
    mSpin->setValue(10);
    pSpin->setValue(5);
}

void MainWindow::createButtons() {
    button1 = new QPushButton("Confirm changes");
    button2 = new QPushButton("Draw");
    button2->setCheckable(true);
}

void MainWindow::createGroupBoxes() {
    coefGrBox = new QGroupBox("Coefficients");
    drawGrBox = new QGroupBox("Drawing box");
    iterGrBox = new QGroupBox("Iterations");
    pointGrBox = new QGroupBox("Starting point");
    showGrBox = new QGroupBox("Show");
}

void MainWindow::createRadioButtons() {
    alphaRadioButton = new QRadioButton(QChar(0x03B1));
    betaRadioButton = new QRadioButton(QChar(0x03B2));
    epsRadioButton = new QRadioButton(QChar(0x03B3));
    muRadioButton = new QRadioButton(QChar(0x03B4));
}

void MainWindow::setStartStateProgram() {
    this->checkPlotSize();
    this->funcToggled(false);
}

void MainWindow::assemblyElements() {
    QFormLayout *coeflay = new QFormLayout;
    coeflay->addRow(QChar(0x03B1),alphaSpin);
    coeflay->addRow(QChar(0x03B2),betaSpin);
    coeflay->addRow(QChar(0x03B3),epsSpin);
    coeflay->addRow(QChar(0x03B4),muSpin);
    coefGrBox->setLayout(coeflay);
    QFormLayout *drawlay = new QFormLayout;
    drawlay->addRow("A:",ASizeSpin);
    drawlay->addRow("B:",BSizeSpin);
    drawlay->addRow("C:",CSizeSpin);
    drawlay->addRow("D:",DSizeSpin);
    drawGrBox->setLayout(drawlay);
    QFormLayout *iterlay = new QFormLayout;
    iterlay->addRow("n:",nSpin);
    iterlay->addRow("m:",mSpin);
    iterlay->addRow("p:",pSpin);
    iterGrBox->setLayout(iterlay);
    QFormLayout *pointlay = new QFormLayout;
    pointlay->addRow("x0:",xoSpin);
    pointGrBox->setLayout(pointlay);
    QGridLayout *showlay = new QGridLayout;
    showlay->addWidget(alphaRadioButton,0,0);
    showlay->addWidget(betaRadioButton,1,0);
    showlay->addWidget(epsRadioButton,0,1);
    showlay->addWidget(muRadioButton,1,1);
    showGrBox->setLayout(showlay);
    QImage *img = new QImage;
    img->load("C:/Users/Naumov/Desktop/Iteration_method/Formula.png");
    QLabel *imglbl = new QLabel;
    imglbl->setPixmap(QPixmap::fromImage(*img));
    QGridLayout *lay = new QGridLayout;
    QWidget *centerwidget = new QWidget;
    lay->setVerticalSpacing(25);
    lay->addWidget(imglbl,0,0,1,2);
    lay->addWidget(label1,1,0,1,2);
    lay->addWidget(coefGrBox,2,0);
    lay->addWidget(iterGrBox,2,1);
    lay->addWidget(pointGrBox,3,0,1,2);
    lay->addWidget(label2,4,0,1,2);
    lay->addWidget(drawGrBox,5,0,1,2);
    lay->addWidget(button1,6,0,1,2);
    lay->addWidget(label3,7,0,1,2);
    lay->addWidget(showGrBox,8,0,1,2);
    lay->addWidget(button2,9,0,1,2);
    QHBoxLayout *plotslay = new QHBoxLayout();
    plotslay->addWidget(plot);
    QHBoxLayout *widglay = new QHBoxLayout();
    widglay->setSpacing(25);
    widglay->addLayout(plotslay);
    widglay->addLayout(lay);
    centerwidget->setLayout(widglay);
    this->checkPlotSize();
    nCurve->setVisible(false);
    pCurve->setVisible(false);
    oxAxe->setVisible(true);
    oyAxe->setVisible(true);
    this->setCentralWidget(centerwidget);
    this->showMaximized();
}

void MainWindow::funcToggled(bool checked) {
    if (checked == false) {
        this->dumpIterationsResults();
        this->drawGraphics(false);
        return;
    }
    if (alphaRadioButton->isChecked())
        this->buildIterationResults(1);
    if (betaRadioButton->isChecked())
        this->buildIterationResults(2);
    if (epsRadioButton->isChecked())
        this->buildIterationResults(3);
    if (muRadioButton->isChecked())
        this->buildIterationResults(4);
    this->drawGraphics(true);
}

void MainWindow::drawGraphics(bool state) {
    nCurve->setVisible(state);
    pCurve->setVisible(state);
    plot->replot(); // перерисовка области рисовани€
}

void MainWindow::checkPlotSize() {
    a = ASizeSpin->value();
    b = BSizeSpin->value();
    c = CSizeSpin->value();
    d = DSizeSpin->value();
    x0 = xoSpin->value();
    if (((a-b)>=0) || ((c-d)>=0)) {
        QMessageBox::critical(0, "Error!", "Negative dimensions of the plot!", QMessageBox::Ok); // сообщение об ошибке в случае неверных размеров дл€области изображени€
        return;
    }
    if ((x0 < c) || (x0 > d)) {
        QMessageBox::critical(0, "Error!", "Coordinates of the starting point must be between the value C and value D!", QMessageBox::Ok); // сообщение об ошибке в случае неверных размеров дл€области изображени€
        return;
    }
    this->parametersConfirm();
}

void MainWindow::parametersConfirm() {
    alpha = alphaSpin->value();
    beta = betaSpin->value();
    eps = epsSpin->value();
    mu = muSpin->value();
    n = nSpin->value();
    m = mSpin->value();
    p = pSpin->value();
    plot->setAxisScale(QwtPlot::yLeft, c, d);
    plot->setAxisScale(QwtPlot::xBottom, a, b);
    this->funcToggled(false);
}

MainWindow::~MainWindow() {
    /*if (contextMenu)
        delete contextMenu;
    if (ox)
        delete ox;
    if (oy)
        delete oy;
    if (funcCurve)
        delete funcCurve;
    if (funcAlphaCurve)
        delete funcAlphaCurve;
    if (funcBetaCurve)
        delete funcBetaCurve;
    if (funcEpsCurve)
        delete funcEpsCurve;
    if (funcMuCurve)
        delete funcMuCurve;
    if (plot)
        delete plot;
    if (grid)
        delete grid;
    if (label1)
        delete label1;
    if (label2)
        delete label2;
    if (label3)
        delete label3;
    if (statmenulabel)
        delete statmenulabel;
    if (labelNMax)
        delete labelNMax;
    if (alphaSpin)
        delete alphaSpin;
    if (betaSpin)
        delete betaSpin;
    if (epsSpin)
        delete epsSpin;
    if (muSpin)
        delete muSpin;
    if (ASizeSpin)
        delete ASizeSpin;
    if (BSizeSpin)
        delete BSizeSpin;
    if (CSizeSpin)
        delete CSizeSpin;
    if (DSizeSpin)
        delete DSizeSpin;
    if (nSpin)
        delete nSpin;
    if (AEndSpin)
        delete AEndSpin;
    if (BEndSpin)
        delete BEndSpin;
    if (accur)
        delete accur;
    if (button1)
        delete button1;
    if (button2)
        delete button2;
    if (fxChBox)
        delete fxChBox;
    if (alphaChBox)
        delete alphaChBox;
    if (betaChBox)
        delete betaChBox;
    if (epsChBox)
        delete epsChBox;
    if (muChBox)
        delete muChBox;
    if (statusMenu)
       delete statusMenu;
    if (statusBar)
        delete statusBar;
    if (coefGrBox)
        delete coefGrBox;
    if (drawGrBox)
        delete drawGrBox;
    if (segmGrBox)
        delete segmGrBox;
    if (partitionGrBox)
        delete partitionGrBox;
    if (accurGrBox)
        delete accurGrBox;
    if (showGrBox)
        delete showGrBox;
    if (x)
        delete[] x;
    if (fx)
        delete[] fx;
    if (alphafx)
        delete[] alphafx;
    if (betafx)
        delete[] betafx;
    if (epsfx)
        delete[] epsfx;
    if (mufx)
        delete[] mufx;*/
}

#include "mainwindow.h"
#include <QFormLayout>
#include <QVBoxLayout>
#include <QHBoxLayout>
#include <QGridLayout>
#include <QMessageBox>
#include <QChar>
#include <QImage>

#define N 4000

MainWindow::MainWindow(QApplication *appl) {
    this->createDataTrajectories();
    this->createPlot();
    this->createLabels();
    this->createPicker();
    this->createSpinBoxes();
    this->createGroupBoxes();
    this->createComboBox();
    this->createButtons();
    this->createMenus(appl);
    this->createStatusBar();
    this->setAxes();
    this->checkPlotSize();
    this->assemblyElements();
    this->parametersConfirm();
    this->setWindowTitle("Euler's method");
    connect(button1, SIGNAL(clicked()), this, SLOT(checkPlotSize()));
    connect(button2, SIGNAL(clicked()), this, SLOT(clearAll()));
    connect(picker, SIGNAL(selected(const QwtDoublePoint&)), this, SLOT(fixClickedPoint(const QwtDoublePoint&)));
}

void MainWindow::contextMenuEvent(QContextMenuEvent *cmevent){
    contextMenu->exec(cmevent->globalPos()); // вызов контекстного меню
}

void MainWindow::keyPressEvent(QKeyEvent *kpevent) {
   if (kpevent->key() == Qt::Key_F1) // вызов нужного события по нажатию клавиши
        this->personalData();
}

void MainWindow::clearAll() {
    this->destroyDataTrajectories();
    this->clearPlot();
}

void MainWindow::createMenus(QApplication *appl) {
    contextMenu = new QMenu;
    contextMenu->addAction("Personalization",this,SLOT(personalData())); // добавление действия для программы
    contextMenu->addAction("About Qt",appl,SLOT(aboutQt()));
    stMenu = new QMenu;
}

void MainWindow::personalData() {
    QMessageBox::about(this,"About program","<h2>Euler's method</h2>""This application solves a system of ordinary differential equations."
                       "The program draws the trajectory of numerical solutions, depending on the sizes of drawing box, function parameters, grid and steps."
                       "<p><i>Student Korneev Semyon, group IVT-41-SO, Yaroslavl, Russia, 2013</i>"
                       //"<p><i>Device: You'll never walk alone</i>" // если вдруг жутко потребуется эта информация
                       );
}

void MainWindow::createPlot() {
    plot = new QwtPlot();
    plot->setTitle("Graphics of trajectories"); // титульник области рисования, написан над областью рисования
    plot->setAxisScale(QwtPlot::yLeft, -5, 5); // с,d
    plot->setAxisScale(QwtPlot::xBottom, -5, 5); // a,b
}

void MainWindow::clearPlot() {
    plot->clear(); // очистка всей области рисования
    this->setAxes(); // отрисовка осей координат
    plot->replot(); // перерисовка области рисования
}

void MainWindow::prepareCurve(int idx) {
    QPen pen_for_plus = QPen(QColor(red_plus[idx], green_plus[idx], blue_plus[idx]));
    pen_for_plus.setWidth(2);
    QPen pen_for_minus = QPen(QColor(red_minus[idx], green_minus[idx], blue_minus[idx]));
    plusnCurve = new QwtPlotCurve();
    plusnCurve->setRenderHint(QwtPlotItem::RenderAntialiased);
    plusnCurve->setPen(pen_for_plus);
    plusnCurve->attach(plot);
    minusnCurve = new QwtPlotCurve();
    minusnCurve->setRenderHint(QwtPlotItem::RenderAntialiased);
    minusnCurve->setPen(pen_for_minus);
    minusnCurve->attach(plot);
    this->initStartTrajectory();
}

void MainWindow::setAxes() {
    QPen oxyPen = QPen(Qt::black);
    QwtPlotCurve *ox = new QwtPlotCurve();
    ox->setRenderHint(QwtPlotItem::RenderAntialiased);
    ox->setPen(oxyPen);
    ox->attach(plot);
    QwtPlotCurve *oy = new QwtPlotCurve();
    oy->setRenderHint(QwtPlotItem::RenderAntialiased);
    oy->setPen(oxyPen);
    oy->attach(plot);
    this->initOxOycoordinates();
    ox->setData(xdata, oxdata, 3);
    oy->setData(ydata, oydata, 3);
}

void MainWindow::initOxOycoordinates() {
    xdata[1] = -100;
    xdata[2] = 100;
    oxdata[1] = oxdata[2] = 0;
    ydata[1] = ydata[2] = 0;
    oydata[1] = -100;
    oydata[2] = 100;
}

void MainWindow::createLabels() {
    label1 = new QLabel("<u>Tuning function's parameters:</u>");
    label2 = new QLabel("<u>Last coordinates of point by click:</u>");
    label3 = new QLabel("<u>Resizing the window:</u>");
    labelx0 = new QLabel("?");
    labely0 = new QLabel("?");
    stbarLabel = new QLabel("?");
}

void MainWindow::createPicker() {
    picker = new QwtPlotPicker(plot->canvas());
    picker->setTrackerMode(QwtPicker::AlwaysOn);
    picker->setRubberBandPen(QColor(Qt::red));
    picker->setRubberBand(QwtPicker::NoRubberBand);
    picker->setSelectionFlags(QwtPicker::PointSelection | QwtPicker::QwtPicker::DragSelection);
    picker->setMousePattern(QwtPicker::MouseSelect1, Qt::LeftButton);
    count_trajectories = 0; // изначально количество кликнутых по плоту точек  = 0
}

void MainWindow::fixClickedPoint(const QwtDoublePoint &po1) {
    QString x1,y1;
    x0 = po1.x();
    y0 = po1.y();
    x1.setNum(x0);
    y1.setNum(y0);
    if (count_trajectories+1 > M) // слишком много кликов по области рисования, слишком много графиков-траекторий уже отображено
        QMessageBox::critical(this, "Error!", "Too many trajectories can be drawn... Please, clear your plot!");
    else {
        labelx0->setText(x1);
        labely0->setText(y1);
        this->prepareCurve(count_trajectories);
        this-> buildTrajectory(count_trajectories);
        count_trajectories++;
        this->seeTrajectory(count_trajectories-1); // рисуем только последнюю по счёту траекторию, так как предыдущие графики уже отображены ранее
        this->calcAmountTrajectories();
    }
}

void MainWindow::createSpinBoxes() {
    alphaSpin = new QDoubleSpinBox;
    betaSpin = new QDoubleSpinBox;
    epsSpin = new QDoubleSpinBox;
    muSpin = new QDoubleSpinBox;
   // lambdaSpin = new QDoubleSpinBox;
    psiSpin = new QDoubleSpinBox;
    ASpin = new QDoubleSpinBox;
    BSpin = new QDoubleSpinBox;
    CSpin = new QDoubleSpinBox;
    DSpin = new QDoubleSpinBox;
    alphaSpin->setRange(-100,100);
    betaSpin->setRange(-100,100);
    epsSpin->setRange(-100,100);
    muSpin->setRange(-100,100);
  //  lambdaSpin->setRange(-100,100);
    psiSpin->setRange(-100,100);
    ASpin->setRange(-100,100);
    BSpin->setRange(-100,100);
    CSpin->setRange(-100,100);
    DSpin->setRange(-100,100);
    alphaSpin->setWrapping(true);
    betaSpin->setWrapping(true);
    epsSpin->setWrapping(true);
    muSpin->setWrapping(true);
   // lambdaSpin->setWrapping(true);
    psiSpin->setWrapping(true);
    ASpin->setWrapping(true);
    BSpin->setWrapping(true);
    CSpin->setWrapping(true);
    DSpin->setWrapping(true);
    alphaSpin->setSingleStep(0.1);
    betaSpin->setSingleStep(0.1);
    epsSpin->setSingleStep(0.1);
    muSpin->setSingleStep(0.1);
    //lambdaSpin->setSingleStep(0.1);
    psiSpin->setSingleStep(0.1);
    ASpin->setSingleStep(0.1);
    BSpin->setSingleStep(0.1);
    CSpin->setSingleStep(0.1);
    DSpin->setSingleStep(0.1);
    nSpin = new QSpinBox;
    nSpin->setRange(1,NMAX);
    nSpin->setWrapping(true);
    ASpin->setValue(-5.00);
    BSpin->setValue(5.00);
    CSpin->setValue(-5.00);
    DSpin->setValue(5.00);
    alphaSpin->setValue(1.00);
    betaSpin->setValue(1.00);
    epsSpin->setValue(1.00);
    muSpin->setValue(1.00);
   // lambdaSpin->setValue(1.00);
    psiSpin->setValue(1.00);
    nSpin->setValue(1);
}

void MainWindow::createButtons() {
    button1 = new QPushButton("Confirm changes");
    button2 = new QPushButton("Clear all");
}

void MainWindow::createGroupBoxes() {
    f1coefGrBox = new QGroupBox("f1");
    f2coefGrBox = new QGroupBox("f2");
    plotsizeGrBox = new QGroupBox("Drawing box");
    stepsGrBox = new QGroupBox("Steps");
    gridGrBox = new QGroupBox("Grid");
}

void MainWindow::createComboBox() {
    gridlist<<"1"<<"0.1"<<"0.01"<<"0.001"<<"0.0001";
    gridComboBox = new QComboBox;
    gridComboBox->addItems(gridlist);
}

void MainWindow::createStatusBar() {
    stbar = new QStatusBar;
    this->calcAmountTrajectories();
    stbar->addWidget(stbarLabel);
}

int MainWindow::randomNumber() {
    int q = rand()%256;
    return q;
}

void MainWindow::createDataTrajectories() {
    int i;
    xnplus = new double* [M];
    for (i=0; i<M; i++)
        xnplus[i] = new double [NMAX];
    ynplus = new double* [M];
    for (i=0; i<M; i++)
        ynplus[i] = new double [NMAX];
    xnminus = new double* [M];
    for (i=0; i<M; i++)
        xnminus[i] = new double [NMAX];
    ynminus = new double* [M];
    for (i=0; i<M; i++)
        ynminus[i] = new double [NMAX];
    for (i=0; i<M; i++) {
        red_plus[i] = randomNumber();
        green_plus[i] = randomNumber();
        blue_plus[i] = randomNumber();
        red_minus[i] = randomNumber();
        green_minus[i] = randomNumber();
        blue_minus[i] = randomNumber();
    }
}

void MainWindow::destroyDataTrajectories() {
    count_trajectories = 0;
    this->calcAmountTrajectories();
    x0 = 0.0;
    y0 = 0.0;
    labelx0->setText("?");
    labely0->setText("?");
}

void MainWindow::initStartTrajectory() {
    xnplus[count_trajectories][0] = x0;
    xnminus[count_trajectories][0] = x0;
    ynplus[count_trajectories][0] = y0;
    ynminus[count_trajectories][0] = y0;
}

double MainWindow::Func1(double xn, double yn) {
    return alpha*xn*xn+beta*yn*yn+eps;
}

double MainWindow::Func2(double xn, double yn) {
    return mu*xn*yn+psi;
}

void MainWindow:: buildTrajectory(int idx) {
    for (int i=1; i<=n; i++) {
        xnplus[idx][i] = xnplus[idx][i-1]+delta*Func1(xnplus[idx][i-1], ynplus[idx][i-1]);
        ynplus[idx][i] = ynplus[idx][i-1]+delta*Func2(xnplus[idx][i-1], ynplus[idx][i-1]);
        xnminus[idx][i] = xnminus[idx][i-1]-delta*Func1(xnminus[idx][i-1], ynminus[idx][i-1]);
        ynminus[idx][i] = ynminus[idx][i-1]-delta*Func2(xnminus[idx][i-1], ynminus[idx][i-1]);
    }

}

void MainWindow::rebuildTrajerctories() {
    this->clearPlot(); // очистка экрана от старых траекторий
    for (int j=0; j<count_trajectories; j++) {
        this->prepareCurve(j);
        this-> buildTrajectory(j);
        this->seeTrajectory(j);
    }
}

void MainWindow::seeTrajectory(int idx) {
    plusnCurve->setData(xnplus[idx], ynplus[idx], n+1);
    minusnCurve->setData(xnminus[idx], ynminus[idx], n+1);
    plot->replot();
}

void MainWindow::calcAmountTrajectories() {
    if (count_trajectories  == 1)
        stbarLabel->setText(QString::number(count_trajectories)+" trajectory is drawn on plot");
    else
        stbarLabel->setText(QString::number(count_trajectories)+" trajectories are drawn on plot"); // количество нарисованных на экране траекторий отображается в нижнем левом углу экрана
}

void MainWindow::assemblyElements() {
    QFormLayout *f1coeflay = new QFormLayout;
    QFormLayout *f2coeflay = new QFormLayout;
    f1coeflay->addRow(QChar(0x03B1),alphaSpin);
    f1coeflay->addRow(QChar(0x03B2),betaSpin);
    f1coeflay->addRow(QChar(0x03B3),epsSpin);

    f2coeflay->addRow(QChar(0x03B4),muSpin);
    f2coeflay->addRow(QChar(0x03C6),psiSpin);
    //f2coeflay->addRow(QChar(0x03BB),lambdaSpin);

    f1coefGrBox->setLayout(f1coeflay);
    f2coefGrBox->setLayout(f2coeflay);
    QFormLayout *drawlay = new QFormLayout;
    drawlay->addRow("A:     ",ASpin);
    drawlay->addRow("B:     ",BSpin);
    drawlay->addRow("C:     ",CSpin);
    drawlay->addRow("D:     ",DSpin);
    plotsizeGrBox->setLayout(drawlay);
    QFormLayout *nodelay = new QFormLayout;
    nodelay->addRow("n",nSpin);
    stepsGrBox->setLayout(nodelay);
    QFormLayout *arglay = new QFormLayout;
    arglay->addRow(QChar(0x0394),gridComboBox);
    gridGrBox->setLayout(arglay);
    QFormLayout *pointlayout = new QFormLayout;
    pointlayout->addRow("x0:    ",labelx0);
    pointlayout->addRow("y0:    ",labely0);
    QGridLayout *lay = new QGridLayout;
    QImage *img = new QImage;
    img->load("C:/Users/Leon/Documents/Qt Projects/Euler_method/Formula.png"); // Formula1, в случае, если жутко потребуются личные данные
    QLabel *imglabel = new QLabel;
    imglabel->setPixmap(QPixmap::fromImage(*img));
    QWidget *centerwidget = new QWidget;
    lay->setVerticalSpacing(20);
    lay->addWidget(imglabel,0,0,1,2);
    lay->addWidget(label1,1,0,1,2);
    lay->addWidget(f1coefGrBox,2,0);
    lay->addWidget(f2coefGrBox,2,1);
    lay->addWidget(stepsGrBox,3,0);
    lay->addWidget(gridGrBox,3,1);
    lay->addWidget(label3,4,0,1,2);
    lay->addWidget(plotsizeGrBox,5,0,1,2);
    lay->addWidget(button1,6,0,1,2);
    lay->addWidget(button2,7,0,1,2);
    lay->addWidget(label2,8,0,1,2);
    lay->addLayout(pointlayout,9,0,1,2);
    QHBoxLayout *plotslay = new QHBoxLayout();
    plotslay->addWidget(plot);
    QHBoxLayout *widglay = new QHBoxLayout();
    widglay->setSpacing(20);
    widglay->addLayout(lay);
    widglay->addLayout(plotslay);
    centerwidget->setLayout(widglay);
    this->setStatusBar(stbar);
    this->checkPlotSize();
    this->setCentralWidget(centerwidget);
    this->showMaximized();
}

void MainWindow::checkPlotSize() {
    a = ASpin->value();
    b = BSpin->value();
    c = CSpin->value();
    d = DSpin->value();
    n = nSpin->value(); // количество узлов интерполяции
    if (((a-b)>=0) || ((c-d)>=0))
        QMessageBox::critical(0, "Error!", "Negative dimensions of the plot!", QMessageBox::Ok); // сообщение об ошибке в случае неверных размеров дляобласти изображения
    else
        this->parametersConfirm();
}

void MainWindow::parametersConfirm() {
    alpha = alphaSpin->value();
    beta = betaSpin->value();
    eps = epsSpin->value();
    mu = muSpin->value();
    //lambda = lambdaSpin->value();
    psi = psiSpin->value();
    delta = gridComboBox->currentText().toDouble();
    plot->setAxisScale(QwtPlot::yLeft, c, d);
    plot->setAxisScale(QwtPlot::xBottom, a, b);
    this->rebuildTrajerctories();
    plot->replot();
}

MainWindow::~MainWindow() {
    for (int i=0; i<NMAX; i++) {
      delete [] xnplus[i];
    }
    delete [] xnplus;
    for (int i=0; i<NMAX; i++) {
      delete [] ynplus[i];
    }
    delete [] ynplus;
    for (int i=0; i<NMAX; i++) {
      delete [] xnminus[i];
    }
    delete [] xnminus;
    for (int i=0; i<NMAX; i++) {
      delete [] ynminus[i];
    }
    delete [] ynminus;
    if (picker)
        delete picker;
    if (contextMenu)
        delete contextMenu;
    if (plot)
        delete plot;
    if (label1)
        delete label1;
    if (label2)
        delete label2;
    if (label3)
        delete label3;
    if (labelx0)
        delete labelx0;
    if (labely0)
        delete labely0;
    if (stbarLabel)
        delete stbarLabel;
    if (alphaSpin)
        delete alphaSpin;
    if (betaSpin)
        delete betaSpin;
    if (epsSpin)
        delete epsSpin;
    if (muSpin)
        delete muSpin;
    //if (lambdaSpin)
     //   delete lambdaSpin;
    if (psiSpin)
        delete psiSpin;
    if (ASpin)
        delete ASpin;
    if (BSpin)
        delete BSpin;
    if (CSpin)
        delete CSpin;
    if (DSpin)
        delete DSpin;
    if (nSpin)
        delete nSpin;
    if (gridComboBox)
        delete gridComboBox;
    if (button1)
        delete button1;
    if (button2)
        delete button2;
    if (stMenu)
       delete stMenu;
    if (stbar)
        delete stbar;
    if (f1coefGrBox)
        delete f1coefGrBox;
    if (f2coefGrBox)
        delete f2coefGrBox;
    if (plotsizeGrBox)
        delete plotsizeGrBox;
    if (stepsGrBox)
        delete stepsGrBox;
    if (gridGrBox)
        delete gridGrBox;
    if (plusnCurve)
        delete plusnCurve;
    if (minusnCurve)
        delete minusnCurve;
}

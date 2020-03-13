#include "mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent)
{
    createWidgets();
    setWidgetProperties();
    createInterface();
    this->setCentralWidget(cw);
    mainMenu = new QMenu(tr("Справка"));
    mainMenu->addAction(tr("О праграмме"), this, SLOT(about()));
    menuBar = new QMenuBar();
    menuBar->addMenu(mainMenu);
    this->setMenuWidget(menuBar);
    connect(start, SIGNAL(clicked()), this, SLOT(startClicked()));
    paintWidth = this->graphics->width()-20;
    paintHeight = this->graphics->height()-20;
}

void MainWindow::createWidgets()
{
    scene = new QGraphicsScene();
    graphics = new QGraphicsView(scene);  
    alphaEdit = new QDoubleSpinBox();
    bettaEdit = new QDoubleSpinBox();
    gammaEdit = new QDoubleSpinBox();
    deltaEdit = new QDoubleSpinBox();
    AEdit = new QDoubleSpinBox();
    BEdit = new QDoubleSpinBox();
    CEdit = new QDoubleSpinBox();
    DEdit = new QDoubleSpinBox();
    aEdit = new QDoubleSpinBox();
    bEdit = new QDoubleSpinBox();
    NEdit = new QSpinBox();
    deltaComboBox = new QComboBox();
    alphaCheck = new QRadioButton(tr("Альфа"));
    bettaCheck = new QRadioButton(tr("Бетта"));
    gammaCheck = new QRadioButton(tr("Гамма"));
    deltaCheck = new QRadioButton(tr("Дельта"));
    maxNLabel = new QLabel();
    start = new QPushButton(tr("Нарисовать"));
    xdel = new QLabel();
    ydel = new QLabel();
    progress = new QProgressBar();
}

void MainWindow::setWidgetProperties()
{
    graphics->setMinimumSize(600, 600);
    graphics->setMaximumSize(600, 600);
    alphaEdit->setValue(1);
    alphaEdit->setRange(-100, 100);
    alphaEdit->setMaximumWidth(100);
    bettaEdit->setValue(1);
    bettaEdit->setRange(-100, 100);
    bettaEdit->setMaximumWidth(100);
    gammaEdit->setValue(1);
    gammaEdit->setRange(-100, 100);
    gammaEdit->setMaximumWidth(100);
    deltaEdit->setValue(1);
    deltaEdit->setRange(-100, 100);
    deltaEdit->setMaximumWidth(100);
    AEdit->setRange(-100, 100);
    AEdit->setValue(-10);
    AEdit->setMaximumWidth(100);
    BEdit->setRange(-100, 100);
    BEdit->setValue(10);
    BEdit->setMaximumWidth(100);
    CEdit->setRange(-100, 100);
    CEdit->setValue(-10);
    CEdit->setMaximumWidth(100);
    DEdit->setRange(-100, 100);
    DEdit->setValue(10);
    DEdit->setMaximumWidth(100);
    NEdit->setValue(10);
    NEdit->setRange(0, 500);
    NEdit->setMaximumWidth(100);
    aEdit->setRange(-100, 100);
    aEdit->setValue(-10);
    aEdit->setMaximumWidth(100);
    bEdit->setRange(-100, 100);
    bEdit->setValue(10);
    bEdit->setMaximumWidth(100);
    deltaComboBox->setMaximumWidth(100);
    QStringList s;
    s <<"1" <<"0.1" <<"0.01" <<"0.001" <<"0.0001";
    deltaComboBox->addItems(s);
    deltaComboBox->setCurrentIndex(4);
    start->setMaximumWidth(200);
    alphaCheck->setChecked(true);
    xdel->setText(tr("Цена деления по оси х = "));
    ydel->setText(tr("Цена деления по оси y = "));
    progress->setMaximum(100);
    progress->setMinimum(0);
}

void MainWindow::createInterface()
{
    QGridLayout *params = new QGridLayout();
    params->addWidget(new QLabel(tr("Альфа")), 0, 0, Qt::AlignRight);
    params->addWidget(alphaEdit, 0, 1);
    params->addWidget(new QLabel(tr("Бетта")), 1, 0, Qt::AlignRight);
    params->addWidget(bettaEdit, 1, 1);
    params->addWidget(new QLabel(tr("Гамма")), 2, 0, Qt::AlignRight);
    params->addWidget(gammaEdit, 2, 1);
    params->addWidget(new QLabel(tr("Дельта")), 3, 0, Qt::AlignRight);
    params->addWidget(deltaEdit, 3, 1);
    params->addWidget(new QLabel(tr("A=")), 4, 0, Qt::AlignRight);
    params->addWidget(AEdit, 4, 1);
    params->addWidget(new QLabel(tr("B=")), 5, 0, Qt::AlignRight);
    params->addWidget(BEdit, 5, 1);
    params->addWidget(new QLabel(tr("C=")), 6, 0, Qt::AlignRight);
    params->addWidget(CEdit, 6, 1);
    params->addWidget(new QLabel(tr("D=")), 7, 0, Qt::AlignRight);
    params->addWidget(DEdit, 7, 1);
    params->addWidget(new QLabel(tr("n=")), 8, 0, Qt::AlignRight);
    params->addWidget(NEdit, 8, 1);
    params->addWidget(new QLabel(tr("a=")), 9, 0, Qt::AlignRight);
    params->addWidget(aEdit, 9, 1);
    params->addWidget(new QLabel(tr("b=")), 10, 0, Qt::AlignRight);
    params->addWidget(bEdit, 10, 1);
    params->addWidget(new QLabel(tr("Погрешность")), 11, 0, Qt::AlignRight);
    params->addWidget(deltaComboBox, 11, 1);
    params->addWidget(alphaCheck, 12, 0);
    params->addWidget(bettaCheck, 13, 0);
    params->addWidget(gammaCheck, 14, 0);
    params->addWidget(deltaCheck, 15, 0);
    params->addWidget(new QLabel(tr("Максимальное <br> n:")), 16, 0);
    params->addWidget(maxNLabel, 16, 1);
    params->addWidget(start, 17, 0, 1, 2);
    params->addItem(new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding), 18, 0);
    cw = new QWidget();
    QVBoxLayout *main = new QVBoxLayout(cw);
    QHBoxLayout *tmp = new QHBoxLayout();
    tmp->addWidget(graphics);
    tmp->addLayout(params);
    main->addLayout(tmp);
    QHBoxLayout *help = new QHBoxLayout();
    QVBoxLayout *tmp1 = new QVBoxLayout();
    tmp1->addWidget(xdel);
    tmp1->addWidget(ydel);
    help->addLayout(tmp1);
    help->addWidget(progress);
    main->addLayout(help);
}

MainWindow::~MainWindow()
{
}

double MainWindow::f(double x, const QVector<double> &params)
{
    return params[0]*sin(tan(params[1]*x))+params[2]*cos(params[3]*x);
}

void MainWindow::startClicked()
{
    this->graphics->scene()->clear();
    initParams();
    drawCoordLines();
    drawFunction();
    drawIntegral();
}

void MainWindow::initParams()
{
    alpha = alphaEdit->value();
    betta = bettaEdit->value();
    gamma = gammaEdit->value();
    delta = deltaEdit->value();
    B = (int)BEdit->value();
    A = (int)AEdit->value();
    C = (int)CEdit->value();
    D = (int)DEdit->value();
    n = NEdit->value();
    h = (double)(B-A)/(double)n;
    xPerPix = (double)(B-A)/(double)paintWidth;
    pixPerX = (double)paintWidth/(double)(B-A);
    yPerPix = (double)(D-C)/(double)paintHeight;
    pixPerY = (double)paintHeight/(double)(D-C);
    if(A<0)
        xc = qAbs(A)*pixPerX+10;
    else
        xc = -A*pixPerX+10;
    if(D>0)
        yc = qAbs(D)*pixPerY+10;
    else
        yc = -qAbs(D)*pixPerY+10;
}

void MainWindow::drawCoordLines()
{
    if(A<0)
        scene->addLine(qAbs(A)*pixPerX+10, 10, qAbs(A)*pixPerX+10, graphics->height()-10); //ось 0y
    if(C<0)
        scene->addLine(10, D*pixPerY+10, graphics->width()-10, D*pixPerY+10); //ось 0x
    int xstep, ystep;
    if(B-A<=20)
        xstep = 1;
    else
        if(B-A<=50)
            xstep = 5;
        else
            xstep = 10;
    if(D-C<=20)
        ystep = 1;
    else
        if(D-C<=50)
            ystep = 5;
        else
            ystep = 10;
    int i=0;
    while(i-xstep>=A)
        i-=xstep;
    for(; i<=B; i+=xstep) //насечки на оси 0x
        scene->addLine(i*pixPerX+xc, yc-5, i*pixPerX+xc, yc+5);
    i=0;
    while(i-ystep>=C)
        i-=ystep;
    for(; i<=D; i+=ystep) //насечки на оси 0y
        scene->addLine(xc-5, -i*pixPerY+yc, xc+5, -i*pixPerY+yc);
    xdel->setText(tr("Цена деления по оси х = ") + QString::number(xstep));
    ydel->setText(tr("Цена деления по оси y = ") + QString::number(ystep));
}

void MainWindow::drawFunction()
{
    QVector<QPair<long double, long double> > vec;
    QVector<double> p(4);
    p[0]=alpha;
    p[1]=betta;
    p[2]=gamma;
    p[3]=delta;
    for(int i=0; i<=this->graphics->width(); i++)
    {
        if(i < 10 || i > graphics->width()-10)
            continue;
        long double x = (i-xc)*xPerPix;
        long double y = f(x, p);
        vec.push_back(QPair<long double, long double>(i, y/yPerPix+yc-2*y/yPerPix));
    }
    drawPoints(vec, QColor::fromRgb(255, 0, 0));
}


void MainWindow::drawPoints(QVector<QPair<long double, long double> > &points, QColor c)
{
    for(int i=0; i<points.size(); i++)
    {
        if(points[i].second < 10)
            points[i].second = 10;
        if(points[i].second > graphics->height() - 10)
            points[i].second = graphics->height() - 10;
    }
    for(int i=1; i<points.size(); i++)
    {
        if(points[i-1].second != points[i].second)
            scene->addLine(points[i-1].first, points[i-1].second, points[i].first, points[i].second, QPen(c));
    }
}

void MainWindow::about()
{
    AboutDialog dialog;
    dialog.exec();
}

void MainWindow::drawIntegral()
{
    progress->setValue(0);
    int p;
    long long maxn = 0;
    QVector<QPair<long double, long double> > vec;
    if(alphaCheck->isChecked())
        p=0;
    if(bettaCheck->isChecked())
        p=1;
    if(gammaCheck->isChecked())
        p=2;
    if(deltaCheck->isChecked())
        p=3;
    QVector<double> params(4);
    params[0]=alpha;
    params[1]=betta;
    params[2]=gamma;
    params[3]=delta;
    for(int i=0; i<=this->graphics->width(); i+=5)
    {
        if(i < 10 || i > graphics->width()-10)
            continue;
        params[p]= (i-xc)*xPerPix;
        long ncol = this->NEdit->text().toInt();
        long double In = integral(ncol, params);
        long double I2n = integral(2*ncol, params);
        double pogr = deltaComboBox->currentText().toDouble();
        while (qAbs(I2n - In) > pogr)
        {
            In = I2n;
            ncol *= 2;
            I2n = integral(2*ncol, params);
        }
        if (2*ncol > maxn)
            maxn = 2*ncol;
        vec.push_back(QPair<long double, long double>(i, I2n/yPerPix+yc-2*I2n/yPerPix));
        qDebug() <<params[p];
        progress->setValue((int)(100*i/this->graphics->width() + 1));
        repaint();
    }
    progress->setValue(100);
    drawPoints(vec, QColor::fromRgb(0, 0, 255));
    maxNLabel->setText(QString::number(maxn));
}

long double MainWindow::integral(long n, const QVector<double> &params)
{
    long double res = 0;
    double a = this->aEdit->value(), b = this->bEdit->value();
    long double h = (b - a)/(double)n;
    double x = a+h;
    for(long i=1; i<=n; i++)
    {
        long double f1 = f(x, params), f2 = f(x-h, params);
        res+=f1+f2;
        x +=h;
    }
    return res*h/2.0;
}

#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QGraphicsView>
#include <QVBoxLayout>
#include <QHBoxLayout>
#include <QGridLayout>
#include <QLabel>
#include <QLineEdit>
#include <QValidator>
#include <QWidget>
#include <QComboBox>
#include <QCheckBox>
#include <QRadioButton>
#include <QPushButton>
#include <QIntValidator>
#include <QDoubleValidator>
#include <QGraphicsScene>
#include <QDebug>
#include <cmath>
#include <QVector>
#include <QDoubleSpinBox>
#include <QSpinBox>
#include <QMenu>
#include <QMenuBar>
#include <QProgressBar>
#include "aboutdialog.h"

class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
public slots:
    void startClicked();
    void about();
private:
    QGraphicsView *graphics;
    QGraphicsScene *scene;
    QDoubleSpinBox *alphaEdit, *bettaEdit, *gammaEdit, *deltaEdit, *AEdit, *BEdit, *CEdit, *DEdit, *aEdit, *bEdit;
    QProgressBar *progress;
    QSpinBox *NEdit;
    QComboBox *deltaComboBox;
    QRadioButton *alphaCheck, *bettaCheck, *gammaCheck, *deltaCheck;
    QLabel *maxNLabel;
    QLabel *xdel, *ydel;
    QPushButton *start;
    QWidget *cw;
    QMenu *mainMenu;
    QMenuBar *menuBar;
    int A, B, C, D;
    double h;
    int n, xc, yc;
    double alpha, betta, gamma, delta;
    double xPerPix, yPerPix, pixPerX, pixPerY;
    int paintWidth, paintHeight;
    void initParams();
    void createWidgets();
    void createInterface();
    void setWidgetProperties();
    void drawCoordLines();
    void drawFunction();
    void drawIntegral();
    void drawPoints(QVector<QPair<long double, long double> > &points, QColor c);
    double f(double x, const QVector<double> &params);
    long double integral(long n, const QVector<double> &params);
};

#endif // MAINWINDOW_H

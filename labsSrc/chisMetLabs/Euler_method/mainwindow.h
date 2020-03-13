#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QAction>
#include <QLabel>
#include <QDoubleSpinBox>
#include <QSpinBox>
#include <QGroupBox>
#include <QPushButton>
#include <QCheckBox>
#include <QStringList>
#include <QComboBox>
#include <QMenu>
#include <QApplication>
#include <QWidget>
#include <QContextMenuEvent>
#include <QKeyEvent>
#include <QStatusBar>
#include <QColor>

#include <math.h>
#include <stdlib.h>
#include <time.h>
#include <qwt_plot.h>
#include <qwt_plot_curve.h>
#include <qwt_plot_picker.h>

const int NMAX = 10000;
const int M = 500;

class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    explicit MainWindow(QApplication *appl);
    ~MainWindow();
private:
    QwtPlot *plot; // ������� ���������
    QwtPlotCurve *plusnCurve, *minusnCurve; // �������-���������� (�������� �� ������������� (n) � ������������� �������� (-n))
    QwtPlotPicker *picker; // ������, � ������� �������� ����������� ����� �� ������� ���������
    QLabel *label1, *label2, *label3, *labelx0, *labely0, *stbarLabel;
    QDoubleSpinBox *alphaSpin, *betaSpin, *epsSpin, *muSpin /*lambdaSpin*/, *psiSpin, *ASpin, *BSpin, *CSpin, *DSpin;
    QSpinBox *nSpin;
    QGroupBox *f1coefGrBox, *f2coefGrBox, *plotsizeGrBox, *stepsGrBox, *gridGrBox;
    QComboBox *gridComboBox;
    QPushButton *button1, *button2;
    QStringList gridlist;
    QMenu *stMenu;
    QMenu *contextMenu;
    QStatusBar *stbar;
    double alpha, beta, eps, mu, lambda, psi, a, b, c, d, delta, x0, y0;
    double **xnplus, **ynplus, **xnminus, **ynminus; // ������� � ������� � ����������� ����� ����������
    double xdata[3], oxdata[3], ydata[3], oydata[3]; // ������� ��� ���� ����������
    int n, count_trajectories;
    int red_plus[M], red_minus[M], green_plus[M], green_minus[M], blue_plus[M], blue_minus[M]; // ������������ ����� ��� ��������-����������
    void contextMenuEvent(QContextMenuEvent *cmevent); // ������� ������������ ����
    void keyPressEvent(QKeyEvent *kpevent); // ������� ������� �������
    void createMenus(QApplication *appl);
    void createPlot(); // ������ ������� ���������
    void prepareCurve(int idx); // �������������� ������������ ������-���������� ��� ���������� ������
    void createPicker(); // ������ ���������� ��� ���������� ������ �� ������� ���������
    void createLabels();
    void createSpinBoxes();
    void assemblyElements(); // ������ �������� ���� ����������
    void createGroupBoxes();
    void createComboBox();
    void createButtons();
    void createStatusBar();
    void clearPlot(); // ��������� ������� ������� ���������
    void createDataTrajectories(); // ������ ��������� ������� ��� �������� ������ � �����������
    void destroyDataTrajectories(); // ���������� ��� ������ � �����������
    void initStartTrajectory(); // �������������� ��������� ������ ��� ���������� �������-���������� (���������� ���������� �����)
    double Func1(double xn, double yn); // ���������� �������� 1 ������� � ����������� �� �������� ����������� ����������
    double Func2(double xn, double yn); // ���������� �������� 2 ������� � ����������� �� �������� ����������� ����������
    void  buildTrajectory(int idx); // ������ ���������� ������� ������� ���
    void rebuildTrajerctories(); // ������������� ��� ���������� ����� ��������� ����������
    void seeTrajectory(int idx); // ���������� ����������
    void calcAmountTrajectories(); // ������������ ���������� ������������ ��������
    int randomNumber(); // ���������� ��������� �����
    void setAxes(); // ������ ��� ��������� � ������� ���������
    void initOxOycoordinates(); // �������������� ������ ��� ����������� � ������� ��������� ���� Ox, Oy
    void parametersConfirm(); // ���������� ������� ����������
private slots:
    void checkPlotSize(); // ��������� ������������ �������� ������������ �������
    void personalData(); // Personalization
    void fixClickedPoint(const QwtDoublePoint & po1); // ������� ����� �� ������� ���������
    void clearAll(); // ��������� ������� �����
};

#endif // MAINWINDOW_H

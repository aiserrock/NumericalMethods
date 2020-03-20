#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QAction>
#include <QLabel>
#include <QDoubleSpinBox>
#include <QSpinBox>
#include <QGroupBox>
#include <QPushButton>
#include <QRadioButton>
#include <QStringList>
#include <QComboBox>
#include <QMenu>
#include <QApplication>
#include <QWidget>
#include <QContextMenuEvent>
#include <QKeyEvent>
#include <QStatusBar>

#include <math.h>
#include <qwt_plot.h>
#include <qwt_plot_curve.h>
#include <qwt_plot_grid.h>

class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    explicit MainWindow(QApplication *ap);
    ~MainWindow();
private:
    QwtPlot *plot; // ������� ���������
    QwtPlotGrid *grid; // ��������� ��������� ������� ��������� ��� � �������
    QwtPlotCurve *nCurve, *pCurve, *oxAxe, *oyAxe; // ������� (Ox, Oy, ����������-��������)
    QLabel *label1, *label2, *label3;
    QDoubleSpinBox *alphaSpin, *betaSpin, *epsSpin, *muSpin, *ASizeSpin, *BSizeSpin, *CSizeSpin, *DSizeSpin, *xoSpin;
    QSpinBox *nSpin, *mSpin, *pSpin;
    QGroupBox *coefGrBox, *drawGrBox, *iterGrBox, *pointGrBox, *showGrBox;
    QPushButton *button1, *button2;
    QRadioButton *alphaRadioButton, *betaRadioButton, *epsRadioButton, *muRadioButton;
    QMenu *contextMenu;
    QWidget *about;
    double *nx, *px, *ny, *py;
    double alpha, beta, eps, mu, a, b, c, d, x0;
    int n, len_n, m, p, len_p;
    void contextMenuEvent(QContextMenuEvent *contextmenuevent); // ������� ������������ ����
    void keyPressEvent(QKeyEvent *pressevent); // ������� ������� �������
    double Func(double X, int num_of_par, double par); // ���������� �������� �������, ��������� ��� � �� ���������
    void createMenus(QApplication *ap);
    void createPlot(); // �������� ������� ���������
    void createCurves(); // �������� ������������ ��������
    void createGrid(); // �������� ����� ��������� ������� ���������
    void createLabels(); // �������� �����
    void createSpinBoxes();
    void assemblyElements(); // ������ �������� ���� ����������
    void makeAboutWindow(); // About
    void createRadioButtons(); // �������� �����������
    void createGroupBoxes();
    void createButtons(); // �������� ������
    void buildIterationResults(int num_of_par); // ���������� ����������� ��������
    void dumpIterationsResults(); // ����� �����������-��������
    void drawGraphics(bool state); // ��������� ��������
    void setAxes(); // ������ ��� ����������� � ������� ��������� ���� Ox, Oy
    void setStartStateProgram(); // ��������� ���������� ��������� ���������
    void parametersConfirm(); // ���������� ������� ����������
    void initializeArrays(); // �������� �������� ����� ��� ��������
private slots:
    void funcToggled(bool checked); // Draw functions
    void checkPlotSize(); // �������� ������������ �������� ������������ �������
    void personalData(); // Personalization
};

#endif // MAINWINDOW_H

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
    QwtPlot *plot; // область рисования
    QwtPlotGrid *grid; // клеточное разбиение области рисования как в тетради
    QwtPlotCurve *nCurve, *pCurve, *oxAxe, *oyAxe; // графики (Ox, Oy, результаты-итерации)
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
    void contextMenuEvent(QContextMenuEvent *contextmenuevent); // событие контекстного меню
    void keyPressEvent(QKeyEvent *pressevent); // событие нажатия клавиши
    double Func(double X, int num_of_par, double par); // возвращает значение функции, зависящее ещё и от параметра
    void createMenus(QApplication *ap);
    void createPlot(); // создание области рисования
    void createCurves(); // создание отображаемых графиков
    void createGrid(); // создание сетки разбиения области рисования
    void createLabels(); // создание меток
    void createSpinBoxes();
    void assemblyElements(); // сборка внешнего вида приложения
    void makeAboutWindow(); // About
    void createRadioButtons(); // создание радиокнопок
    void createGroupBoxes();
    void createButtons(); // создание кнопок
    void buildIterationResults(int num_of_par); // построение результатов итераций
    void dumpIterationsResults(); // сброс результатов-итераций
    void drawGraphics(bool state); // отрисовка графиков
    void setAxes(); // данные для отображения в области рисования осей Ox, Oy
    void setStartStateProgram(); // установка начального состояния программы
    void parametersConfirm(); // обновление значени параметров
    void initializeArrays(); // создание массивов точек для графиков
private slots:
    void funcToggled(bool checked); // Draw functions
    void checkPlotSize(); // проверка правильности размеров отображаемой области
    void personalData(); // Personalization
};

#endif // MAINWINDOW_H

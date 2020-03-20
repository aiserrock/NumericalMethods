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
    QwtPlot *plot; // область рисования
    QwtPlotCurve *plusnCurve, *minusnCurve; // графики-траектории (строятся по положительным (n) и отрицательным индексам (-n))
    QwtPlotPicker *picker; // объект, с помощью которого считываются клики по области рисования
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
    double **xnplus, **ynplus, **xnminus, **ynminus; // массивы с данными о координатах точек траекторий
    double xdata[3], oxdata[3], ydata[3], oydata[3]; // массивы для осей коорддинат
    int n, count_trajectories;
    int red_plus[M], red_minus[M], green_plus[M], green_minus[M], blue_plus[M], blue_minus[M]; // составляющие цвета для графиков-траекторий
    void contextMenuEvent(QContextMenuEvent *cmevent); // событие контекстного меню
    void keyPressEvent(QKeyEvent *kpevent); // событие нажатия клавиши
    void createMenus(QApplication *appl);
    void createPlot(); // создаёт области рисования
    void prepareCurve(int idx); // подготавливает отображаемый график-траекторию для дальнейшей работы
    void createPicker(); // создаёт инструмент для считывания кликов на области рисования
    void createLabels();
    void createSpinBoxes();
    void assemblyElements(); // сборка внешнего вида приложения
    void createGroupBoxes();
    void createComboBox();
    void createButtons();
    void createStatusBar();
    void clearPlot(); // правильно очищает области рисования
    void createDataTrajectories(); // создаёт двумерные массивы для хранения данных о траекториях
    void destroyDataTrajectories(); // уничтожает все данные о траекториях
    void initStartTrajectory(); // инициализирует начальные данные для построения графика-траектории (запоминает координаты клика)
    double Func1(double xn, double yn); // возвращает значение 1 функции в зависимости от значений независимых переменных
    double Func2(double xn, double yn); // возвращает значение 2 функции в зависимости от значений независимых переменных
    void  buildTrajectory(int idx); // строит траекторию решения системы ОДУ
    void rebuildTrajerctories(); // перестраивает все траектории после изменения параметров
    void seeTrajectory(int idx); // отображает траекторию
    void calcAmountTrajectories(); // подсчитывает количество отображаемых графиков
    int randomNumber(); // возвращает случайные числа
    void setAxes(); // строит оси координат в области рисования
    void initOxOycoordinates(); // инициализирует данные для отображения в области рисования осей Ox, Oy
    void parametersConfirm(); // обновление значени параметров
private slots:
    void checkPlotSize(); // проверяет правильность размеров отображаемой области
    void personalData(); // Personalization
    void fixClickedPoint(const QwtDoublePoint & po1); // событие клика по области рисования
    void clearAll(); // правильно очищает экран
};

#endif // MAINWINDOW_H

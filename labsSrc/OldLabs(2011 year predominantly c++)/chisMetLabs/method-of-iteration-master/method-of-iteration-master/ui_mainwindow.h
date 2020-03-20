/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created: Fri 20. Dec 10:46:46 2013
**      by: Qt User Interface Compiler version 4.8.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QCheckBox>
#include <QtGui/QDoubleSpinBox>
#include <QtGui/QFormLayout>
#include <QtGui/QGridLayout>
#include <QtGui/QHBoxLayout>
#include <QtGui/QHeaderView>
#include <QtGui/QLabel>
#include <QtGui/QMainWindow>
#include <QtGui/QPushButton>
#include <QtGui/QRadioButton>
#include <QtGui/QSpinBox>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>
#include "qwt_plot.h"

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QHBoxLayout *horizontalLayout_2;
    QwtPlot *qwtPlot;
    QVBoxLayout *verticalLayout;
    QGridLayout *gridLayout;
    QDoubleSpinBox *cDoubleSpinBox;
    QLabel *dLabel;
    QLabel *aLabel;
    QLabel *cLabel;
    QDoubleSpinBox *dDoubleSpinBox;
    QDoubleSpinBox *bDoubleSpinBox;
    QDoubleSpinBox *aDoubleSpinBox;
    QLabel *bLabel;
    QPushButton *enableSizeButton;
    QFormLayout *formLayout_5;
    QLabel *alphaLabel;
    QDoubleSpinBox *alphaDoubleSpinBox;
    QLabel *betaLabel;
    QDoubleSpinBox *betaDoubleSpinBox;
    QLabel *epsilonLabel;
    QDoubleSpinBox *epsilonDoubleSpinBox;
    QLabel *gammaLabel;
    QDoubleSpinBox *gammaDoubleSpinBox;
    QLabel *nLabel;
    QSpinBox *nSpinBox;
    QLabel *mLabel;
    QSpinBox *mSpinBox;
    QLabel *pLabel;
    QSpinBox *pSpinBox;
    QLabel *x0Label;
    QDoubleSpinBox *x0DoubleSpinBox;
    QGridLayout *gridLayout_2;
    QRadioButton *epsilonRadioButton;
    QRadioButton *alphaRadioButton;
    QRadioButton *betaRadioButton;
    QRadioButton *gammaRadioButton;
    QHBoxLayout *horizontalLayout;
    QCheckBox *blueCheckBox;
    QCheckBox *redCheckBox;
    QLabel *imgLabel;
    QPushButton *drawButton;
    QPushButton *helpButton;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QString::fromUtf8("MainWindow"));
        MainWindow->resize(698, 543);
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        horizontalLayout_2 = new QHBoxLayout(centralWidget);
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setContentsMargins(11, 11, 11, 11);
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        qwtPlot = new QwtPlot(centralWidget);
        qwtPlot->setObjectName(QString::fromUtf8("qwtPlot"));
        qwtPlot->setBaseSize(QSize(10, 10));

        horizontalLayout_2->addWidget(qwtPlot);

        verticalLayout = new QVBoxLayout();
        verticalLayout->setSpacing(6);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        gridLayout = new QGridLayout();
        gridLayout->setSpacing(6);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        cDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        cDoubleSpinBox->setObjectName(QString::fromUtf8("cDoubleSpinBox"));
        cDoubleSpinBox->setMinimum(-100);
        cDoubleSpinBox->setMaximum(100);
        cDoubleSpinBox->setValue(-5);

        gridLayout->addWidget(cDoubleSpinBox, 1, 1, 1, 1);

        dLabel = new QLabel(centralWidget);
        dLabel->setObjectName(QString::fromUtf8("dLabel"));

        gridLayout->addWidget(dLabel, 1, 2, 1, 1);

        aLabel = new QLabel(centralWidget);
        aLabel->setObjectName(QString::fromUtf8("aLabel"));

        gridLayout->addWidget(aLabel, 0, 0, 1, 1);

        cLabel = new QLabel(centralWidget);
        cLabel->setObjectName(QString::fromUtf8("cLabel"));

        gridLayout->addWidget(cLabel, 1, 0, 1, 1);

        dDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        dDoubleSpinBox->setObjectName(QString::fromUtf8("dDoubleSpinBox"));
        dDoubleSpinBox->setMinimum(-100);
        dDoubleSpinBox->setMaximum(100);
        dDoubleSpinBox->setValue(5);

        gridLayout->addWidget(dDoubleSpinBox, 1, 3, 1, 1);

        bDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        bDoubleSpinBox->setObjectName(QString::fromUtf8("bDoubleSpinBox"));
        bDoubleSpinBox->setMinimum(-100);
        bDoubleSpinBox->setMaximum(100);
        bDoubleSpinBox->setValue(5);

        gridLayout->addWidget(bDoubleSpinBox, 0, 3, 1, 1);

        aDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        aDoubleSpinBox->setObjectName(QString::fromUtf8("aDoubleSpinBox"));
        aDoubleSpinBox->setMinimum(-100);
        aDoubleSpinBox->setMaximum(100);
        aDoubleSpinBox->setValue(-5);

        gridLayout->addWidget(aDoubleSpinBox, 0, 1, 1, 1);

        bLabel = new QLabel(centralWidget);
        bLabel->setObjectName(QString::fromUtf8("bLabel"));

        gridLayout->addWidget(bLabel, 0, 2, 1, 1);


        verticalLayout->addLayout(gridLayout);

        enableSizeButton = new QPushButton(centralWidget);
        enableSizeButton->setObjectName(QString::fromUtf8("enableSizeButton"));

        verticalLayout->addWidget(enableSizeButton);

        formLayout_5 = new QFormLayout();
        formLayout_5->setSpacing(6);
        formLayout_5->setObjectName(QString::fromUtf8("formLayout_5"));
        formLayout_5->setFieldGrowthPolicy(QFormLayout::AllNonFixedFieldsGrow);
        alphaLabel = new QLabel(centralWidget);
        alphaLabel->setObjectName(QString::fromUtf8("alphaLabel"));
        alphaLabel->setMouseTracking(true);

        formLayout_5->setWidget(0, QFormLayout::LabelRole, alphaLabel);

        alphaDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        alphaDoubleSpinBox->setObjectName(QString::fromUtf8("alphaDoubleSpinBox"));
        alphaDoubleSpinBox->setMinimum(-100);
        alphaDoubleSpinBox->setMaximum(100);
        alphaDoubleSpinBox->setValue(1);

        formLayout_5->setWidget(0, QFormLayout::FieldRole, alphaDoubleSpinBox);

        betaLabel = new QLabel(centralWidget);
        betaLabel->setObjectName(QString::fromUtf8("betaLabel"));

        formLayout_5->setWidget(1, QFormLayout::LabelRole, betaLabel);

        betaDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        betaDoubleSpinBox->setObjectName(QString::fromUtf8("betaDoubleSpinBox"));
        betaDoubleSpinBox->setMinimum(-100);
        betaDoubleSpinBox->setMaximum(100);
        betaDoubleSpinBox->setValue(1);

        formLayout_5->setWidget(1, QFormLayout::FieldRole, betaDoubleSpinBox);

        epsilonLabel = new QLabel(centralWidget);
        epsilonLabel->setObjectName(QString::fromUtf8("epsilonLabel"));

        formLayout_5->setWidget(2, QFormLayout::LabelRole, epsilonLabel);

        epsilonDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        epsilonDoubleSpinBox->setObjectName(QString::fromUtf8("epsilonDoubleSpinBox"));
        epsilonDoubleSpinBox->setMinimum(-100);
        epsilonDoubleSpinBox->setMaximum(100);
        epsilonDoubleSpinBox->setValue(1);

        formLayout_5->setWidget(2, QFormLayout::FieldRole, epsilonDoubleSpinBox);

        gammaLabel = new QLabel(centralWidget);
        gammaLabel->setObjectName(QString::fromUtf8("gammaLabel"));

        formLayout_5->setWidget(3, QFormLayout::LabelRole, gammaLabel);

        gammaDoubleSpinBox = new QDoubleSpinBox(centralWidget);
        gammaDoubleSpinBox->setObjectName(QString::fromUtf8("gammaDoubleSpinBox"));
        gammaDoubleSpinBox->setMinimum(-100);
        gammaDoubleSpinBox->setMaximum(100);
        gammaDoubleSpinBox->setValue(1);

        formLayout_5->setWidget(3, QFormLayout::FieldRole, gammaDoubleSpinBox);

        nLabel = new QLabel(centralWidget);
        nLabel->setObjectName(QString::fromUtf8("nLabel"));

        formLayout_5->setWidget(4, QFormLayout::LabelRole, nLabel);

        nSpinBox = new QSpinBox(centralWidget);
        nSpinBox->setObjectName(QString::fromUtf8("nSpinBox"));
        nSpinBox->setMinimum(1);
        nSpinBox->setMaximum(500);
        nSpinBox->setValue(25);

        formLayout_5->setWidget(4, QFormLayout::FieldRole, nSpinBox);

        mLabel = new QLabel(centralWidget);
        mLabel->setObjectName(QString::fromUtf8("mLabel"));

        formLayout_5->setWidget(5, QFormLayout::LabelRole, mLabel);

        mSpinBox = new QSpinBox(centralWidget);
        mSpinBox->setObjectName(QString::fromUtf8("mSpinBox"));
        mSpinBox->setMaximum(500);
        mSpinBox->setValue(10);

        formLayout_5->setWidget(5, QFormLayout::FieldRole, mSpinBox);

        pLabel = new QLabel(centralWidget);
        pLabel->setObjectName(QString::fromUtf8("pLabel"));

        formLayout_5->setWidget(6, QFormLayout::LabelRole, pLabel);

        pSpinBox = new QSpinBox(centralWidget);
        pSpinBox->setObjectName(QString::fromUtf8("pSpinBox"));
        pSpinBox->setMinimum(1);
        pSpinBox->setMaximum(25);
        pSpinBox->setValue(15);

        formLayout_5->setWidget(6, QFormLayout::FieldRole, pSpinBox);

        x0Label = new QLabel(centralWidget);
        x0Label->setObjectName(QString::fromUtf8("x0Label"));

        formLayout_5->setWidget(7, QFormLayout::LabelRole, x0Label);

        x0DoubleSpinBox = new QDoubleSpinBox(centralWidget);
        x0DoubleSpinBox->setObjectName(QString::fromUtf8("x0DoubleSpinBox"));
        x0DoubleSpinBox->setMinimum(-100);
        x0DoubleSpinBox->setMaximum(100);

        formLayout_5->setWidget(7, QFormLayout::FieldRole, x0DoubleSpinBox);

        gridLayout_2 = new QGridLayout();
        gridLayout_2->setSpacing(6);
        gridLayout_2->setObjectName(QString::fromUtf8("gridLayout_2"));
        epsilonRadioButton = new QRadioButton(centralWidget);
        epsilonRadioButton->setObjectName(QString::fromUtf8("epsilonRadioButton"));

        gridLayout_2->addWidget(epsilonRadioButton, 0, 1, 1, 1);

        alphaRadioButton = new QRadioButton(centralWidget);
        alphaRadioButton->setObjectName(QString::fromUtf8("alphaRadioButton"));

        gridLayout_2->addWidget(alphaRadioButton, 0, 0, 1, 1);

        betaRadioButton = new QRadioButton(centralWidget);
        betaRadioButton->setObjectName(QString::fromUtf8("betaRadioButton"));

        gridLayout_2->addWidget(betaRadioButton, 1, 0, 1, 1);

        gammaRadioButton = new QRadioButton(centralWidget);
        gammaRadioButton->setObjectName(QString::fromUtf8("gammaRadioButton"));

        gridLayout_2->addWidget(gammaRadioButton, 1, 1, 1, 1);


        formLayout_5->setLayout(8, QFormLayout::FieldRole, gridLayout_2);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        blueCheckBox = new QCheckBox(centralWidget);
        blueCheckBox->setObjectName(QString::fromUtf8("blueCheckBox"));

        horizontalLayout->addWidget(blueCheckBox);

        redCheckBox = new QCheckBox(centralWidget);
        redCheckBox->setObjectName(QString::fromUtf8("redCheckBox"));

        horizontalLayout->addWidget(redCheckBox);


        formLayout_5->setLayout(10, QFormLayout::FieldRole, horizontalLayout);


        verticalLayout->addLayout(formLayout_5);

        imgLabel = new QLabel(centralWidget);
        imgLabel->setObjectName(QString::fromUtf8("imgLabel"));

        verticalLayout->addWidget(imgLabel);

        drawButton = new QPushButton(centralWidget);
        drawButton->setObjectName(QString::fromUtf8("drawButton"));

        verticalLayout->addWidget(drawButton);

        helpButton = new QPushButton(centralWidget);
        helpButton->setObjectName(QString::fromUtf8("helpButton"));

        verticalLayout->addWidget(helpButton);


        horizontalLayout_2->addLayout(verticalLayout);

        MainWindow->setCentralWidget(centralWidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "MainWindow", 0, QApplication::UnicodeUTF8));
        dLabel->setText(QApplication::translate("MainWindow", "D:", 0, QApplication::UnicodeUTF8));
        aLabel->setText(QApplication::translate("MainWindow", "A:", 0, QApplication::UnicodeUTF8));
        cLabel->setText(QApplication::translate("MainWindow", "C:", 0, QApplication::UnicodeUTF8));
        bLabel->setText(QApplication::translate("MainWindow", "B:", 0, QApplication::UnicodeUTF8));
        enableSizeButton->setText(QApplication::translate("MainWindow", "\320\237\321\200\320\270\320\274\320\265\320\275\320\270\321\202\321\214 \321\200\320\260\320\267\320\274\320\265\321\200\321\213", 0, QApplication::UnicodeUTF8));
        alphaLabel->setText(QApplication::translate("MainWindow", "\342\215\272", 0, QApplication::UnicodeUTF8));
        betaLabel->setText(QApplication::translate("MainWindow", "\316\262", 0, QApplication::UnicodeUTF8));
        epsilonLabel->setText(QApplication::translate("MainWindow", "<html><head/><body><p><span style=\" font-size:10pt;\">\316\265</span></p></body></html>", 0, QApplication::UnicodeUTF8));
        gammaLabel->setText(QApplication::translate("MainWindow", "\316\263", 0, QApplication::UnicodeUTF8));
        nLabel->setText(QApplication::translate("MainWindow", "n", 0, QApplication::UnicodeUTF8));
        mLabel->setText(QApplication::translate("MainWindow", "m", 0, QApplication::UnicodeUTF8));
        pLabel->setText(QApplication::translate("MainWindow", "p", 0, QApplication::UnicodeUTF8));
        x0Label->setText(QApplication::translate("MainWindow", "x0", 0, QApplication::UnicodeUTF8));
        epsilonRadioButton->setText(QApplication::translate("MainWindow", "\316\265", 0, QApplication::UnicodeUTF8));
        alphaRadioButton->setText(QApplication::translate("MainWindow", "\342\215\272", 0, QApplication::UnicodeUTF8));
        betaRadioButton->setText(QApplication::translate("MainWindow", "\316\262", 0, QApplication::UnicodeUTF8));
        gammaRadioButton->setText(QApplication::translate("MainWindow", "\316\263", 0, QApplication::UnicodeUTF8));
        blueCheckBox->setText(QApplication::translate("MainWindow", "\321\201\320\270\320\275\320\270\320\271", 0, QApplication::UnicodeUTF8));
        redCheckBox->setText(QApplication::translate("MainWindow", "\320\272\321\200\320\260\321\201\320\275\321\213\320\271", 0, QApplication::UnicodeUTF8));
        imgLabel->setText(QString());
        drawButton->setText(QApplication::translate("MainWindow", "\320\235\320\260\321\200\320\270\321\201\320\276\320\262\320\260\321\202\321\214", 0, QApplication::UnicodeUTF8));
        helpButton->setText(QApplication::translate("MainWindow", "\320\241\320\277\321\200\320\260\320\262\320\272\320\260", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H

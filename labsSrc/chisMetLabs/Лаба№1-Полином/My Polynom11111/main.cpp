/*
 * File:   main.cpp
 * Author: Vovchok Sergei
 *
 * Created on 19 Сентябрь 2011 г., 1:46
 */


#include <QtGUI>
#include<QApplication>
#include"kontroller.h"


int main(int argc, char *argv[])
{
	QApplication a(argc, argv);
	//QTextCodec::setCodecForCStrings(QTextCodec::codecForName("Windows-1251")); 	
	pain t(&a);
	return a.exec();
}


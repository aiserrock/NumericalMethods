#include "aboutdialog.h"

AboutDialog::AboutDialog(QWidget *parent) :
    QDialog(parent)
{
    text = new QLabel(tr("Исходная функция Alpha*sin(tg(Betta*x))+Gamma*cos(Delta*x) <br> Выполнила студентка группы ИВТ 31-БО Губанова Мария"));
    QHBoxLayout *main = new QHBoxLayout(this);
    main->addWidget(text);
}

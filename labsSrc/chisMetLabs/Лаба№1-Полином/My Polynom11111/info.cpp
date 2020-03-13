
#include"info.h"

Info::Info()
{
        setFixedSize(400,595);
	setWindowTitle("O sozdatele programmi...");
	x=new QLabel(this);
	x->setText("<img src='spacer.gif' height='0' width='30'/><br>\
		<h2><b><img src='spacer.gif' height='0' width='30'/>Razrabotchik: </b> \
		Studentka gruppi IT-31BO\
		<br><img src='spacer.gif' height='0' width='60'/>Kuplenova Natalia Evgenievna </h2> ");
	u=new QLabel(this);
	u->move(52,130);
	QPixmap  pix;
    pix.load("0123.bmp"); 
	u->setPixmap(pix);
	ok=new QPushButton(this);
	ok->setText("Ok");
	ok->move(165,543);
	ok->resize(75,30);
	setModal(true);
}
QPushButton* Info::Ret_B()
{	return ok;	}

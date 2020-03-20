
#include<QtGUI>
#include"grClass.h"
class Graph : public QDialog
{
	Q_OBJECT
private:
	QVBoxLayout *lay;
	QFrame *dlg;
	QPushButton *bt;
	Risynok rise;
	
public:
	Graph();
	Risynok* Ret_rise();
	QPushButton* ret_But();
protected:
	void paintEvent(QPaintEvent *event);

};

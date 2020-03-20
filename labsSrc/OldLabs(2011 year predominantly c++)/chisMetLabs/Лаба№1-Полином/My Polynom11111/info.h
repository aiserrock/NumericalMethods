
#include<QtGUI>
class Info : public QDialog
{
	Q_OBJECT
private:
	QLabel *x,*u;
	QPushButton *ok;
public:
	Info();
	QPushButton* Ret_B();
};
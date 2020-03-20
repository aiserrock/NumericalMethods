
#include<QtGUI>
#include"info.h"
#include"modal.h"
#include"vid.h"
class pain : public QObject
{
	Q_OBJECT
private:
	QPainter x;
	double a,b,c,d,alf,bet,gam,del;
	Info info;
	Graph graph;
	QMessageBox xx;
	Param param;
public:
	pain(QObject *);
	pain(QApplication*);
	pain();
	public slots:
		void Clear();
		void go();
};
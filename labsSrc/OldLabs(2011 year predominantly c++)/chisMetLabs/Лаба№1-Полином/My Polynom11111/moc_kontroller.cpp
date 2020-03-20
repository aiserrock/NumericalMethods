/****************************************************************************
** Meta object code from reading C++ file 'kontroller.h'
**
** Created: Thu 10. Nov 09:31:33 2011
**      by: The Qt Meta Object Compiler version 62 (Qt 4.7.3)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "kontroller.h"
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'kontroller.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 62
#error "This file was generated using the moc from 4.7.3. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
static const uint qt_meta_data_pain[] = {

 // content:
       5,       // revision
       0,       // classname
       0,    0, // classinfo
       2,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // slots: signature, parameters, type, tag, flags
       6,    5,    5,    5, 0x0a,
      14,    5,    5,    5, 0x0a,

       0        // eod
};

static const char qt_meta_stringdata_pain[] = {
    "pain\0\0Clear()\0go()\0"
};

const QMetaObject pain::staticMetaObject = {
    { &QObject::staticMetaObject, qt_meta_stringdata_pain,
      qt_meta_data_pain, 0 }
};

#ifdef Q_NO_DATA_RELOCATION
const QMetaObject &pain::getStaticMetaObject() { return staticMetaObject; }
#endif //Q_NO_DATA_RELOCATION

const QMetaObject *pain::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->metaObject : &staticMetaObject;
}

void *pain::qt_metacast(const char *_clname)
{
    if (!_clname) return 0;
    if (!strcmp(_clname, qt_meta_stringdata_pain))
        return static_cast<void*>(const_cast< pain*>(this));
    return QObject::qt_metacast(_clname);
}

int pain::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QObject::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        switch (_id) {
        case 0: Clear(); break;
        case 1: go(); break;
        default: ;
        }
        _id -= 2;
    }
    return _id;
}
QT_END_MOC_NAMESPACE

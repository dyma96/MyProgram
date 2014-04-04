#pragma once

#include <QMainWindow>
#include <QGraphicsView>
#include "ovalGun.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private slots:
    void onUpClicked();

    void on_down_clicked();

private:
    Ui::MainWindow *ui;
    //QGraphicsView *graphicsView;
    QGraphicsScene *scene;
    ovalGun *gun;
};


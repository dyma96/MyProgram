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

    void onDownClicked();

    void onShootClicked();

private:
    Ui::MainWindow *ui;
    QGraphicsScene *scene;
    ovalGun *gun;
    cannonball *ball;
};


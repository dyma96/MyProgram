#pragma once

#include <QMainWindow>
#include <QGraphicsView>
#include <QTimer>
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
    /// Up gun's barrel.
    void onUpClicked();

    /// Down gun's barrel.
    void onDownClicked();

    /// Shoot ball.
    void onShootClicked();

    /// Do, when timer 'timeout'.
    void funcTimer();

private:
    Ui::MainWindow *ui;
    QGraphicsScene *scene;
    ovalGun *gun;
    cannonball *ball;
    QTimer timer;

};


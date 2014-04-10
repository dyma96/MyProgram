#pragma once

#include <QMainWindow>
#include <QGraphicsView>
#include <QTimer>
#include <QGraphicsSimpleTextItem>
#include "ovalGun.h"
#include "cannonball.h"
#include "targetClass.h"
#include <QShortcut>

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

    /// Ball's peed down.
    void onPowerDownClicked();

    /// Ball's peed up.
    void onPowerUpClicked();

private:
    ///
    void shortcutInitialize();

    Ui::MainWindow *ui;
    QGraphicsScene *scene;
    ovalGun *gun;
    cannonball *ball;
    QTimer timer;
    targetClass *target;
    QGraphicsSimpleTextItem *textResult;

    QShortcut *shortcutUp;
    QShortcut *shortcutDown;
    QShortcut *shortcutLeft;
    QShortcut *shortcutRight;
    QShortcut *shortcutPower;
};


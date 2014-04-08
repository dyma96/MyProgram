#include "mainWindow.h"
#include "ui_mainWindow.h"
#include <QPen>
#include <QBrush>
#include <QGraphicsView>
#include <QtCore/QDebug>
#include <QTimer>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    scene = new QGraphicsScene();
    ui->graphicsView->setAlignment(Qt::AlignLeft | Qt::AlignTop);

    gun = new ovalGun(ui->graphicsView->width(), scene->width(), scene->height());
    scene->addItem(gun);

    ball= new cannonball(ui->graphicsView->width() / 10.0, 20.0, 45.0,
                         gun->getRadius(), gun->getHeightBarrel(),
                         (double)scene->width(), (double)scene->height());
    scene->addItem(ball);

    ui->graphicsView->setScene(scene);

    connect(ui->up, &QPushButton::clicked, this, &MainWindow::onUpClicked);
    connect(ui->down, &QPushButton::clicked, this, &MainWindow::onDownClicked);
    connect(ui->shoot, &QPushButton::clicked, this, &MainWindow::onShootClicked);
}

MainWindow::~MainWindow()
{
    delete ui;
    delete gun;
    delete ball;
}

void MainWindow::onUpClicked()
{
    gun->cornerUp();
    ball->setCorner(gun->getCorner());
    scene->invalidate(gun->boundingRect());
}

void MainWindow::onDownClicked()
{
    gun->cornerDown();
    ball->setCorner(gun->getCorner());
    scene->invalidate(gun->boundingRect());
}

void MainWindow::onShootClicked()
{
    connect(&timer, &QTimer::timeout, this, &MainWindow::funcTimer);
    timer.start(10);

}

void MainWindow::funcTimer()
{
    ball->setPos(0.0);
    scene->invalidate(ball->boundingRect());
    if (!ball->isBallInScene())
    {
        timer.stop();
        return;
    }
}

#include "mainWindow.h"
#include "ui_mainWindow.h"
#include <QPen>
#include <QBrush>
#include <QGraphicsView>
#include <QtCore/QDebug>
#include <QTimer>
#include <QProgressBar>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    scene = new QGraphicsScene();
    ui->graphicsView->setAlignment(Qt::AlignLeft | Qt::AlignTop);

    gun = new ovalGun(ui->graphicsView->width(), scene->width(), scene->height());
    scene->addItem(gun);

    ball= new cannonball(gun->getWidthBarrel(), 50.0, 45.0,
                         gun->getRadius() + gun->getHeightBarrel(),
                         (double)scene->width(), (double)scene->height());
    scene->addItem(ball);

    target = new targetClass(40, scene->width(), scene->height());
    scene->addItem(target);

    textResult = new QGraphicsSimpleTextItem("GO!!");
    scene->addItem(textResult);

    ui->graphicsView->setScene(scene);
    ui->progressBarSpeed->setValue(ball->getSpeed());

    connect(ui->up, &QPushButton::clicked, this, &MainWindow::onUpClicked);
    connect(ui->down, &QPushButton::clicked, this, &MainWindow::onDownClicked);
    connect(ui->shoot, &QPushButton::clicked, this, &MainWindow::onShootClicked);
    connect(ui->powerDown, &QPushButton::clicked, this, &MainWindow::onPowerDownClicked);
    connect(ui->powerUp, &QPushButton::clicked, this, &MainWindow::onPowerUpClicked);
    connect(&timer, &QTimer::timeout, this, &MainWindow::funcTimer);
}

MainWindow::~MainWindow()
{
    delete ui;
    delete gun;
    delete ball;
    delete target;
    delete scene;
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
    timer.start(10);
}

void MainWindow::funcTimer()
{
    qDebug() << ball->getPosition() << ui->graphicsView->frameRect();
    ball->setPos(0.0);
    scene->invalidate(ball->boundingRect());
    if (target->getPosition().contains(ball->getPosition())
        || !ui->graphicsView->frameRect().contains(ball->getPosition())/*ball->isBallInTarget(target->getPosition())*/)
    {
        qDebug() << ui->graphicsView->frameRect();
        timer.stop();
        ball->stopTimer();
        if (target->getPosition().contains(ball->getPosition()))
            textResult->setText("YOU WIN!! CONGRATULATIONS!!!");
        else
            textResult->setText("YOU LOSE!! LOSER!!!");
        target->changeTarget(30);

        return;
    }
}

void MainWindow::onPowerDownClicked()
{
    if (ball->getSpeed() < 1)
        return;
    ball->speedDown();
    ui->progressBarSpeed->setValue(ball->getSpeed());
}

void MainWindow::onPowerUpClicked()
{
    if (ball->getSpeed() > 99)
        return;
    ball->speedUp();
    ui->progressBarSpeed->setValue(ball->getSpeed());
}

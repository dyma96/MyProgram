#include "mainWindow.h"
#include "ui_mainWindow.h"
#include <QPen>
#include <QBrush>
#include <QGraphicsView>
#include <QtCore/QDebug>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    scene = new QGraphicsScene();
    ui->graphicsView->setAlignment(Qt::AlignLeft | Qt::AlignTop);

    gun = new ovalGun(ui->graphicsView->width(), ui->graphicsView->width(), ui->graphicsView->height());
    scene->addItem(gun);

    ball= new cannonball(ui->graphicsView->width() / 10, 10, ui->graphicsView->width(), ui->graphicsView->height());
    scene->addItem(ball);

    ui->graphicsView->setScene(scene);

    connect(ui->up, &QPushButton::clicked, this, &MainWindow::onUpClicked);
    connect(ui->down, &QPushButton::clicked, this, &MainWindow::onDownClicked);
    connect(ui->shoot, &QPushButton::clicked, this, &MainWindow::onShootClicked);

}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::onUpClicked()
{
    gun->cornerUp();
    scene->invalidate(gun->boundingRect());
}

void MainWindow::onDownClicked()
{
    gun->cornerDown();
    scene->invalidate(gun->boundingRect());
}

void MainWindow::onShootClicked()
{
    QElapsedTimer timer;
    timer.start();
    int i = 0;
    while (i < 10)
    {
        if (timer.elapsed() > i * 100)
        {
            ball->setPos(timer.elapsed() / 100);
            scene->invalidate(ball->boundingRect());
            i++;
        }
    }
}

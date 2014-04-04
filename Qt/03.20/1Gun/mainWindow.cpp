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
    gun = new ovalGun(ui->graphicsView->width(), scene->width(), scene->height());
    scene->addItem(gun);
    ui->graphicsView->setScene(scene);

    connect(ui->up, &QPushButton::clicked, this, &MainWindow::onUpClicked);
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

void MainWindow::on_down_clicked()
{
    gun->CornerDown();
    scene->invalidate(gun->boundingRect());
}

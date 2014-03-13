#include "mainWindow.h"
#include "ui_mainWindow.h"
#include "calculate.h"
//#include <QDebug>
#include <QLineEdit>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    calculate = new calculateNamespace::Calculate();

//    connect(ui->pushButton_2, &QPushButton::pressed, this, &MainWindow::on_actionReload_triggered);
    connect(ui->pushButton1, &QPushButton::clicked, this, &MainWindow::pushButton1_clicked);
    connect(ui->pushButton2, &QPushButton::clicked, this, &MainWindow::pushButton2_clicked);
    connect(ui->pushButton3, &QPushButton::clicked, this, &MainWindow::pushButton3_clicked);
    connect(ui->pushButton4, &QPushButton::clicked, this, &MainWindow::pushButton4_clicked);
    connect(ui->pushButton5, &QPushButton::clicked, this, &MainWindow::pushButton5_clicked);
    connect(ui->pushButton6, &QPushButton::clicked, this, &MainWindow::pushButton6_clicked);
    connect(ui->pushButton7, &QPushButton::clicked, this, &MainWindow::pushButton7_clicked);
    connect(ui->pushButton8, &QPushButton::clicked, this, &MainWindow::pushButton8_clicked);
    connect(ui->pushButton9, &QPushButton::clicked, this, &MainWindow::pushButton9_clicked);
    connect(ui->pushButton0, &QPushButton::clicked, this, &MainWindow::pushButton0_clicked);

    connect(ui->pushButtonPlus, &QPushButton::clicked, this, &MainWindow::pushButtonPlus_clicked);
    connect(ui->pushButtonMinus, &QPushButton::clicked, this, &MainWindow::pushButtonMinus_clicked);

    connect(ui->pushButtonMult, &QPushButton::clicked, this, &MainWindow::pushButtonMult_clicked);
    connect(ui->pushButtonDel, &QPushButton::clicked, this, &MainWindow::pushButtonDel_clicked);
    connect(ui->pushButtonEqual, &QPushButton::clicked, this, &MainWindow::pushButtonEqual_clicked);
//    connect(ui->pushButtonMinus, &QPushButton::clicked, this, SLOT(close()));

    delete calculate;
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::pushButton1_clicked()
{
    calculate->addNumber(1);
    ui->lineEdit->setText("1");
}
void MainWindow::pushButton2_clicked()
{
    calculate->addNumber(2);
    ui->lineEdit->setText("2");
}
void MainWindow::pushButton3_clicked()
{
    calculate->addNumber(3);
    ui->lineEdit->setText("3");
}
void MainWindow::pushButton4_clicked()
{
    calculate->addNumber(4);
    ui->lineEdit->setText("4");
}
void MainWindow::pushButton5_clicked()
{
    calculate->addNumber(5);
    ui->lineEdit->setText("5");
}
void MainWindow::pushButton6_clicked()
{
    calculate->addNumber(6);
    ui->lineEdit->setText("6");
}
void MainWindow::pushButton7_clicked()
{
    calculate->addNumber(7);
    ui->lineEdit->setText("7");
}
void MainWindow::pushButton8_clicked()
{
    calculate->addNumber(8);
    ui->lineEdit->setText("8");
}
void MainWindow::pushButton9_clicked()
{
    calculate->addNumber(9);
    ui->lineEdit->setText("9");
}
void MainWindow::pushButton0_clicked()
{
    calculate->addNumber(0);
    ui->lineEdit->setText("0");
}

void MainWindow::pushButtonPlus_clicked()
{
    calculate->addSign('+');
    ui->lineEdit->setText("+");
}
void MainWindow::pushButtonMinus_clicked()
{
    calculate->addNumber('-');
    ui->lineEdit->setText("-");
}
void MainWindow::pushButtonMult_clicked()
{
    calculate->addNumber('*');
    ui->lineEdit->setText("*");
}
void MainWindow::pushButtonDel_clicked()
{
    calculate->addNumber('/');
    ui->lineEdit->setText("/");
}
void MainWindow::pushButtonEqual_clicked()
{
    // !!!  Преобразование типов не работает. КАК??

    ui->lineEdit->setText((QString)(calculate->outputResult() + '0'));
 //   qDebug() << calculate->outputResult();
}



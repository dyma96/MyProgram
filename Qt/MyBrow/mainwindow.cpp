#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->webView->load(QUrl("http://google.com/"));

    PageProgress = new QProgressBar(this);
    PageProgress->setVisible(false);
    ui->statusBar->addPermanentWidget(PageProgress);

    connect(ui->pushButton_2, &QPushButton::pressed, this, &MainWindow::on_actionReload_triggered);
    connect(ui->pushButton, &QPushButton::pressed, this, &MainWindow::on_pushButton_clicked);
    connect(ui->pushButton_3, &QPushButton::pressed, this, &MainWindow::on_pushButton_3_clicked);
    connect(ui->pushButton_4, &QPushButton::pressed, this, &MainWindow::on_pushButton_4_clicked);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_actionReload_triggered()
{
    ui->webView->reload();
}

void MainWindow::on_pushButton_clicked()
{
    ui->webView->back();
}

void MainWindow::on_pushButton_3_clicked()
{
    ui->webView->forward();
}

void MainWindow::on_pushButton_4_clicked()
{
    ui->webView->stop();
}

void MainWindow::on_lineEdit_returnPressed()
{
    QString urltogo = ui->lineEdit->text();
    QUrl url(urltogo);
    ui->webView->load(url);
}

void MainWindow::on_webView_loadProgress(int progress)
{
    ui->statusBar->showMessage("Загрузка "+ui->webView->url().toString()+"...",500);
}

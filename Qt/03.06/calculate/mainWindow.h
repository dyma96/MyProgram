#pragma once

#include <QMainWindow>
#include "calculate.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    //MainWindow(QWidget *parent);
    ~MainWindow();

private slots:
    void pushButton1_clicked();
    void pushButton2_clicked();
    void pushButton3_clicked();
    void pushButton4_clicked();
    void pushButton5_clicked();
    void pushButton6_clicked();
    void pushButton7_clicked();
    void pushButton8_clicked();
    void pushButton9_clicked();
    void pushButton0_clicked();
    void pushButtonPlus_clicked();
    void pushButtonMinus_clicked();
    void pushButtonMult_clicked();
    void pushButtonDel_clicked();
    void pushButtonEqual_clicked();

private:
    Ui::MainWindow *ui;
    calculateNamespace::Calculate *calculate;

};

#pragma once

#include <QMainWindow>
#include <QLineEdit>
#include <QProgressBar>

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
    void on_actionReload_triggered();

    void on_pushButton_clicked();

    void on_pushButton_3_clicked();

    void on_pushButton_4_clicked();

    void on_lineEdit_returnPressed();

    void on_webView_loadProgress(int progress);

private:
    Ui::MainWindow *ui;
    QProgressBar *PageProgress;

};

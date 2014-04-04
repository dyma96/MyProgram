#pragma once
#include <QGraphicsView>

class myGraphicsView : public QGraphicsView
{
public:
    myGraphicsView();
    void resizeEvent(QResizeEvent *event) override;
};


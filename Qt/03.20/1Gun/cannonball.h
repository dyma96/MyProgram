#pragma once
#include <QGraphicsScene>
#include <QGraphicsItem>
#include <QPainter>
#include <QPoint>
#include <QElapsedTimer>

class cannonball : public QGraphicsItem
{
public:
    cannonball();
    cannonball(int rad, int speed, int widthRectBall, int heightRectBall);
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
    QPoint position;
    void setPos(int time);

private:
    QPoint beginSpeed;
    QPoint beginPosition;
    int corner;
    int radiusBall;
    int time;
    int g;
    int widthRect;
    int heightRect;

};

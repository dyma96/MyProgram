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
    cannonball(double rad, double speed, double BeginCorner,
               double beginPositionX, double beginPositionY,
               double widthRectBall, double heightRectBall);

    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

    /// Return posituon ball.
    QPoint position;

    /// Set position with time.
    void setPos(double time);

    /// Start timer, if it's not start.
    void startTimer();

    /// Set new corner.
    void setCorner(int newCorner);

    /// Return true if ball is in scene.
    bool isBallInScene();

private:
    QPoint beginSpeed;
    QPoint beginPosition;
    double corner;
    double radiusBall;
    double time;
    double g = 20.0;
    double widthRect;
    double heightRect;
    QElapsedTimer timer;
};

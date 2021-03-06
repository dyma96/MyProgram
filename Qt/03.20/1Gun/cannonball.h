#pragma once
#include <QGraphicsScene>
#include <QGraphicsItem>
#include <QPainter>
#include <QPoint>
#include <QElapsedTimer>
#include <QTransform>

class cannonball : public QGraphicsItem
{
public:
    cannonball();
    cannonball(double rad, double speed, double beginCorner,
               double beginTranslate, double widthRectBall, double heightRectBall);

    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

    /// Set position with time.
    void setPos(double time);

    /// Start timer, if it's not start.
    void startTimer();

    /// Stop timer.
    void stopTimer();

    /// Set new corner.
    void setCorner(int newCorner);

    /// Increase speed.
    void speedUp();

    /// Reduce speed.
    void speedDown();

    /// Return position ball.
    QPoint getPosition();

    /// Return speed.
    int getSpeed();


private:
    /// Translate beginPosition.
    void translate(int height);

    /// Rotate speed.
    void translateSpeed(int newCorner);

    QPoint beginSpeed;
    QPoint beginPosition;
    double corner;
    double radiusBall;
    double time;
    QPoint g;
    double widthRect;
    double heightRect;
    QElapsedTimer timer;
    QPoint position;
    QTransform transformation;
    double beginTranslation;
};

#include "cannonball.h"
#include <QWidget>
#include <QDebug>
#include <QTimer>
#include <QTransform>

cannonball::cannonball()
{
}

cannonball::cannonball(double rad = 50, double speed = 20, double BeginCorner = 45,
                       double beginPositionX = 10, double beginPositionY = 10,
                       double widthRectBall = 300, double heightRectBall = 300)
{
    qDebug() << rad;
    radiusBall = rad;
    beginSpeed.setY(0);
    beginSpeed.setX(speed);
    position = QPoint(0,0);
    time = 0;
    g = 10;
    widthRect = widthRectBall * 2;
    heightRect = heightRectBall * 2;
    beginPosition = QPoint(beginPositionX, beginPositionY);
    timer.invalidate();
    position = QPoint(0, 0);
    corner = BeginCorner;
}

QRectF cannonball::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
}

void cannonball::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QTransform *transformation = new QTransform();
    transformation->translate(0, widget->height() - 1);
    transformation->rotate(-corner);
    transformation->translate(beginPosition.x() + beginPosition.y(), 0);
    painter->setTransform(*transformation);
    painter->drawEllipse(position.y(), position.x(), radiusBall, radiusBall);
}

void cannonball::setPos(double time)
{
    startTimer();
    if (time == 0)
        time = timer.elapsed() / 300.0;
    position.setY(beginSpeed.x() * time);
    position.setX(-beginSpeed.y() * time + g * time * time / 2.0);
    qDebug() << position;
}

void cannonball::startTimer()
{
    if (!timer.isValid())
        timer.start();
}

void cannonball::setCorner(int newCorner)
{
    corner = newCorner;
}

bool cannonball::isBallInScene()
{
    if (position.x() >= 0 && position.x() <= 100
            && position.y() >= 0 && position.y() <= 100)
        return true;
    return false;
}

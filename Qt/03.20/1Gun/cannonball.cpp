#include "cannonball.h"
#include <QWidget>
#include <QTimer>
#include <QTransform>
#include <QRect>
#include <math.h>

cannonball::cannonball()
{
}

cannonball::cannonball(double rad = 50, double speed = 20, double beginCorner = 45,
                       double beginTranslate = 10, double widthRectBall = 300, double heightRectBall = 300)
{
    radiusBall = rad;
    beginSpeed = QPoint(speed, 0);
    position = QPoint(0,0);
    time = 0;
    g = QPoint(0,20);
    widthRect = widthRectBall * 2;
    heightRect = heightRectBall * 2;
    beginTranslation = beginTranslate;
    beginPosition = QPoint(0, 0);
    timer.invalidate();
    position = QPoint(0, 0);

    corner = 0;
    translateSpeed(beginCorner);
    corner = beginCorner;
}

QRectF cannonball::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
}

void cannonball::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    if (!timer.isValid())
        return;
    translate(widget->height());
    painter->drawEllipse(QPoint(position.x(), position.y()) , radiusBall, radiusBall);
}

void cannonball::setPos(double time)
{
    startTimer();
    if (time == 0)
        time = timer.elapsed() / 300.0;
    position.setX(beginSpeed.x() * time + beginPosition.x());
    position.setY(beginSpeed.y() * time + g.y() * time * time / 2.0 + beginPosition.y());
}

void cannonball::startTimer()
{
    if (!timer.isValid())
        timer.start();
}

void cannonball::stopTimer()
{
    timer.invalidate();
}

void cannonball::setCorner(int newCorner)
{
    translateSpeed(newCorner);
    corner = newCorner;
}

void cannonball::speedUp()
{
    translateSpeed(0);
    beginSpeed = QPoint(beginSpeed.x() + 3, beginSpeed.y());
    translateSpeed(2 * corner);
}

void cannonball::speedDown()
{
    translateSpeed(0);
    beginSpeed = QPoint(beginSpeed.x() - 3, beginSpeed.y());
    translateSpeed(2 * corner);
}

QPoint cannonball::getPosition()
{
    return position;
}

void cannonball::translate(int height)
{
    transformation.reset();
    transformation.translate(0, height - 1);
    transformation.rotate(-corner);
    transformation.translate(beginTranslation, 0);
    transformation.rotate(-corner);
    beginPosition = transformation.map(QPoint(0,0));
}

void cannonball::translateSpeed(int newCorner)
{
    QTransform transformSpeed;
    transformSpeed.rotate(corner - newCorner);
    beginSpeed = transformSpeed.map(beginSpeed);
}

int cannonball::getSpeed()
{
    if (beginSpeed.x() <= 0 || beginSpeed.y() >= 0)
        return 0;
    return sqrt(beginSpeed.x() * beginSpeed.x() + beginSpeed.y() * beginSpeed.y());
}

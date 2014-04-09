#include "cannonball.h"
#include <QWidget>
#include <QTimer>
#include <QTransform>
#include <QRect>
#include <QDebug>

cannonball::cannonball()
{
}

cannonball::cannonball(double rad = 50, double speed = 20, double beginCorner = 45,
                       double beginTranslate = 10, double widthRectBall = 300, double heightRectBall = 300)
{
//    qDebug() << rad;
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

void cannonball::translateSpeed(int newCorner)
{
    QTransform transformSpeed;
    transformSpeed.rotate(corner - newCorner);
    beginSpeed = transformSpeed.map(beginSpeed);
    qDebug() << beginSpeed;
}

QRectF cannonball::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
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

void cannonball::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    if (!timer.isValid())
        return;
    translate(widget->height());
//    painter->setTransform(transformation);
    painter->drawEllipse(QPoint(position.x(), position.y()) , radiusBall, radiusBall);
}

void cannonball::setPos(double time)
{
    startTimer();
    if (time == 0)
        time = timer.elapsed() / 300.0;
    position.setX(beginSpeed.x() * time + beginPosition.x());
    position.setY(beginSpeed.y() * time + g.y() * time * time / 2.0 + beginPosition.y());
    qDebug() << position;
}

void cannonball::startTimer()
{
    if (!timer.isValid())
        timer.start();
}

void cannonball::setCorner(int newCorner)
{
    translateSpeed(newCorner);
    corner = newCorner;
}

bool cannonball::isBallInScene()
{
    if (position.x() >= 0 && position.x() <= 500
            && position.y() >= 0 && position.y() <= 500)
        return true;
    return false;
}

bool cannonball::isBallInTarget(QRect target)
{
    /*if (position.x() <= target.bottomRight().x() && position.x() >= target.bottomLeft().x()
        && position.y() <= target.bottomLeft().y() && position.y() >= target.topLeft().y())
        return true;*/
    return target.contains(QPoint(position.x(), position.y()));
}

void cannonball::speedUp()
{
    translateSpeed(0);
    beginSpeed = QPoint(beginSpeed.x() + 3, beginSpeed.y() + 3);
    translateSpeed(2 * corner);
}

void cannonball::speedDown()
{
    translateSpeed(0);
    beginSpeed = QPoint(beginSpeed.x() - 3, beginSpeed.y() - 3);
    translateSpeed(2 * corner);
}

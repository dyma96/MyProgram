#include "cannonball.h"
#include <QWidget>
#include <QDebug>
#include <QTimer>
#include <QTransform>

cannonball::cannonball()
{
}

cannonball::cannonball(int rad = 50, int speed = 10, int widthRectBall = 300, int heightRectBall = 300)
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
    beginPosition = QPoint(10,10);

//    position = beginPosition;
}

QRectF cannonball::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
}

void cannonball::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QTransform *transformation = new QTransform();
    transformation->translate(0, widget->height() - 1);
    transformation->rotate(-90);
    painter->setTransform(*transformation);
//    painter->drawEllipse(100,100, radiusBall,radiusBall);
    painter->drawEllipse(position.x(), position.y(), radiusBall, radiusBall);
    qDebug() << "y" << position.y() << "x" << position.x();
}

void cannonball::setPos(int time)
{
//    qDebug() << time << "Ololo paint ball";
    position.setY(beginSpeed.y() * time + beginPosition.y());
    position.setX((-beginSpeed.x() * time + g * time * time / 2 + beginPosition.x()) % 100);
    qDebug() << position;
    position.setX(100);
    position.setY(100);

}

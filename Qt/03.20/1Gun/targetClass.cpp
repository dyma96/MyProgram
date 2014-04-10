#include "targetClass.h"
#include <QPainter>
#include <stdlib.h>
#include <QDateTime>

targetClass::targetClass()
{ }

targetClass::targetClass(int radiusTarget = 30, int widthRectTarget = 0, int heightRectTarget = 0)
{
    radius = radiusTarget;
    widthRect = widthRectTarget;
    heightRect = heightRectTarget;
    qsrand(QDateTime::currentMSecsSinceEpoch());
    position = QPoint(radius * 4 + qrand() % 400, radius * 2 + qrand() % 200);
}

QRectF targetClass::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
}

void targetClass::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawEllipse(position, radius, radius);
}

QRect targetClass::getPosition() const
{
    return QRect(position - QPoint(radius, radius),
                 position + QPoint(radius, radius));
}

void targetClass::changeTarget(int radiusTarget)
{
    radius = radiusTarget;
    position = QPoint(radius * 4 + qrand() % 400, radius * 2 + qrand() % 200);
}

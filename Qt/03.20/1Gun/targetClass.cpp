#include "targetClass.h"
#include <QPainter>
#include <stdlib.h>

targetClass::targetClass()
{ }

targetClass::targetClass(int radiusTarget = 30, int widthRectTarget = 0, int heightRectTarget = 0)
{
    radius = radiusTarget;
    widthRect = widthRectTarget;
    heightRect = heightRectTarget;
    position = QPoint(200.0 + qrand() % 200, 60.0 + qrand() % 400);
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


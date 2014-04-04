#include "ovalGun.h"
#include <QTransform>
#include <QColor>
#include <QtCore/qmath.h>
#include <QDebug>
#include <QWidget>

ovalGun::ovalGun()
{
    radius = 10;
    corner = 45;
    widthBarrel = radius / 10;
    heightBarrel = radius / 2;
    widthRect = radius * 2;
    heightRect = radius * 2;
}

ovalGun::ovalGun(int rad, int width = 300, int height = 300)
{
    radius = rad;
    corner = 45;
    widthBarrel = radius / 10;
    heightBarrel = radius / 2;
    widthRect = width * 2;
    heightRect = height * 2;
}

QRectF ovalGun::boundingRect() const
{
    return QRectF(0, 0, widthRect, heightRect);
}
void ovalGun::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    QTransform *transformation = new QTransform();
    transformation->translate(0, widget->height() - 1);
    transformation->rotate(-90);
    painter->setTransform(*transformation);
// draw Pie.
    transformation->translate(-radius * 2, -radius);
    painter->setTransform(*transformation);
    painter->drawPie(radius, 0.0, 2 * radius, 2 * radius, -90 * 16 ,90 * 16);
    transformation->translate(radius * 2, radius);
    painter->setTransform(*transformation);

// draw Barrel.
    transformation->rotate(-corner);
    transformation->translate(0, radius);
    transformation->translate(-widthBarrel / 2 , 0);
    painter->setTransform(*transformation);
    painter->drawRect(0, 0, widthBarrel, heightBarrel);
    transformation->rotate(corner);
    transformation->translate(widthBarrel / 2 , heightBarrel);
    painter->setTransform(*transformation);
}

void ovalGun::cornerUp()
{
    if (corner >= 89)
        return;
    corner += 2;
}
void ovalGun::CornerDown()
{
    if (corner <= 2)
        return;
    corner -= 2;
}

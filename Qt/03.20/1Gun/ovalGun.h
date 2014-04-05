#pragma once
#include <QGraphicsScene>
#include <QGraphicsItem>
#include <QPainter>
#include "cannonball.h"

class ovalGun : public QGraphicsItem
{
public:
    ovalGun();
    ovalGun(int rad, int width, int height);
    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);
    void cornerUp();
    void cornerDown();
//    void shoot();

private:
    int radius;
    int corner;
    int widthBarrel;
    int heightBarrel;
    int widthRect;
    int heightRect;
};

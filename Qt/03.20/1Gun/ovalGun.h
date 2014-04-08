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

    /// Corner increment.
    void cornerUp();

    /// Corner decrement.
    void cornerDown();

    /// Return height barrel.
    int getHeightBarrel();

    /// Return radius.
    int getRadius();

    /// Return corner barrel.
    int getCorner();

private:
    int radius;
    int corner;
    int widthBarrel;
    int heightBarrel;
    int widthRect;
    int heightRect;
};

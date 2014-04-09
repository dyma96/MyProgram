#pragma once
#include <QGraphicsScene>
#include <QGraphicsItem>
#include <QPainter>

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
    int getHeightBarrel() const;

    /// Return height barrel.
    int getWidthBarrel() const;

    /// Return radius.
    int getRadius() const;

    /// Return corner barrel.
    int getCorner() const;

private:
    int radius;
    int corner;
    int widthBarrel;
    int heightBarrel;
    int widthRect;
    int heightRect;
};

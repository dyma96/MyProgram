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
    void cornerUp();
    void CornerDown();

private:
    int radius;
    int corner;
    int widthBarrel;
    int heightBarrel;
    int widthRect;
    int heightRect;

//    int beginSpeed;
};

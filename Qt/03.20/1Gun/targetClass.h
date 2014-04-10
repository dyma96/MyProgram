#pragma once
#include <QGraphicsScene>
#include <QGraphicsItem>
#include <QPainter>
#include <QPoint>

class targetClass : public QGraphicsItem
{
public:
    targetClass();
    targetClass(int radiusTarget, int widthRectTarget, int heightRectTarget);

    QRectF boundingRect() const;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

    /// Return ractangle.
    QRect getPosition() const;

    /// Change radius and position target.
    void changeTarget(int radiusTarget);

    /// Return radius.
    int radiusTarget();

private:
    int radius;
    QPoint position;
    int widthRect;
    int heightRect;
};


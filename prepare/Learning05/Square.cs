using System;

class Square:Shape
{
    double _side;

    public Square(string ShapeColor, double Side):base(ShapeColor)
    {
        _side = Side;
        
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}
using System;

class Rectangle:Shape
{
    double _length;
    double _width;

    public Rectangle(string Color, double Length, double Width): base(Color)
    {
        _length = Length;
        _width = Width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}
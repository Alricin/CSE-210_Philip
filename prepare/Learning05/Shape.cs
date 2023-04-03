using System;

class Shape
{
    private string _color;
    
    public Shape(string ShapeColor)
    {
        _color = ShapeColor;
    }
    public void SetShapeColor(string Color)
    {
        _color = Color;
    }
    public string GetShapeColor()
    {
        return _color;
    }
    public virtual double GetArea()
    {
        return 1;
    }
}
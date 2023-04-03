using System;

class Program
{
    static void Main(string[] args)
    {
        Square Object1 = new Square("red", 7);
        Console.WriteLine(Object1.GetArea());

        List<Shape> Items = new List<Shape>();
        Items.Add(Object1);
        Rectangle Object2 = new Rectangle("blue", 4, 5);
        Circle Object3 = new Circle("yellow", 5);
        Items.Add(Object2);
        Items.Add(Object3);

        
    }
}
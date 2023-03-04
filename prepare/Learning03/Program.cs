using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Value1 = new Fraction();
        Value1.PrintDecimalAndFraction();

        Fraction Value2 = new Fraction(5);
        Value2.PrintDecimalAndFraction();

        Fraction Value3 = new Fraction(3,4);
        Value3.PrintDecimalAndFraction();

        Fraction Value4 = new Fraction(1,3);
        Value4.PrintDecimalAndFraction();
        
    }
}
using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int WholeNumber)
    {
        _numerator = WholeNumber;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public void SetNumerator(int numerator)
    {
        numerator = _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }
    public void SetDenominator(int denominator)
    {
        denominator = _denominator;
    }
    
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public float GetDecimal()
    {
        return (double)_numerator/(double)_denominator;
    }

    public void PrintDecimalAndFraction()
    {
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }

}
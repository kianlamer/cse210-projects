using System;
using System.Diagnostics.Contracts;
using System.IO.Pipes;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // constructors
    public Fraction()
    {
        _numerator = 0;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator != 0 ? denominator : throw new ArgumentException("Denominator cannot be zero");
    }

    // getters and setters
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value != 0)
            {
                _denominator = value;
            }
            else
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
        }
    }

    // method to return fractional representation
    public string GetFractionalRepresentation()
    {
        return $"{_numerator}/{_denominator}";
    }

    // method to return decimal representation
    public double GetDecimalRepresentation()
    {
        return (double)_numerator / _denominator;
    }

}
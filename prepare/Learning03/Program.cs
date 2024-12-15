using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(3, 4);
        Console.WriteLine("Fractional Representation: " + fraction1.GetFractionalRepresentation());
        Console.WriteLine("Decimal Representation:" + fraction1.GetDecimalRepresentation());

        Fraction fraction2 = new Fraction();
        fraction2.Numerator = 5;
        fraction2.Denominator = 8;
        Console.WriteLine("Fractional Representation: " + fraction2.GetFractionalRepresentation());
        Console.WriteLine("Decimal Representation: " + fraction2.GetDecimalRepresentation());
    }
}
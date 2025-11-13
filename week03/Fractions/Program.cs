using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        fraction1.SetBottom(2);
        Console.WriteLine($"Fraction 1: {fraction1.GetTop()}/{fraction1.GetBottom()}");

        Fraction fraction2 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 2: {fraction2.GetTop()}/{fraction2.GetBottom()}");

        Fraction fraction3 = new Fraction(5);
        Console.WriteLine($"Fraction 3: {fraction3.GetTop()}/{fraction3.GetBottom()}");

        Console.WriteLine($"Fraction 1 as decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2 as decimal: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3 as decimal: {fraction3.GetDecimalValue()}"); 
        Console.WriteLine();
        Console.WriteLine($"Fraction 1 using ToString(): {fraction1.ToString()}");
        Console.WriteLine($"Fraction 2 using ToString(): {fraction2.ToString()}");
        Console.WriteLine($"Fraction 3 using ToString(): {fraction3.ToString()}");

    }
}
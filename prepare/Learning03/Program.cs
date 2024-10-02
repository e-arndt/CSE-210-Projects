using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 5 Create the Getters and Setters
        Console.Clear();
        Console.WriteLine("Welcome to the Fraction Generator");
        Console.WriteLine();

        // Console.WriteLine("1/1 Instance, First Constructor, No Arguments");
        // Fraction f1 = new Fraction();
        

        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
        // Console.WriteLine();


        // Console.WriteLine("6/1 Instance, First Constructor, One Argument");
        // Fraction f2 = new Fraction();
        // f2.SetTop(6);
        

        // Console.WriteLine(f2.GetTop());
        // Console.WriteLine(f2.GetBottom());
        // Console.WriteLine();


        // Console.WriteLine("6/7 Instance, First Constructor, Two Arguments");
        // Fraction f3 = new Fraction();
        // f3.SetTop(6);
        // f3.SetBottom(7);

        // Console.WriteLine(f3.GetTop());
        // Console.WriteLine(f3.GetBottom());
        // Console.WriteLine();


        // Step 6 Create methods to return the representations
        Console.WriteLine("Fraction and Decimal, No Arguments");
        Fraction f4 = new Fraction();
        
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine();


        Console.WriteLine("Fraction and Decimal, One Argument");
        Fraction f5 = new Fraction(5);
        
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Console.WriteLine();


        Console.WriteLine("Fraction and Decimal, Two Arguments");
        Fraction f6 = new Fraction(3, 4);
        
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
        Console.WriteLine();


        Console.WriteLine("Fraction and Decimal, Two Arguments");
        Fraction f7 = new Fraction(2, 6);
        
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());
        Console.WriteLine();

    }


}
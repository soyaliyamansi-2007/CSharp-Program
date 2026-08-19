using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double result = num1 / num2;
            Console.WriteLine("Division = " + result);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}

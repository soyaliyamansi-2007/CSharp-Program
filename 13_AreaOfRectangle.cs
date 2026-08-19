using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("Area of Rectangle = " + area);
    }
}

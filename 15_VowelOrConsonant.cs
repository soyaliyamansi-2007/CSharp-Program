using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an alphabet: ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
            ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine("The character is a Vowel.");
        }
        else
        {
            Console.WriteLine("The character is a Consonant.");
        }
    }
}

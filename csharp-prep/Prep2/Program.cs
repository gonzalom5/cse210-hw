using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   

        Console.Write("Please enter your grade percentage: ");
        string value = Console.ReadLine();

        int x = int.Parse(value);

        if (x >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

          if (x >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
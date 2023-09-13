using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string score = Console.ReadLine();
        int percent = int.Parse(score);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if(percent >= 60 && percent < 100 && (percent % 10) < 3)
        {
            letter += "-";
        }
        else if (percent >= 60 && percent < 90 && (percent % 10) >= 7)
        {
            letter += "+";
        }

        Console.WriteLine($"Your grade is: {letter}");
         
         if (percent >= 70)
        {
            Console.WriteLine("Congratulations, You Passed!");
        }
        else
        {
            Console.WriteLine("Do not Give up and Keep Trying!");
        }


    }    
}
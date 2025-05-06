using System;
using System.Collections.Generic;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);
            }
        } while (response != 0);

        //Sum of numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        //Average number
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Largest Number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.Write($"The largest number is: {largest}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int response = -1;
        
        Console.WriteLine("What is the magic number?");
        
        while (response != magicNumber)
        {   
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());

            if (magicNumber > response)
            {
               Console.WriteLine("higher");
            }
            else if (magicNumber < response)
            {
               Console.WriteLine("lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
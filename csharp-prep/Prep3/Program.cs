using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while(playAgain == "yes")
        {
        
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int response = -1;
            int count = 0;

            while(response != number)
            {
                count +=1;
                Console.Write("What is your guess? ");
                response = int.Parse(Console.ReadLine());

                if(number > response)
                {
                    Console.WriteLine("Higher");
                }
                else if(number < response)
                {
                    Console.WriteLine("Lower");
                }

                else if(number == response)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You took {count} guesses");
                    Console.Write("Play Again? ");
                    playAgain = Console.ReadLine();
                }    
            }
            if(playAgain == "no")
                {
                    Console.WriteLine("Thanks for Playing!");
                }    
        }
        
    }
}
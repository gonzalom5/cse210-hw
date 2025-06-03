using System;

public class Program
{
    static void Main(string[] args)
    {
        RandomScripture library = new RandomScripture();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine("\nAll words are hidden. The program will now exit.");
                break;
            }
        }
    }
}
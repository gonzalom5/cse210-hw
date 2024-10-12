using System;
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool isTrue = true;
        while (isTrue)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);

                string userResponse = Console.ReadLine();

                Entry entry = new Entry()
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = randomPrompt,
                    _entryText = userResponse
                };

                journal.AddEntry(entry);
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                journal.LoadFromFile();
            }
            else if (userInput == "4")
            {
                journal.SaveToFile();
            }
            else if (userInput == "5")
            {
                isTrue = false;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("You have {} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    if (goalType == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is A short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        SimpleGoal
                    }

                    break;
                case "2":
                    Console.WriteLine("The goals are:");

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":
                    Console.WriteLine("\n Goodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Thread.Sleep(2000);
                    continue;
            }
            

        }
    }
}
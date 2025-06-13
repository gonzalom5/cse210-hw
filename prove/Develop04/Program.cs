using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("\n Goodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Thread.Sleep(3000);
                    continue;
            }
            if (activity != null)
            {
                activity.PerformActivity();
            }
        }
    }
}
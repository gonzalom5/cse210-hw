class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Budget Tracker!");

        User user = new User("Gonzalo");
        BudgetManager manager = new BudgetManager(user);

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Add Income");
            Console.WriteLine("3. Show Summary");
            Console.WriteLine("4. Exit");
            Console.Write("What are you selecting? ");

            string input = Console.ReadLine();
            if (input == "1") manager.AddExpense();
            else if (input == "2") manager.AddIncome();
            else if (input == "3") manager.ShowSummary();
            else if (input == "4") break;
            else Console.WriteLine("\nInvalid option.");
        }

        Console.WriteLine("Goodbye!");
    }
}
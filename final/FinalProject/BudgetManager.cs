public class BudgetManager
{
    protected User _user;
    protected List<Transaction> _transactions;
    protected List<Category> _categories;

    public BudgetManager(User user)
    {
        _user = user;
        _transactions = new List<Transaction>();
        _categories = new List<Category>
        {
            new Category("Groceries"),
            new Category("Salary")
        };
    }

    public void AddExpense()
    {
        Console.WriteLine("\n    Add Expense    ");

        string description = Ask("Enter expense description");
        decimal amount = AskAmount("Enter expense amount");

        Expense expense = new Expense(description, amount, _categories[0]);
        expense.Apply(_user.GetBudget());
        _transactions.Add(expense);

        Console.WriteLine("Expense added.");
    }

    public void AddIncome()
    {
        Console.WriteLine("\n    Add Income    ");

        string description = Ask("Enter income description");
        decimal amount = AskAmount("Enter income amount");

        Income income = new Income(description, amount, _categories[1]);
        income.Apply(_user.GetBudget());
        _transactions.Add(income);

        Console.WriteLine("Income added.");
    }

    public void ShowSummary()
    {
        Budget budget = _user.GetBudget();

        Console.WriteLine($"\n   Budget Summary for {_user.GetName()}   ");
        Console.WriteLine($"Total Income: {budget.GetIncome():C}");
        Console.WriteLine($"Total Expenses: {budget.GetExpenses():C}");
        Console.WriteLine($"Remaining Balance: {budget.GetBalance():C}");

        Console.WriteLine("\n    Transactions    ");
        if (_transactions.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
            return;
        }

        foreach (Transaction t in _transactions)
        {
            Console.WriteLine(t.ToString());
        }
    }

    private string Ask(string message)
    {
        Console.Write(message + ": ");
        return Console.ReadLine();
    }

    private decimal AskAmount(string message)
    {
        while (true)
        {
            Console.Write(message + ": ");
            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                return value;

            Console.WriteLine("Please enter a valid positive number.");
        }
    }
}
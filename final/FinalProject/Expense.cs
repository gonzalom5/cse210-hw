public class Expense : Transaction
{
    public Expense(string description, decimal amount, Category category)
        : base(description, amount, category) { }

    public override void Apply(Budget budget)
    {
        budget.AddExpense(_amount);
    }
}
public class Income : Transaction
{
    public Income(string description, decimal amount, Category category)
        : base(description, amount, category) { }

    public override void Apply(Budget budget)
    {
        budget.AddIncome(_amount);
    }
}
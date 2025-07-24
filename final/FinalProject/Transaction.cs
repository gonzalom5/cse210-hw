public abstract class Transaction
{
    protected string _description;
    protected decimal _amount;
    protected Category _category;

    public Transaction(string description, decimal amount, Category category)
    {
        _description = description;
        _amount = amount;
        _category = category;
    }

    public string GetDescription() => _description;
    public decimal GetAmount() => _amount;
    public Category GetCategory() => _category;

    public abstract void Apply(Budget budget);

    public override string ToString()
    {
        string label;

        if (this is Income)
        {
            label = "INCOME";
        }
        else
        {
            label = "EXPENSE";
        }
        return label + ": " + _description + " (" + _category.GetName() + "): " + _amount.ToString("C");
    }      
}


public class Budget
{
    protected decimal _totalIncome;
    protected decimal _totalExpenses;

    public Budget()
    {
        _totalIncome = 0;
        _totalExpenses = 0;
    }

    public void AddIncome(decimal amount)
    {
        _totalIncome += amount;
    }

    public void AddExpense(decimal amount)
    {
        _totalExpenses += amount;
    }

    public decimal GetIncome() => _totalIncome;
    public decimal GetExpenses() => _totalExpenses;
    public decimal GetBalance() => _totalIncome - _totalExpenses;
}
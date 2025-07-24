public class User
{
    protected string _name;
    protected Budget _budget;

    public User(string name)
    {
        _name = name;
        _budget = new Budget();
    }

    public string GetName() => _name;
    public Budget GetBudget() => _budget;
}
public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(4);
    }   

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        Spinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(5);
    }
    protected void Spinner(int seconds)
    {
        String[] spinner = { "|", "/", "-", "\\"};
        int totalSeconds = seconds * 1000 / 500;

        for (int i = 0; i < totalSeconds; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public abstract void PerformActivity();
}

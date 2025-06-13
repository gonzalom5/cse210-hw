public class ListingActivity : Activity
{
    private readonly Random random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some attributes that you admire in others?",
        "When was the last time you felt a deep sense of gratitude?",
    };
    //This new list will help to avoid repetition in the promtps
    private List<string> _repeatingPrompts;  
    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your " +
            "life by having you list items in a certain area.\n")
    {
        _repeatingPrompts = new List<string>(_prompts);
    }

    //If all prompts have been used, the list will reset to make sure all prompts are shown without repetition.
    private string GetRandomPrompt()
    {
        if (!_repeatingPrompts.Any())
        {
            _repeatingPrompts = new List<string>(_prompts);
        }
        int index = random.Next(_repeatingPrompts.Count);
        string newPrompt = _repeatingPrompts[index];
        _repeatingPrompts.RemoveAt(index);
        return newPrompt;
    }
    public override void PerformActivity()
    {
        Console.Clear();
        StartActivity();
        List<string> items = new List<string>();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"  ---{prompt}---\n");
        Console.Write("You may begin in: ");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    } 
}
public class ReflectionActivity : Activity
{
    private readonly Random random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };
    //This new list will help to avoid repetition in the promtps
    private List<string> _repeatingPrompts;  
    //This new list will help to avoid repetition in the questions 
    private List<string> _repeatingQuestions; 


    public ReflectionActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience." +
        " This will help you recorgnize the power you have and how you can use it in ohter aspects of your life.\n")
    {
        _repeatingPrompts = new List<string>(_prompts);
        _repeatingQuestions = new List<string>(_questions);
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
    //If all questions have been used, the list will reset to make sure all questions are shown without repetition.
    private string GetRandomQuestion()
    {
        if (!_repeatingQuestions.Any())
        {
            _repeatingQuestions = new List<string>(_questions);
        }

        int index = random.Next(_repeatingQuestions.Count);
        string newQuestion = _repeatingQuestions[index];
        _repeatingQuestions.RemoveAt(index);
        return newQuestion;
    }
    public override void PerformActivity()
    {
        StartActivity();
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"  ---{prompt}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();

        int time = _duration;
        while (time > 0)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            Spinner(8);
            Console.WriteLine();
            time -= 8;
        }
        EndActivity();
    }    
}
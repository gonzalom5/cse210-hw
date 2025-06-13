public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly." +
        "Clear your mind and focus on your breathing.\n")
    { 
        
    }

    public override void PerformActivity()
    {   
        Console.Clear();
        StartActivity();
        int duration = _duration;
        while (duration > 0)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            Countdown(4);
            duration -= 4;
            Console.Write("Now breathe out...");
            Countdown(5);
            duration -= 5;
        }
        EndActivity();
    }
}

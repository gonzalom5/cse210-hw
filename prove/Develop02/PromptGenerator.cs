using System;
public class PromptGenerator
{
    private List<string> _questionPrompt = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What motivated me to keep going today?"
    };
     public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_questionPrompt.Count);
        return _questionPrompt[randomNumber];
    }
}
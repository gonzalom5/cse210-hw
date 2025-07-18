using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {_totalScore}");
    }

    public int GetTotalScore()
    {
        return _totalScore;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _totalScore += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
            Console.WriteLine($"You now have {_totalScore} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _totalScore = int.Parse(lines[0]);

            foreach (string line in lines[1..])
            {
                string[] splitLine = line.Split(':');
                string type = splitLine[0];
                string[] parts = splitLine[1].Split(',');

                if (type == "SimpleGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int bonusPoints = int.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    goal.SetCurrentCount(currentCount);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}
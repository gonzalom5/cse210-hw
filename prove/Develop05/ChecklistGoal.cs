using System;
using System.Reflection;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        string status;

        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }

        return $"{status} {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_targetCount},{_currentCount}";
    }
   
}
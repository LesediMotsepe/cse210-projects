using System;

namespace Develop06;

public class SimpleGoal:Goal
{
   private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    :base(name,description,points)
    {
        Name = name;
        Description = description;
        Points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete => _isComplete;

    public override string GetStringRepresentation()
    {
        return _isComplete ? "[X] " + Name : "[ ] " + Name;
    }
}

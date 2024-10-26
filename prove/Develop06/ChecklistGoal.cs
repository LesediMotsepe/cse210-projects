using System;

namespace Develop06;

public class ChecklistGoal:Goal
{
 private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    :base(name,description,points)
    {
        Name = name;
        Description = description;
        Points = points;
        _target = target;
        _bonus = bonus;
        _amountComplete = 0;
    }

    public override void RecordEvent()
    {
        _amountComplete++;
    }

    public override bool IsComplete => _amountComplete >= _target;

    public override string GetStringRepresentation()
    {
        return _amountComplete + "/" + _target + " " + Name;
    }

    public string GetDetailsString()
    {
        return Description + " (" + Points + " points, target: " + _target + ", bonus: " + _bonus + ")";
    }
}

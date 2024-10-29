using System;

namespace Develop06;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Goal Manager Started..");
        CreateGoal();
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Score: " + _score);
        ListGoalNames();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine(checklistGoal.GetDetailsString());
            }
            else
            {
                Console.WriteLine(goal.Description + " (" + goal.Points + " points)");
            }
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter goal type: ");
        int goalType = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetStringRepresentation());
        }

        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber];
        selectedGoal.RecordEvent();

        
        if (selectedGoal is SimpleGoal simpleGoal && simpleGoal.IsComplete)
        {
            _score += simpleGoal.Points;
        }
        else if (selectedGoal is EternalGoal eternalGoal)
        {
            _score += eternalGoal.Points; 
        }
        else if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
        {
            _score += checklistGoal.Points + checklistGoal.Points;
        }

        Console.WriteLine("Event recorded successfully!");
        }
        else
       {
        Console.WriteLine("Invalid goal number");
       }
    }
        

    
}

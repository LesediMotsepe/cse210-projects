using System;
using Develop06;
class Program
{
    static void Main(string[] args)
    {
       GoalManager goalManager = new GoalManager();

        Console.WriteLine("Welcome to Goal Manager!");

        while (true)
        {
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateSimpleGoal(goalManager);
                    break;
                case 2:
                    CreateEternalGoal(goalManager);
                    break;
                case 3:
                    CreateChecklistGoal(goalManager);
                    break;
                case 4:
                    RecordEvent(goalManager);
                    break;
                case 5:
                    DisplayGoals(goalManager);
                    break;
                case 6:
                    DisplayScore(goalManager);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateSimpleGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
        goalManager._goals.Add(simpleGoal);
        Console.WriteLine("Simple goal created successfully!");
    }

    static void CreateEternalGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        EternalGoal eternalGoal = new EternalGoal(name, description, points);
        goalManager._goals.Add(eternalGoal);
        Console.WriteLine("Eternal goal created successfully!");
    }

    static void CreateChecklistGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
        goalManager._goals.Add(checklistGoal);
        Console.WriteLine("Checklist goal created successfully!");
    }

    static void RecordEvent(GoalManager goalManager)
    {
        DisplayGoals(goalManager);

        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goalManager._goals.Count)
        {
            goalManager._goals[goalNumber].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal number");
        }
    }

    static void DisplayGoals(GoalManager goalManager)
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goalManager._goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalManager._goals[i].GetStringRepresentation()}");
        }
    }

    static void DisplayScore(GoalManager goalManager)
    {
        Console.WriteLine($"Your current score is: {goalManager._score}");
    }
}
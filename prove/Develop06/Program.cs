using System;
using Develop06;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");
         // Instantiate GoalManager
        GoalManager goalManager = new GoalManager();

        // Instantiate SimpleGoal
        SimpleGoal simpleGoal = new SimpleGoal("Learn C#", "Learn C# programming language", 100);
        goalManager._goals.Add(simpleGoal);

        // Instantiate EternalGoal
        ExternalGoal eternalGoal = new ExternalGoal("Practice Coding", "Practice coding every day", 50);
        goalManager._goals.Add(eternalGoal);

        // Instantiate ChecklistGoal
        ChecklistGoal checklistGoal = new ChecklistGoal("Complete Projects", "Complete 5 projects", 200, 5, 100);
        goalManager._goals.Add(checklistGoal);

        // Start the GoalManager
        goalManager.Start();
    
    }
}
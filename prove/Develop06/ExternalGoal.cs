using System;

namespace Develop06;

public class ExternalGoal:Goal
{ 
    private int EventCount;
  public ExternalGoal(string name, string description, int points)
  :base(name,description,points)
    {
        //Name = name;
       // Description = description;
       // Points = points;
    }

    public override void RecordEvent()
    {
        // Award recurring points each time the event is recorded
        Console.WriteLine($"Eternal goal '{Name}' event recorded. Awarding {Points} points.");

        
        if (EventCount == 0)
        {
             EventCount = 1;
         }
         else
         {
             EventCount++;
             Console.WriteLine($"This is the {EventCount} time this event has been recorded.");
         }
    }
    

    public override bool IsComplete => false;

    public override string GetStringRepresentation()
    {
        return $"[ ]{Name} ({Points} External goal points)";
    }
}

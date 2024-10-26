using System;
using System.ComponentModel;

namespace Develop06;

public abstract class Goal
{
  public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
public Goal(string name,string description,int points)

{
Name = name;
Description = description;
Points = points;
}

    public abstract void RecordEvent();
    public abstract bool IsComplete { get; }
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
      return $"{Description}({Points}) points";
    }
}

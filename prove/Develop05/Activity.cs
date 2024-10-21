using System;

namespace Develop05;

public class Activity
{
   public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {Name}...");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {Name}.");
    }

    public void ShowSpinner(int seconds)
    {
        DisplayStartingMessage();
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(1000);
        }
        DisplayEndingMessage();
    }

    public void ShowCountDown(int seconds)
    {
        DisplayStartingMessage();
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        DisplayEndingMessage();
    }
}

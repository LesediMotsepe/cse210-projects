using System;

namespace Develop05;

public class Breathing:Activity
{
  public Breathing(string name, string description, int duration) 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 6)
    {
        

    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breath out...");
            Thread.Sleep(2000);
        }
        DisplayEndingMessage();
    }
}

using System;

namespace Develop05;

public class Listing:Activity
{
  public int _Count { get; set; }
  public List<string> _Prompts { get; set; }

    public Listing(int count, List<string> prompts)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 12)
    {
        _Count = count;
        _Prompts.Add("Who are the people that you apreviate?");
        _Prompts.Add("Who are the people yu have helped this week?");
        _Prompts.Add("Who are some of your personal hereos?");
    }

    public void Run()
    {
        Console.WriteLine("Provide the following information:");
        List<string> responses = new List<string>();
        foreach (var prompt in _Prompts)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            responses.Add(response);
        }
        Console.WriteLine("Thank you for providing the information.");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        Console.WriteLine(_Prompts[index]);
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        for (int i = 0; i < _Count; i++)
        {
            Console.WriteLine($"Enter item {i + 1}:");
            string item = Console.ReadLine();
            list.Add(item);
        }
        return list;
    }
}

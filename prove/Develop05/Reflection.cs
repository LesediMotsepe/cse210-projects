using System;

namespace Develop05;

public class Reflection:Activity
{
  public List<string> Prompts { get; set; }
    public List<string> Questions { get; set; }

    public Reflection(List<string> prompts, List<string> questions)
    :base("Reflection activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",6)
    {
        prompts.Add("Think of a time you stood up for someone else");
        prompts.Add("Think of a time when you did something really difficult");
        prompts.Add("Think of a time when you helped someone in need");
        prompts.Add("Think of a time when you did something truly selfless");
        questions.Add("Why was this expirience meaningful to you?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different from other times when you were not as successful?");
        questions.Add("What was you favourite thing about this expirience?");
        questions.Add("What would you learn from this expirience that applies to other situations?");
        questions.Add("What did you learn about yourself through this expirience?");
        questions.Add("How can you keep this expirence in mind in the future?");
    }

    public void Run()
    {
        Console.WriteLine("Reflect on the following:");
        foreach (var prompt in Prompts)
        {
            DisplayPrompt(prompt);
            foreach (var question in Questions)
            {
                DisplayQuestions(question);
            }
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(Questions.Count);
        return Questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestions(string question)
    {
        Console.WriteLine($"Question: {question}");
    }
}

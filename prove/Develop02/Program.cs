using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        var prompts = new List<string>
        {
            "What's your favourite memory",
            "Describe a place you've never been",
            "Write about your goals"
        };

        var journal = new Journal(prompts);
         while (true)
         {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1.Add Entry");
            Console.WriteLine("2.Display All entries");
            Console.WriteLine("3.Save to File");
            Console.WriteLine("4.Load from File");
            Console.WriteLine("5.Exit");

            Console.WriteLine("Choose an option");
             var option = Console.ReadLine();
            switch(option)
            {
                case"1":
                  Console.Write("Enter date: ");
                  var date =Console.ReadLine();
                  Console.Write("Enter prompt(or press Enter for random):");
                  var prompt= Console.ReadLine();
                  if(string.IsNullOrEmpty(prompt))
                  {
                    prompt = journal.PromptGenerator.GetRandomPrompt();
                  }
                  Console.Write("Enter entry text:");
                  var entryText= Console.ReadLine();
                  journal.AddEntry(new Entry(date,prompt,entryText));
                  break;
                case"2":
                  journal.DisplayAll();
                  break;
                case "3":
                   Console.Write("Enter File Path:");
                    var file = Console.ReadLine();
                    journal.LoadFromFile(file);

                  break;
                case "4":
                   Console.Write("Enter file Path: ");
                   file =Console.ReadLine();
                   journal.LoadFromFile(file);

                  break;
                case"5":
                  return;
                  default:
                   Console.WriteLine("Invalid option. Please choose again.");
                  break;

            }
         }
    }
}
using System;
using Develop05;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Console.WriteLine("Activity Manager Menu");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Exit");
        
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                Breathing breathing = new Breathing( "","",5);
                breathing.Run();
                break;
            case 2:
                Listing listing = new Listing(5,new List<string>{"Prompt 1","prompt 2"});
                listing.Run();
                break;
            case 3:
                Reflection reflecting = new Reflection(new List<string>{},new List<string>{});
                
                reflecting.Run();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    
    }
}
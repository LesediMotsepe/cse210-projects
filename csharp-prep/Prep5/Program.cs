using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userNAME= PromptUsername();
        int userNumber = PromptUserNumber();
        int squaredNumber = squaredNumber(userNumber);
        DisplayResult(userNAME, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!");
    }
    static string PromptUsername()
    {
        Console.Write("Please write your name: ");
        return Console.ReadLine();
    }
    static PromptUserNumber()
    {
        while(true)
        {
            Console.Write("Please write your favourite number");
            if (int.TryParse(Console.ReadLine(),out int number))
            {
                retur number;
            }
            Console.WriteLine("Invalis input.Please enter a whole number");
        }
    }
    static int squaredNumber(int number)
    {
        Console.WriteLine($"Hello,{name}!The square of your favourite number  is {squaredNumber}.");
    }
   
    
}
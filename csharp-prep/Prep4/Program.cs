using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<string> numbers = new List<string>();
       while(true)
       {
        Console.Write("Enter a  numbers (write 0 to complete): ");
        string userInput=Console.ReadLine();
        int number;
        if(int.TryParse(userInput, out number))
        {

        if (number==0)
        {
            break;
        }
        else
        {
        numbers.Add(number);
        Console.WriteLine($"Added {number} to the list");
        }
        }
        else
        {
            Console.WriteLine("Invalid input,please enter a number");
        }
       }
       Console.WriteLine("Your numbers:");

       foreach (int number in numbers)
       {
        Console.WriteLine(number);
       }
        int sum = numbers.Sum();
        Console.WriteLine($"Sum:{sum}");

        double average=numbers.Average();
        Console.WriteLine{$"Average:{average:F2}"};

        int max =numbers.Max();
        Console.WriteLine($"Maximum number:{max}")
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("ENTER YOUR MARKS");
        string input=Console.ReadLine();
        int grade;
        while (!int.TryParse(input,out grade))
        {
            Console.Write("Invailid input.Please enter correct marks: ");
            input=Console.ReadLine();
        }

        if (grade>=90)
        {
            Console.WriteLine("Cogratulations you've recieved an A");
        }
        if (grade>=80)
        {
            Console.WriteLine("Keep its up you recieved a B");
        }

        if (grade >=70)
        {
            Console.WriteLine("Wow you got yourself a C!");
        }
        if (grade >=60)
        {
            Console.WriteLine("ok thats a D");
        }
        if (grade <=59)
        {
            Console.WriteLine("Better luck next time but thats an F");
        }

    }
}
using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Assigment project=new Assigment("Samuel Benett "," Mutiplication");
        string summary=project.GetSummary();
        Console.WriteLine(summary);
        Console.Read();

        MathsAssignment paper= new MathsAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string HomeworksList =paper.GetHomeworksList();
        Console.WriteLine(HomeworksList);
        Console.Read();

      

        
        WritingAssignment book = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string test = book.GetWritingInformation();
        Console.WriteLine(test);
        Console.Read();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        job job1 = new job();
        Resume myResume = new Resume();

        job1._jobtitle = "Software Engineer";
        job1._company="Sync Tech";
        myResume._jobs[0]._jobtitle;
    }
}
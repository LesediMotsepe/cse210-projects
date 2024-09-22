using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rand=new Random();
        int MagNumber=rand.Next(1,101);
        int guessCount=0;
        bool Correctguess=false;

        while(!Correctguess)
        {
        Console.WriteLine("What is your guess? ");
        string input1=Console.ReadLine();
        
        int guess=int.Parse(input1);
        guessCount++;
         
        if (MagNumber==guess)
        {
            Correctguess=true;
            Console.WriteLine($"Wow you guessed correctly!!!You guessed {MagNumber} in {guessCount} attempts");
        }
        else if (MagNumber>guess)
        {
            Console.WriteLine("Higher");
        }
        else if (MagNumber<guess)
        {
            Console.WriteLine("Lower");
        }
    
        }
        Console.WriteLine("Do you want to play again?")
        string answer=Console.ReadLine();

        
    }
}
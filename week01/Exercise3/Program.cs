using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 11);
        
        int guess = -1;
        Console.WriteLine ("");
        while (guess != magic_number)
        {
            Console.Write("What is your guess Number?");
            string Guess_number = Console.ReadLine();
            guess = int.Parse(Guess_number);
            if (magic_number > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            
        }
    Console.WriteLine("You guess it");
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
        Console.Write("Enter number:  ");
        number = int.Parse(Console.ReadLine());
        if (number !=0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int n in numbers)
        {
        sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");
        int count = 0;
        int average = 0;
        count = numbers.Count;
        average = sum / count;
        Console.WriteLine($"The average is : {average}");
        int best_so_far = -1;
        foreach (int n in numbers)
        {
            if (n > best_so_far)
            {
                best_so_far = n;
            }
        }
        Console.WriteLine($"The largest number is {best_so_far}");

    }
}
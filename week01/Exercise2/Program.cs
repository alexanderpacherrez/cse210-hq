using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent? ");
        string percent = Console.ReadLine();
        int number = int.Parse(percent);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            Console.WriteLine($"Your note is {letter}");

        if (number >= 70)
        {
            Console.WriteLine("Good job. You passed!");
        }
        else
        {
            Console.WriteLine("You will do good the next time.");
        }
    }
}
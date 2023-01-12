using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int percentage = int.Parse(userInput);

        string letterGrade = "";

        if (percentage >= 90 && percentage <= 100)
        {
            letterGrade = "A";
        }
        
        else if (percentage >= 80 && percentage <= 89)
        {
            letterGrade = "B";
        }

        else if (percentage >= 70 && percentage <= 79)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60 && percentage <= 69)
        {
            letterGrade = "D";
        }

        else if (percentage < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
}
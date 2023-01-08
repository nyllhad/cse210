using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int percentage = int.Parse(userInput);

        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }

        else if (percentage >= 70)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60)
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
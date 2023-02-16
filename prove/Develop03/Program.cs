using System;

class Program
{
    static void Main(string[] args)
    {
        // This will start by displaying "AAA" and waiting for the user to press the enter key
        Console.WriteLine("AAA");
        Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        Console.WriteLine("_");

        Scripture listP = new Scripture();
        listP._promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?",
            "What will I do differently tomorrow?"
        };
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //Display welcome
        Console.WriteLine("Deep Thoughts by Jack Handey");
        Console.WriteLine(" ");
        Console.WriteLine("Please select a number from the following menu options.");

        //Display menu
        Menu options = new Menu();
        options._writeNew = "1. New Entry";
        options._display = "2. Display Journal";
        options._load = "3. Load File";
        options._save = "4. Save File";
        options._quit = "5. Quit";

        Journal allMenu = new Journal();
        allMenu._menu.Add(options);

        allMenu.Menu();

        Selection listP = new Selection();
        listP._promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?",
            "What will I do differently tomorrow?"
        };

        listP.DisplayPrompt();
        allMenu._menu.Add(options);
    }
}
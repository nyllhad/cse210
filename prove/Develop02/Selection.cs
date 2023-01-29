using System;
using System.IO;

public class Selection
{
    public List<string> _promptList = new List<string>();

    public void DisplayPrompt()
    {
        Console.Write($"Please select an option. ");
        string toDo = Console.ReadLine();
        string answer = "";

        if (toDo == "1")
        {
            Random r = new Random();
            int getRandom = r.Next(0, _promptList.Count());

            Console.WriteLine(_promptList[getRandom]);
            answer = Console.ReadLine();
        }

        //Load file
        //Couldn't figure out how to load it.
        else if (toDo == "2")
        {
            string fileName = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        }

        else if (toDo == "3")
        {

        }

//Save file
        else if (toDo == "4")
        {
            string myJournal = "myFile.txt";
            string response = answer;

            using (StreamWriter outputFile = new StreamWriter(myJournal))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{response}");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "red";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }
    }
}
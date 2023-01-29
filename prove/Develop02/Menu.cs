using System;

public class Menu
{
    public string _writeNew;
    public string _display;
    public string _save;
    public string _load;
    public string _quit;
    public void Display()
    {
        Console.WriteLine(_writeNew);
        Console.WriteLine(_display);
        Console.WriteLine(_save);
        Console.WriteLine(_load);
        Console.WriteLine(_quit);
    }
}
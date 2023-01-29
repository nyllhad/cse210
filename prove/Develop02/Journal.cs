using System;

public class Journal
{
    public List<Menu> _menu = new List<Menu>();

    public void Menu()
    {
        foreach (Menu menuTotal in _menu)
        {
            menuTotal.Display();
        }
    }
}

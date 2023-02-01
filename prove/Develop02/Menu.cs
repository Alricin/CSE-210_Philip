using System;

public class Menu
{
    public int _SelectionValue = 0;
    
    public Menu()
    {

    }

    public void SelectionScreen()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
    
}
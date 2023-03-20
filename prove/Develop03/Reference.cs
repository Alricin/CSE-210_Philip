using System;

public class Reference
{
    private string _reference;

    public Reference()
    {

    }

    public int ChooseScripture()
    {
        Console.WriteLine("Choose one of the following scriptures to memorize:");
        Console.WriteLine("John 3:16");
        Console.WriteLine("Proverbs 3:5-6");
        Console.WriteLine("1 Nephi 3:7");
        Console.WriteLine('D&C 19:18-19');
        _reference = Console.ReadLine();
        return _reference;

    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your list of numbers. Enter 0 when finished");
        int number_entry = 10;
        List<int> number_list = new List<int>();
        while (number_entry != 0)
        {
            Console.WriteLine("Enter your number:");
            string number_input = Console.ReadLine();
            number_entry = int.Parse(number_input);
            number_list.Add(number_entry);
        }
        
    }
}
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
        int list_sum = 0;
        foreach (int number in number_list)
        {
            list_sum += number;
        }
        Console.WriteLine($"Your sum is {list_sum}");
    }
}
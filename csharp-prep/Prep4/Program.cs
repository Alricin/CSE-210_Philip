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
        int list_max = 0;
        foreach (int number in number_list)
        {
            list_sum += number;
            if (list_max < number)
            {
                list_max = number;
            }
        }
        Console.WriteLine($"Your sum is {list_sum}");
        int entry_number = number_list.Count;
        int list_average = list_sum/entry_number;
        Console.WriteLine($"Your average is {list_average}");
        Console.WriteLine($"Your highest number is {list_max}");

    }
}
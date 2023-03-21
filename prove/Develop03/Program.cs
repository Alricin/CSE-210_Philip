using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Prototype 1.0");
        bool WorkOnMemorizing = true;        
        Reference Activity = new Reference();
        string ScriptureToMemorize = Activity.ChooseScripture();
        Scripture TextToMemorize = new Scripture(ScriptureToMemorize);
        string WordsForMemorizor = TextToMemorize.GetScriptureText();
        Words Text = new Words(WordsForMemorizor);
        Text.DisplayCurrentText();
        while (WorkOnMemorizing == true)
        {
            Console.Clear();
            Text.HideWords();
            Text.DisplayCurrentText();
            Console.WriteLine("Hit enter to clear more words");
            Console.WriteLine("Type 'quit' to exit");
            string EndingMemorizor = Console.ReadLine();
            bool HiddenScripture = Text.EndWordHiding();
            if (EndingMemorizor == "quit")
            {
                WorkOnMemorizing = false;
            }
            else if (HiddenScripture == true)
            {
                WorkOnMemorizing = false;
            }

        }


        Text.DisplayCurrentText();

    }
}
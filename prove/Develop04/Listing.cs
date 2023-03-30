using System;

class Listing : Activity
{
    string prompt;
    List<string> ListPrompts = new List<string>();
    ListPrompts.Add("Who are people that you appreciate?");
    


    public Listing(int Duration): base(Duration);
    {
        
    }
    public void DisplayListPrompt()
    {

    }
}
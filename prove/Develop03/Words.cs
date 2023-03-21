using System;

public class Words
{
    private string _ScriptureText;
    private string[] word;
    private int _ScriptureLength;
    private List<bool> WordVisibility = new List<bool>();

    public Words(string ScriptureText)
    {
        _ScriptureText = ScriptureText;
        SplitTextToWords();
        CreateVisibilityList();
    }

    public void SplitTextToWords()
    {
        string[] word = _ScriptureText.Split(" ");
        _ScriptureLength = word.Length;
    }

    public void CreateVisibilityList()
    {
        for (int i = 0; i < _ScriptureLength; i=i+1)
        {
            WordVisibility.Add(true);
        }
    }
    public void HideWords()
    {
        Random rnd = new Random();
        int WordToHide = rnd.Next(1, _ScriptureLength);
        WordVisibility[WordToHide] = false;
    }

    public bool EndWordHiding()
    {
        bool EndingState = true;
        for (int i=0; i < _ScriptureLength; i=i+1)
        {
            if (WordVisibility[i] == true)
            {
                EndingState = false;
            }
        }
        return EndingState;
    }

    public void DisplayCurrentText()
    {
        for (int i = 0; i < _ScriptureLength; i=i+1)
        {
            if (WordVisibility[i] == true)
            {
                Console.Write(word[i]);
            }
            else if (WordVisibility[i] == false)
            {
                Console.Write("_____");
            }
        }
    }
}
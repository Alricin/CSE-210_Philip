using System;

public class Words
{
    private string _ScriptureText;
    private string _HiddenWord;

    public Words(string ScriptureText)
    {
        _ScriptureText = ScriptureText;
    }

    public void SplitTextToWords()
    {
        string[] word = _ScriptureText.Split(" ");
    }
    

    public void DisplayCurrentText()
    {

    }
}
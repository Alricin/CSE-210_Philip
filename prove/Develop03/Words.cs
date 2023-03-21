using System;

public class Words
{
    private string _ScriptureText;
    private string _HiddenWord;
    private string[] word;
    private int _ScriptureLength;
    private List<bool> WordVisibility = new List<bool>();

    public Words(string ScriptureText)
    {
        _ScriptureText = ScriptureText;
        SplitTextToWords();
    }

    public void SplitTextToWords()
    {
        string[] word = _ScriptureText.Split(" ");
        _ScriptureLength = word.Length;
    }


    public void DisplayCurrentText()
    {

    }
}
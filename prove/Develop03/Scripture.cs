using System;

public class Scripture
{
    private string _reference;

    public Scripture(string ScriptureReference)
    {
        _reference = ScriptureReference;

    }

    public string GetScriptureText()
    {
        if (_reference == "John 3:16")
        {
            string ScriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            return ScriptureText;
        }

        else if (_reference == "Proverbs 3:5-6")
        {
            string ScriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            return ScriptureText;
        }

        else if (_reference == "1 Nephi 3:7")
        {
            string ScriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            return ScriptureText;
        }

        else if (_reference == "D&C 19:18-19")
        {
            string ScriptureText = "Which suffering caused myself, even God, the greatest of all, to tremble because of pain, and to bleed at every pore, and to suffer both body and spirit—and would that I might not drink the bitter cup, and shrink. Nevertheless, glory be to the Father, and I partook and finished my preparations unto the children of men.";
            return ScriptureText;
        }

        else
        {
            string ScriptureText = "Scripture not valid, please try again";
            return ScriptureText;
        }
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        bool MenuActive = true;
        Menu UserMenu = new Menu();
        while (MenuActive == true)
        {
            UserMenu.ChooseJournalAction();
            if (UserMenu._SelectionValue == 1)
            {
                Write TemporaryJournal = new Write();
                string TemporaryJournalEntry = TemporaryJournal.WriteEntry();
            } 
            else if (UserMenu._SelectionValue == 2)
            {
                Read ShownJournalEntry = new Read();
                ShownJournalEntry.DisplayActiveJournal();
            }
            else if (UserMenu._SelectionValue == 3)
            {
                Load PermanentJournal = new Load();
                PermanentJournal.ChooseTextFile();
            }
            else if (UserMenu._SelectionValue == 4)
            {
                Save PromisingJournal = new Save();
                PromisingJournal.SaveEntryInJournal();
            }
            else
            {
                MenuActive = false;
            }
        }
    }
}
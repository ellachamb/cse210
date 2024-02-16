using System;
public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string Verse { get; set; }

    public string EndVerse { get; set; }
    public Reference(string book, string chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public string GetReference2()
    {
        return Book + " " + Chapter + ":" + Verse + "-" + EndVerse;
    }

    public string GetReference1()
    {
        return Book + " " + Chapter + ":" + Verse;
    }

}
using System;

namespace Develop03;

public class Reference
{
   private string Book { get; set; }
    private int Chapter { get; set; }
    private int Verse { get; set; }
    private int EndVerse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = startVerse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return EndVerse > 0 ? $"{Book} {Chapter}:{Verse}-{EndVerse}" : $"{Book} {Chapter}:{Verse}";
    }
}

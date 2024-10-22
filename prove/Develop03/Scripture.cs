using System;

namespace Develop03;

public class Scripture
{

   private Reference Reference { get; set; }
   private List<Wordz> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Wordz>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Wordz(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        for (var i = 0; i < numberToHide; i++)
        {
            var wordIndex = random.Next(0, Words.Count);
            Words[wordIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        var displayText = Reference.GetDisplayText() + "\n";
        foreach (var word in Words)
        {
            displayText += word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden());
    }

}

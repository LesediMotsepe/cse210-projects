using System;

namespace Develop03;

public class Wordz
{
    private string Text { get; set; }
    private bool IsHidden { get; set; }

    public Wordz(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    public bool IsHidden()
    {
        return IsHidden;
    }

    public string GetDisplayText()
    {
        return IsHidden ? "_____ " : Text + " ";
    }


}

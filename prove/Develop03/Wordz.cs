using System;

namespace Develop03;

public class Wordz
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

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

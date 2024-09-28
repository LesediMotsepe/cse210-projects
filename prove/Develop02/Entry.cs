using System;


namespace Develop02;

public class Entry
{
  public string _Date;
  public string _promptText;
  public string _entryText;


  public Entry(string Date, string promptText, string entryText)
  {
    _Date =Date;
    _promptText = promptText;
    _entryText =entryText ;

  }
  public void Display()
    {

        Console.WriteLine($"{_Date}({_promptText}) {_entryText}");
    }
}

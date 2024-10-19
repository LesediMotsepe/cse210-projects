using System;

namespace Learning05;

public class MathsAssignment:Assigment
{
 private string _textbookSection;
 private string _problems;

 
 public MathsAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        
        _textbookSection = textbookSection;
        _problems = problems;
    }
 public string GetHomeworksList()

  {
 
    return $"Section {_textbookSection} Problems {_problems}";
  }
}

using System;

namespace Learning05;

public class Assigment
{
  private string _studentName;
  private string _topic;
  public Assigment(string studentName, string topic)
   {
 
    _studentName=studentName;
    _topic=topic;
  }

  public string GetSummary()
  {
    return $"{_studentName}-{_topic}";
  }
}

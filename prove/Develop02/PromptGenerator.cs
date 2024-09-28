using System;

namespace Develop02;

public class PromptGenerator
{
 public List<string>_prompts = new List<string>();
 public PromptGenerator(List<string>prompts){
    prompts =_prompts;
 }

 public string GetRandomPrompt()
 {
    var random= new Random();
    var randomIndex = random.Next(
      _prompts.Count);
    return
    _prompts[randomIndex];
 }
}
     
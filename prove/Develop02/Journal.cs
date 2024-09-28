using System;
using System.Dynamic;
using System.Text.Json;

namespace Develop02;

public class Journal
{
    
    public List<Entry>_entries = new List<Entry>();

    public PromptGenerator PromptGenerator{get;set;}
    public Journal(List<string>prompts){
        _entries = new List<Entry>();
        PromptGenerator = new PromptGenerator(prompts);
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        Console.WriteLine("Journal Entries");

        for(int i = 0; i<_entries.Count;i++)
        {
            Console.WriteLine($"Entry {i+1}:");
            Console.WriteLine($"Date: {_entries[i]._Date}");
            Console.WriteLine($"Prompt:{_entries[i]._promptText}");
            Console.WriteLine($"Entry:{_entries[i]._entryText}\n");
        }
    }
    
    public void SaveToFile(string file)
    {
        var options=new JsonSerializerOptions {WriteIndented = true};
        var json = JsonSerializer.Serialize(_entries,options);
        File.WriteAllText(file,json);

    }

    public void LoadFromFile(string file)
    {
        if(File.Exists(file))
        {
            var json =File.ReadAllText(file);
            _entries =JsonSerializer.Deserialize<List<Entry>>(json);
        }
        else
        {
         Console.WriteLine("File not found.");
        }
    }
 }



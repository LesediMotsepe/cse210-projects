using system;

public class Resume(){

public string _name;
List<job> _jobs = new List<job>(); 
_jobs.Add('Web developer");
_jobs.Add("Director");
_jobs.Add("Receptionist");

public void Display()
{
    Console.WriteLine($"Name:{name}\nJobs:{_jobs} ");
}
}
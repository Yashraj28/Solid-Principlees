namespace Single_Responsibility_Principle.SRP;
// This brakes the SRP, one class is doing more that one things.
//To overcome this there is SRP
public class BadExampleSrp
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public void Run()
    {
        Console.WriteLine($"Hello i am Running {Name} : {Email}");
    }
    
    public void Walk()
    {
        Console.WriteLine($"Hello i am Walking {Name} : {Email}");
    }

    public void Jogging()
    {
        Console.WriteLine($"Hello i am Jogging {Name} : {Email}");
    }
}
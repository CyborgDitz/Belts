namespace Kata_10;

public class Merchant : NPC
{
    private List<string> _inventory;
    public Merchant(
        
        string dialogue,
        string name) : base(name, dialogue)
    {
        _inventory = new List<string>();
        _inventory.Add($"Sword"); 
        _inventory.Add($"Staff");
        Dialogue = dialogue;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says {Dialogue}!");
        Thread.Sleep(2000);
    }
    public void Trade()
    {
        foreach (string line in _inventory)
        {
            Console.WriteLine(line);
        }
    }
    }

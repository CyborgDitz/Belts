namespace Kata_9;

public class Merchant : NPC
{
    // private string _name;
    private List<string> _inventory;

    public Merchant(
        List<string> inventory,
        List<string> dialogue,
        string name, 
        int health ) : base(dialogue,  name, health)
    {
        // Name = name;
        _inventory = inventory;
    }

    public void Trade()
    {
        Console.WriteLine($"{Name} inventory");
    }
}
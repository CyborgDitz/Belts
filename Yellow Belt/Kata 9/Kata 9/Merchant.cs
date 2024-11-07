namespace Kata_9;

public class Merchant : Entity
{
    // private string _name;
    private List<string> _inventory;

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        _inventory = inventory;
    }

    public void Trade()
    {
        Console.WriteLine($"{Name} inventory");
    }
}
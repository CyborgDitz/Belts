namespace Kata_9;

public class Player : Entity
{
    // private string _name;
    // private int _health;
    private int _level;

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        _level = level;
    }

    public void Attack(int damage, string target)
    {
        Console.WriteLine($"{Name} attacks {target} and deals {damage}");
    }
}
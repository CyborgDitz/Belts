namespace Kata_9;

public class Player : Entity
{
    // private string _name;
    // private int _health;
    private int _level;
    private int _damage;
    static readonly string PlayerName = "Player";
    static readonly int playerHealth = 5155;
    public Player(string name, int health, int level, int damage) : base (name, health)
    {
        _level = level;
        _damage = damage;
    }

    public int Attack( Enemy target)
    {
        Console.WriteLine($"{PlayerName} attacks {target.Name} and deals {_damage}");
        return _damage;
    }
}
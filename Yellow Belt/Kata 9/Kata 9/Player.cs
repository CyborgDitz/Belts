namespace Kata_9;

public class Player : Entity
{
    // private string _name;
    // private int _health;
    private int _level;
    static readonly string PlayerName = "Player";
    static readonly int playerHealth = 5155;
    public Player(string name, int health, int level) : base (name, health)
    {
        _level = level;
    }

    public void Attack(int damage, string target)
    {
        Console.WriteLine($"{PlayerName} attacks {target} and deals {damage}");
    }
}
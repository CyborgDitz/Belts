namespace Kata_Yellow_Exam;

public abstract class Entity : IAttack, ITakeDamage
{
    public static Random random = new Random();
    protected string _name { get; set; }
    protected internal int _health {get; set;}
    internal int Damage {get; set;}

    protected Entity(string? name, int health, int damage) 
    {
        _name = name;
        _health = health;
        Damage = damage;
    }

    public void Attack(ITakeDamage target)
    {
        Console.WriteLine($"{_name} attacks {target} for {Damage} damage.");
        target.TakeDamage(Damage);
        Thread.Sleep(1500);
    } 
    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage!");
        Console.WriteLine($"{_name} now has {_health} health left.");
        Thread.Sleep(1500);
    }
    public bool IsAlive()
    {
        return _health > 0;
    }
}

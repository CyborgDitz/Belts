namespace Kata_9;

public class Enemy : Entity
{
    // private int _health;
    private string _type;
    private int _damage;

    public Enemy(string type,string name, int health, int damage) : base(name, health)
    {
        _type = type;
        _damage = damage;
    }

    public void TakeDamage()
    {
        Health -= _damage;
        if (!IsAlive())
        {
            Console.WriteLine($"The {_type} dies");
        }
        Console.WriteLine($"The {_type} takes {_damage} damage and it's health is now {Health}");
    }
}
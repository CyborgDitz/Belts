namespace Kata_9;

public class Enemy : Entity
{
    // private int _health;
    private string _type;
    private int _damage;

    public Enemy(string type, int health, int damage)
    {
        Health = health;
        _type = type;
        _damage = damage;
    }

    public void TakeDamage()
    {
        Health -= _damage;
        if (!IsAlive())
        {
            Console.WriteLine($"The {Name} dies");
        }
        Console.WriteLine($"The {_type} takes {_damage} damage and it's health is now {Health}");
    }
}
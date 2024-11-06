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
        Console.WriteLine($"The {_type} takes {_damage} damage");
    }
}
namespace DefaultNamespace;

public class Enemy
{
    private string _name { get; }
    private int _health;
    private int _damage;

    public Enemy(string name, int health, int damage)
    {
        _name = name;
        _health = health;
        _damage = damage;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"The {_name} takese {damage} damage");
        if (_health <= 0)
        {
            Console.WriteLine("The OrcBjork dies");
        }
    }
    public void WriteSheet()
    {
        Console.WriteLine($"Enemy Name: {_name}\nHealth: {_health}\nDamage: {_damage}");
    }
}
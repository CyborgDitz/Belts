namespace DefaultNamespace;

public class Enemy
{
    public string Name { get; private set; }
    public int Health {get; private set;}
    private int _damage;

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        _damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"The {Name} takes {damage} damage");
        if (Health <= 0)
        {
            Console.WriteLine($"The {Name} dies");
        }
    }
    public void EnemySheet()
    {
        Console.WriteLine($"Enemy Name: {Name}\nHealth: {Health}\nDamage: {_damage}");
    }
}
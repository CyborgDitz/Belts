namespace DefaultNamespace;

public class Enemy
{
    private int _damage;
    public string Name { get; private set; }
    public int Health {get; private set;}
    public int ExpGiven {get; private set;}

    public Enemy(string name, int health, int damage, int expGiven)
    {
        Name = name;
        Health = health;
        _damage = damage;
        ExpGiven = expGiven;
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
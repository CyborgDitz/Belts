namespace Kata_8;

public class Enemy
{
    public readonly int Damage;
    public string Name { get; private set; }
    public int Health {get; private set;}
    public int ExpGiven {get; private set;}

    public Enemy(string name, int health, int damage, int expGiven)
    {
        Name = name;
        Health = health;
        Damage = damage;
        ExpGiven = expGiven;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (!IsAlive())
        {
            Console.WriteLine($"The {Name} dies");
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
    public void EnemySheet()
    {
        Console.WriteLine($"Enemy Name: {Name}\nHealth: {Health}\nDamage: {Damage}");
        
    }
}
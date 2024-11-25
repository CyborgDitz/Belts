namespace DefaultNamespace;

public class Enemy
{

    public string Name { get; private set; }
    public int Health {get; private set;}
    public int ExpGiven {get; private set;}

    public Enemy(string name, int health, int expGiven)
    {
        Name = name;
        Health = health;
        ExpGiven = expGiven;
    }

    public void TakeDamage(int damage)
    {
        if (Health > 0)
        {
            Health -= damage;
        }
      
        Console.WriteLine($"The {Name} takes {damage} damage");
        if (Health <= 0)
        {
            Console.WriteLine($"The {Name} dies");
        }
    }
    public void EnemySheet()
    {
        Console.WriteLine($"Enemy Name: {Name}\nHealth: {Health}");
    }
}
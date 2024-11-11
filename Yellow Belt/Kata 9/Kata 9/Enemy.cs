namespace Kata_9;

public class Enemy : Entity
{
    // private int _health;
    public string Type { get; private set; }
    public int Damage {get; private set;}

    public Enemy(string type,string name, int health, int damage) : base(name, health)
    {
        Type = type;
        Damage = damage;
    }

    public void TakeDamage()
    {
        Health -= Damage;
        if (!IsAlive())
        {
            Console.WriteLine($"The {Type} dies");
        }
        Console.WriteLine($"The {Type} takes {Damage} damage and it's health is now {Health}");
    }
    
}
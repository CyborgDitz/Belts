namespace Kata_Yellow_Exam;

public abstract class Entity : IAttack, ITakeDamage, IAmAlive
{
    public string? Name { get; set; }
    public int Health {get; set;}
    public int Damage {get; private set;}

    protected Entity(string? name, int health, int damage) 
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(Entity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
        target.TakeDamage(Damage);
        Thread.Sleep(1500);
    } 
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!" +
                          $"Current health: {Health}");
        Thread.Sleep(1500);
    }
    public bool AmAlive()
    {
        return Health > 0;
    }
}

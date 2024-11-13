namespace Kata_Yellow_Exam;

public abstract class Entity : IAttack, ITakeDamage, IAmAlive
{
    protected string? Name { get; set; }
    protected int Health {get; set;}
    protected int Damage {get; set;}

    protected Entity(string? name, int health, int damage) 
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(string name, string target, int damage)
    {
        Console.WriteLine($"{Name} attacked {target} for {damage}");
        Thread.Sleep(3000);
    } 
    public void TakeDamage(string name, int damageTaken)
    {
        Health -= damageTaken;
        Console.WriteLine($"{Name} takes {damageTaken} damage!" +
                          $"Current health: {Health}");
        Thread.Sleep(3000);
    }
    public bool AmAlive()
    {
        return Health > 0;
    }
}

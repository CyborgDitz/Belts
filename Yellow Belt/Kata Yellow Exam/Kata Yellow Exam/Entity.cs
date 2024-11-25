namespace Kata_Yellow_Exam;

public abstract class Entity : IAttack, ITakeDamage
{
    protected static int DamageRoll= new Random();
    protected string? Name { get; set; }
    protected internal int Health {get; set;}

    protected Entity(string? name, int health, Random damageRoll)
    {
        Name = name;
        Health = health;
        DamageRoll = damageRoll;
    }

    public void Attack(ITakeDamage target)
    {
        Console.WriteLine($"{Name} attacks {target.TargetName} for {DamageRoll} damage.");
        target.TakeDamage(DamageRoll);
        Thread.Sleep(500);
    } 
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
        Console.WriteLine($"{Name} now has {Health} health left.");
        Thread.Sleep(500);
    }

    public string? TargetName { get; set; }

    public bool IsAlive()
    {
        return Health > 0;
    }
}

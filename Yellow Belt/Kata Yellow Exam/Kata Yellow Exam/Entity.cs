namespace Kata_Yellow_Exam;

public abstract class Entity : IAttack, ITakeDamage
{
    protected static Random random = new Random();
    public string? TargetName { get; set; }
    protected string? Name { get; set; }
    protected internal int Health {get; set;}
    internal int DamageRoll { get; set; }

    protected Entity(string? name, int health, int minDmg, int maxDmg)
    {
        Name = name;
        Health = health;
        DamageRoll = random.Next(minDmg, maxDmg);
    }
    public void Attack(ITakeDamage? target)
    {
        if (target == null) return;
        
        Console.WriteLine($"{Name} attacks {target.TargetName} for {DamageRoll} damage.");
        target.TakeDamage(DamageRoll);
        Thread.Sleep(500);
    } 
    public void TakeDamage(int damageTaken)
    {
        if (damageTaken < 0) return;
        Health -= damageTaken;
        Console.WriteLine($"{Name} takes {damageTaken} damage!");
        Console.WriteLine($"{Name} now has {Health} health left.");
        Thread.Sleep(500);
    }

    protected virtual int CalculateDamage()
    {
        int damageRoll = random.Next(10, 20);
        return damageRoll;
    }
    public bool IsAlive()
    {
        return Health > 0;
    }
    
}

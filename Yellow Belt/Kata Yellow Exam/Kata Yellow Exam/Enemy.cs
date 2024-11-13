namespace Kata_Yellow_Exam;

public class Enemy : Entity
{
    public string Type { get; private set; }
    // public int Health { get; private set; }
    // public int Damage { get; private set; }

    public Enemy(string? name, int health, int damage, string type ) : base(name, health, damage)
    {
        Type = type;
        // Health = health;
        // Damage = damage;
    }

    // public void TakeDamage(string name, int damageTaken)
    // {
    //     string type = name;
    //     Health -= damageTaken;
    //     Console.WriteLine($"{type} takes {damageTaken} damage!" +
    //                       $"\n Health: {Health}");
    //     Thread.Sleep(3000);
    // }
// DRY
    public bool IsAlive()
    {
        return Health > 0;
    }
   
}
namespace Kata_Yellow_Exam;

public class Enemy
{
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void EnemyTakeDamage(string type, int damageTaken)
    {
        Health -= damageTaken;
        Console.WriteLine($"{type} takes {damageTaken} damage!");
    }
// DRY
    public bool IsAlive()
    {
        return Health > 0;
    }
}
namespace Kata_Yellow_Exam;

public class Player
{
   public string? Name { get; private set; }
   public int Health {get; private set;}
   public int Level { get; private set; }
   public int Experience { get; private set; }

    public Player(string? name, int health, int level, int experience)
    {
        Name = name;
        Health = health;
        Level = level;
        Experience = experience;
    }

    public void Attack(string target, int atkDamage)
    {
        Console.WriteLine($"{Name} attacked {target} for {atkDamage}");
    }
//DRY
    public void TakeDamage(int damageTaken)
    {
        Health -= damageTaken;
        Console.WriteLine($"{Name} takes {damageTaken} damage!");
    }

    public void GainExperience(int expGain)
    {
        Experience += expGain;
        if (Experience < 100) return;
        Level++;
        Experience -= 100;
    }
// DRY
    public bool IsAlive()
    {
        return Health > 0;
    }
}
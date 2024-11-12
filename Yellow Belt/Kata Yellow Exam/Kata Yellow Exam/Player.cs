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

    public void Attack(string target, int damage)
    {
        Console.WriteLine($"{Name} attacked {target} for {damage}");
        Thread.Sleep(3000);
    }
//DRY
    public void TakeDamage(int damageTaken)
    {
        Health -= damageTaken;
        Console.WriteLine($"{Name} takes {damageTaken} damage!" +
                          $"\nCurrent health: {Health}");
        Thread.Sleep(3000);
    }

    public void PlayerHeal(int healed, int maxHealth)
    {
        Health += healed;
        if (Health > maxHealth)
        {
            Health = maxHealth;
        }
        Console.WriteLine($"{Name} heals {healed} health! Current health: {Health}");
        Thread.Sleep(3000);
    }
    public void GainExperience(int expGain)
    {
        Experience += expGain;
        if (Experience < 100) return;
        Level++;
        Experience -= 100;
    }
// DRY
    public bool AmAlive()
    {
        return Health > 0;
    }
}
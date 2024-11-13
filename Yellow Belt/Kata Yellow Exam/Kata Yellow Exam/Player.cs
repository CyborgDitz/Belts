namespace Kata_Yellow_Exam;
public class Player : Entity
{
    private Random random = new Random();
   // public string? Name { get; private set; }
   // public int Health {get; private set;}
   public int Level { get; private set; }
   public int Experience { get; private set; }

    public Player(string? name, int health, int damage, int level, int experience) : base  (name, health, damage)
    {
        // Name = name;
        // Health = health;
        Level = level;
        Experience = experience;
    }
    public void PlayerHeal(int healed, int maxHealth)
    {
        Health += healed;
        if (Health > maxHealth)
        {
            Health = maxHealth;
        }
        Console.WriteLine($"{Name} heals {healed} health! Current health: {Health}");
        Thread.Sleep(1500);
    }
    public void GainExperience(int expGain)
    {
        Experience += expGain;
        int expTreshold = 100;
        Console.WriteLine($"{Name} gains {expGain} experience!");
        if (Experience > expTreshold)
        {
            Level++;
            Experience -= expTreshold;
            Console.WriteLine($"{Name} leveled up to {Level} level!");
        }

        Console.WriteLine($"Now has {Experience} experience.");
    }

    public void PlayerAction(Enemy enemy)
    { 
        Console.WriteLine("Will you attack or heal?");
        string inputAction = Console.ReadLine();
        if (inputAction.ToLower() == "attack")
        {
            Attack(enemy);
        }
        else if (inputAction.ToLower() == "heal")
        {
            int healRandomAmount = random.Next(1, 100);
            PlayerHeal(healRandomAmount, 155);
        }
    }
}
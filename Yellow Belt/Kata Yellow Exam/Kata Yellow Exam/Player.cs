namespace Kata_Yellow_Exam;
public class Player : Entity
{ 
    private readonly int _maxHealth = 155;
   private readonly int _expTreshold = 100;
   public int Level { get; private set; }
   public int Experience { get; private set; }
    public Player(string? name, int health, int damage, int level, int experience) 
        : base  (name, health, damage)
    {
        Level = level;
        Experience = experience;
    }
    public void PlayerHeal(int healed)
    {
      
        Health += healed;
        if (Health > _maxHealth)
        {
            Health = _maxHealth;
        }
        Console.WriteLine($"{Name} heals {healed} health! Current health: {Health}");
        Thread.Sleep(1500);
    }
    
    public void GainExperience(int exp)
    {
        int expGain = random.Next(5, 56);
        Experience += expGain;
        Console.WriteLine($"{Name} gains {expGain} experience!");
        if (Experience > _expTreshold)
        {
            LevelUp();
        }
        
        Console.WriteLine($"Now has {Experience} experience.");
    }

    public void LevelUp()
    {
        Level++;
        Experience -= _expTreshold;
        Console.WriteLine($"{Name} leveled up to {Level} level!");
    }
    public void PlayerAction(ITakeDamage enemy)
    {
        string inputAction = GetPlayerAction();
        switch (inputAction.ToLower())
        {
            case "attack":
                Attack(enemy);
                break;
            case "heal":
            {
                int healRandomAmount = random.Next(1, 100);
                PlayerHeal(healRandomAmount);
                break;
            }
        }
    }
    private string GetPlayerAction()
    {
        Console.WriteLine("Will you attack or heal?");
        return Console.ReadLine()?.ToLower() ?? string.Empty; // Handles null or empty input safely
    }
}
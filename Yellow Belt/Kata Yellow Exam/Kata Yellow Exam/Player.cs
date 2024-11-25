namespace Kata_Yellow_Exam;
public class Player : Entity
{ 
    private readonly int _maxHealth = 155;
    private int _level;
    private int _experience;
    private readonly int _expGain = random.Next(5, 56);
    private static int _expTreshold = 100;
    public int Level
    {
        get { return _level; }
        private set { _level = Math.Max(value, 0); }
    }

    public int Experience
    {
        get { return _experience;}
        set { _experience = Math.Max(value, 0); }
    }

    public Player(string? name, int health, int minDmg, int maxDmg, int level, int experience) 
        : base (name, health, minDmg, maxDmg)
    {
        Level = level;
        Experience = experience;
    }

    private void PlayerHeal(int healAmount)
    {
        Health += healAmount;
        if (Health > _maxHealth)
        {
            Health = _maxHealth;
        }
        Console.WriteLine($"{Name} heals {healAmount} health! Current health: {Health}");
        Thread.Sleep(500);
    }
    
    public void GainExperience()
    {
        Experience += _expGain;
        Console.WriteLine($"{Name} gains {_expGain} experience!");
        if (Experience >= 100)
        {
            Experience -= _expGain;
            LevelUp();
        }
        Console.WriteLine($"Now has {Experience} experience.");
    }
    private void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level} level!");
    }
    public void PlayerAction(ITakeDamage? enemy)
    {
        switch (GetPlayerAction())
        {
            case "attack":
                case "1":
                Attack(enemy);
                break;
            case "heal":
                case "2":
            {
                int healRandomAmount = random.Next(1, 100);
                PlayerHeal(healRandomAmount);
                break;
            }
                default:
            {
                Console.WriteLine($"I couldnt understand your action!");
                break;
            }
        }
    }
    private string GetPlayerAction()
    {
        Console.WriteLine("Will you attack or heal?");
        string inputGetAction= Console.ReadLine()?.ToLower();
        return inputGetAction;
    }
}
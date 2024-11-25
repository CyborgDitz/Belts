namespace Kata_Yellow_Exam;
public class Player : Entity
{ 
    private readonly int _maxHealth = 155;
    private int _level;
    private int _experience;
    private  int _expTreshold = 100;
    private int _expGain = random.Next(5, 56);
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

    public Player(string? name, int health, int damage, int level, int experience) 
        : base  (name, health, damage)
    {
        Level = level;
        Experience = experience;
    }
    public void PlayerHeal(int healAmount)
    {
        _health += healAmount;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        Console.WriteLine($"{_name} heals {healAmount} health! Current health: {_health}");
        Thread.Sleep(1500);
    }
    
    public void GainExperience(int randomExp)
    {
        Experience += _expGain;
        Console.WriteLine($"{_name} gains {_expGain} experience!");
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
        Console.WriteLine($"{_name} leveled up to {Level} level!");
    }
    public void PlayerAction(ITakeDamage enemy)
    {
        switch (GetPlayerAction())
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
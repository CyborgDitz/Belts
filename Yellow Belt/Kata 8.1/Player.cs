namespace Kata_8;
public class Player
{
    private string _name;
    private int _health;
    private int _level;
    private int _experience;
    public readonly int Damage;
    public int Level
    {
        get { return _level; }
         private set
        {
            _level = Math.Max(value, 0);
        }
    }
    public int Experience
    {
        get { return _experience; }
        private set
        {
            _experience = Math.Max(value, 0);
        }
    }
    public Player(string name, int health,int damage, int level, int experience)
    {
        _name = name;
        _health = health;
        Damage = damage;
        Experience = experience;
        Level = level;
        
    }
    public void PlayerSheet()
    {
        Console.WriteLine(
            $"Player Name: {_name}\nHealth: {_health}\nLevel: {_level}\nExperience: {_experience}");
    }
    public void Attack(int damage, string target)
    {
        Console.WriteLine($"{_name} dealt {damage} damage to {target}!");
    }
    public void GainExp(int expGain)
    {
        if (expGain > 0)
        {
            int expTreshold = 100;
            _experience += expGain;
            Console.WriteLine($"{_name} gained {expGain} exp!");
            while (_experience >= expTreshold)
            {
                _experience -= expTreshold;
                LevelUp();
            }
        }
    }
    private void LevelUp()
    {
        Level++;
        Console.WriteLine($"{_name} leveled up to level {_level}!");
        Console.WriteLine($"{_name} has {_experience} experience left");
    }
}
namespace DefaultNamespace;

public class Player
{
    public string _name { get; private set; }
    public int _health { get; private set; }
    public int _level { get; private set; }
    public int _experience { get; private set; }
    public int _damage { get; private set; }

    public Player(string name, int health, int level, int experience, int damage)
    {
        _name = name;
        _health = health;
        _level = level;
        _experience = experience;
        _damage = damage;
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

    public void GainExp(int exp)
    {
        Console.WriteLine($"{_name} gained {exp} exp!");
    }
    
}
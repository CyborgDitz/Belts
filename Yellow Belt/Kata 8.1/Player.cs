namespace Kata_8;

public class Player
{
    private string _name;
    private int _health;
    private int _level;
    private int _experience;

    public Player(string name, int health, int level, int experience)
    {
        _name = name;
        _health = health;
        _level = level;
        _experience = experience;
    }

    public void PlayerSheet()
    {
        Console.WriteLine(
            $"Player Name: {_name}\nHealth: {_health}\nLevel: {_level}\nExperience: {_experience}");
        Thread.Sleep(1000);
    }

    public void Attack(int damage, string target)
    {
        Console.WriteLine($"{_name} dealt {damage} damage to {target}!");
    }

    public void GainExp(int expGain)
    {
        var expToLevel = 300;
        _experience += expGain;
        Console.WriteLine($"{_name} gained {expGain} exp!");
        if (_experience >= expToLevel)
        {
            _experience -= expToLevel;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        _level++;
        Console.WriteLine($"{_name} leveled up to level {_level}!");
        Console.WriteLine($"{_name} has {_experience} experience left");
    }
}
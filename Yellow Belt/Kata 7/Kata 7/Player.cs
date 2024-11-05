namespace DefaultNamespace;

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

    public void WriteSheet()
    {
        Console.WriteLine(
            $"Player Name: {_name} -:- Health: {_health} -:- Level: {_level} -:- Experience: {_experience}");
    }

    public void Attack(int damage)
    {
        Console.WriteLine($"{_name} dealt {damage} damage!");
    }

    public void GainExp(int exp)
    {
        Console.WriteLine($"{_name} gained {exp} exp!");
    }
    
}
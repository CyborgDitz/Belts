namespace Mini_Kata_7;

public class Player
{
    private string _name;
    private int _health;
    private int _level;

    public Player(string name, int health, int level)
    {
        _name = name;
        _health = health;
        _level = level;
    }

    public void WriteSheet()
    {
        Console.WriteLine($"Player Name: {_name} -:- Health: {_health} -:- Level: {_level}");
    }
}
namespace ConsoleApp1;

public class Character
{
    private string _name { get; set; }
    private int _health { get; set; }

    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }
    public delegate void CharacterAction(Character target, int amount);
    public event Action<int> HealthChanged;
   
}
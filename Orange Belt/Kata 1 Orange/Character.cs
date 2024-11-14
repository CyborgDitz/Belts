namespace Kata_1_Orange;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action<Character> PrimaryAction { get; set; }

    public Character( string name, int health )
    {
        Name = name;
        Health = health;
    }
}
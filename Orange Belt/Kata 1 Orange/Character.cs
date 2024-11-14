namespace Kata_1_Orange;

public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; internal set; }
    public Action<Character> PrimaryAction { get; set; }

    protected Character( string name, int health )
    {
        Name = name;
        Health = health;
    }
}
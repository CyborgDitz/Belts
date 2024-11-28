namespace Kata_1_Orange2;
public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public Action<List<Character>> PrimaryAction { get; set; }
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}
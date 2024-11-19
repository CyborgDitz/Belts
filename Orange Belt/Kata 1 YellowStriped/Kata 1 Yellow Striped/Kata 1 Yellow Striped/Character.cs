public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public Action PrimaryAction { get; set; }
    // public List<IAction> Actions { get; set; } = new List<IAction>();
    
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

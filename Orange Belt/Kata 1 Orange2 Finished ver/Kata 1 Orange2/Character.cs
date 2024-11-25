public class Character
{
    private string _name { get; set; }
    private int _health { get; set; }
    public Action PrimaryAction { get; set; }
    // public List<IAction> Actions { get; set; } = new List<IAction>();
    
    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }
}
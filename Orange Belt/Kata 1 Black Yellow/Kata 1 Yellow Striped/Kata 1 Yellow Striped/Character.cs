using Kata_1_Orange;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action PrimaryAction { get; set; }
    public List<IAction> Actions { get; set; } = new List<IAction>();
    
    public void PerformAction(IAction action)
    {
        action.Perform(this);
    }
}
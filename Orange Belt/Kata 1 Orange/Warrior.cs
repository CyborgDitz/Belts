namespace Kata_1_Orange;

public class WarriorClass : Character
{
    public WarriorClass(string name, int health) : base(name, health)
    {
        PrimaryAction = (target) => Console.WriteLine($"{Name} is attacking!");
    }
}
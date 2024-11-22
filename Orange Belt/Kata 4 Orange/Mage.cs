namespace Kata_4_Orange;

public class Mage : Character
{
    public Mage(string name, int strength, int health, int mana) : base(name, strength, health, mana)
    {
    }

    public override void PrimaryAction()
    {
        base.PrimaryAction(UseMagic());
    }

    public override void UseMagic(int manaCost)
    { 
        base.UseMagic(manaCost); 
       Console.WriteLine($"{Name} casts a mighty rollerboulder spell!");
    }
}
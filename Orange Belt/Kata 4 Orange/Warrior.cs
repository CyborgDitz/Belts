namespace Kata_4_Orange;

public class Warrior : Character
{
    private int _damageBonus { get; set; }
    public Warrior(string name, int strength, int health, int mana, int damageBonus) :
        base(name, strength, health, mana)
    {
        _damageBonus = damageBonus;
       
    }

    public override void PerformAction()
    {
        Attack();
    }

    private void Attack()
    {
        
        Console.WriteLine($"{Name} is attacking with ther weapon, and deals !");
    }
    public override int CalculateDamage()
    {
      
        return base.CalculateDamage() + _damageBonus;
    }
}

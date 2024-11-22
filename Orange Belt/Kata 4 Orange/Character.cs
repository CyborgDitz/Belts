namespace Kata_4_Orange;

public abstract class Character
{
    public string Name { get; private set; }
    private int _strength {get; set; }
    private int _health {get; set; }
    private int _mana { get; set; }

    public Character(string name, int strength, int health, int mana)
    {
        Name = name;
        _strength = strength;
        _health = health;
        _mana = mana;
    }

  
    public virtual void PerformAction()
    {
       
    }

    public virtual int CalculateDamage()
    {
        int damage = _strength;
       if (damage < 0)
       {
           return 0;
       }
       return damage;
    }

    public virtual void UseMagic(int manaCost)
    {
       if (0 < manaCost && manaCost <= _mana)
       {
           _mana -= manaCost;
           Console.WriteLine($"{Name} spent {manaCost} out of their {_mana} mana");
       }
       else
       {
           Console.WriteLine($"{Name} has no mana for that!");
       }
    }
}
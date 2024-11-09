namespace Kata_Yellow_Exam;

public class Player
{
   private string _name;
   private int _health;
   private int _level;
   private int _experience;

    public Player(string name, int health, int level, int experience)
    {
        _name = name;
        _health = health;
        _level = level;
        _experience = experience;
    }

    public void Attack(Enemy enemy, int atkDamage)
    {
        Console.WriteLine($"{_name} attacked {enemy} for {atkDamage}");
    }
//DRY
    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage!");
    }

    public void GainExperience(int expGain)
    {
        _experience += expGain;
        if (_experience >= 100)
        {
            _level++;
            _experience -= 100;
        }
    }
// DRY
    public bool IsAlive()
    {
        if (_health > 0)
        {
            return true;
        }
        return false;
    }
}
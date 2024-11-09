namespace Kata_Yellow_Exam;

public class Enemy
{
    private string _type;
    private int _health;
    private int _damage;

    public Enemy(string type, int health, int damage)
    {
        _type = type;
        _health = health;
        _damage = damage;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_type} takes {damage} damage!");
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
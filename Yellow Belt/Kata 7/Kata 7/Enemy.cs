namespace DefaultNamespace;

public class Enemy
{
    private string _name;
    private int _health;
    private int _damage;

    public Enemy(string name, int health, int damage)
    {
        _name = name;
        _health = health;
        _damage = damage;
    }
    
    public void WriteSheet()
    {
        Console.WriteLine($"Enemy Name: {_name}\nHealth: {_health}\nDamage: {_damage}");
    }
}
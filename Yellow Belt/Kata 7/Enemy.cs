namespace DefaultNamespace;

public class Enemy
{
    private string _name;
    private int _health;
    private int _damage;

    public Enemy(string name, int health, int daamge)
    {
        _name = name;
        _health = health;
        _damage = _damage;
    }

    public void TakeDamage(int damage)
    {
        _health = _health - damage;
        Conmsole.Writeline($"{_name} took {damage} damage!")
        if (_health <= 0)
        do {
           Console.Writeline($"The {_name} is dead!")
        }
    }
}

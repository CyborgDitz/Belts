namespace ConsoleApp1;

public class Character : IAttack 
{ 
    private string _name { get; set; } //Encapsulation 
    private int _health { get; set; } //Encapsulation
    private int _damage { get; set; }

    public Character(string name, int health, int damage)//Encapsulation
    {
        _name = name;
        _health = health;
        _damage = damage;
    }
    public event Action<int> HealthChanged; //Meaningful names
    // public delegate void CharacterAction(Character target); //Meaningful names
    
 public void Attack(Character target) //Meaningful names
 {
     target._health -= _damage;
        Console.WriteLine($"{_name} attacked {target._name} for {_damage} damage!");
        target.HealthChanged?.Invoke(target._health); //Separation of Concerns
    }

}
namespace Kata_10;

public class Enemy : Entity
{
    // private int _health;
    public string Type { get; private set; }
    public int Damage {get; private set;}

    public Enemy(string type,string name, int health, int damage) : base(name, health)
    {
        Type = type;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"The {Type} takes {damage} damage and it's health is now {Health}");
        Thread.Sleep(2000);
        if (!IsAlive())
        {
            Console.WriteLine($"The {Type} dies");
        }
    }
  public  List<Enemy> Enemies = [];
    void InstaEnemies(List<Enemy> enemiesList)
    { //basically do this in exam lmao
        Enemy orc = (new Enemy("Orc", "Bjork", 100, 5));
        Enemy goblino =(new Enemy("Goblino", "Babba", 50, 2));
        enemiesList.Add(goblino);
        enemiesList.Add(orc);
        foreach (Enemy enemy in enemiesList) {
            Console.WriteLine($"Enemy Type: {enemy.Type}, Name: {enemy.Name}, Health: {enemy.Health}, Damage: {enemy.Damage}");
        }
    
    }
}
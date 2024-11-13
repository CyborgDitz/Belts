namespace Kata_Yellow_Exam;

public class Enemy : Entity
{  public Enemy? CurrentEnemy { get; set; }
    public string? Type { get; private set; }
    public Enemy(string? name, int health, int damage, string? type ) : base(name, health, damage)
    {
        Type = type;
        
    }
}
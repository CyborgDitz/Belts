namespace Kata_Yellow_Exam;

public class Enemy : Entity
{  
    public string? Type { get; private set; }
    public Enemy(string? name, int health, int damageRoll, string? type) : base(name, health, damageRoll)
    {
        Type = type;
        TargetName = name;
    }
}
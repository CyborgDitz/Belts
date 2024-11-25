namespace Kata_Yellow_Exam;

public class Enemy : Entity
{
    private readonly int _minDmgRoll;
    public string? Type { get; private set; }
    public Enemy(string? name, int health, string? type, int minDmg, int maxDmg) : base(name, health, minDmg, maxDmg)
    {
        Type = type;
        TargetName = name;
    }
}
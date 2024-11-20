namespace Kata_3_YellowStriped;

public class AbilityBase : IAbility //Encapsulatioooon! Meaningful names!
{
    public string Name { get; private set; } //Encapsulatioooon!
    public string Effect { get; private set; } //Encapsulatioooon!
//DRY (Don't Repeat Yourself)
    public AbilityBase(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}
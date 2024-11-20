namespace Kata_3_YellowStriped;

public class AbilityBase : IAbility
{
    public string Name { get; private set; }
    public string Effect { get; private set; }

    public AbilityBase(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}
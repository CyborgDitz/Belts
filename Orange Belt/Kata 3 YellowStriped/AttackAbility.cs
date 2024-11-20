namespace Kata_3_YellowStriped;

public class AttackAbility: IAbility
{
    private string _name { get; set; }
    private string _effect { get; set; }

    public AttackAbility(string name, string effect)
    {
        _name = name;
        _effect = effect;
    }
}
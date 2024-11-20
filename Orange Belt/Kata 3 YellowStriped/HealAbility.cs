namespace Kata_3_YellowStriped;

public class HealAbility: IAbility
{
    private string _name { get; set; }
    private string _effect { get; set; }
    public HealAbility(string name, string effect)
    {
        _name = name;
        _effect = effect;
    }

    public void Ability(string name, string effect)
    {
        throw new NotImplementedException();
    }
}
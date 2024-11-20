namespace Kata_3_YellowStriped;
//Separation of Concerns, this class only does one thing and that is CONTAINMENT
public class AbilityContainer<T>
{
    private readonly List<T> _abilities = new List<T>();

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }
    public IEnumerable<T> GetAbilities()
    {
        return _abilities;
    }
}
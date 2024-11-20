namespace Kata_3_YellowStriped;

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
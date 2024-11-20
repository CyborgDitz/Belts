namespace Kata_3_YellowStriped;

public class AbilityContainer<T>
{
    private List<T> abilities = new List<T>();

    public void AddAbility(T ability)
    {
        abilities.Add(ability);
    }

    public IEnumerable<T> GetAbilities()
    {
        return abilities;
    }
    
}
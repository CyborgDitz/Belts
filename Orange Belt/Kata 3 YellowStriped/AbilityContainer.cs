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
    public void PrintContainer(AbilityContainer<IAbility> abilities)
    {
        foreach (var ability in abilities.GetAbilities())
        {
            Console.WriteLine($"{ability.Name}: {ability.Effect}");
        }
    }
}
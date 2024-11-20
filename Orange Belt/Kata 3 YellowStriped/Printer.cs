namespace Kata_3_YellowStriped;

public class Printer
{ // seperation of concerns into a printer class!
    public void PrintContainer(AbilityContainer<IAbility> abilities)
    {
        foreach (var ability in abilities.GetAbilities())
        {
            Console.WriteLine($"{ability.Name}: {ability.Effect}");
        }
    }
}
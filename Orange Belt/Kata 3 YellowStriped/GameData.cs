namespace Kata_3_YellowStriped;
using Kata_3_YellowStriped;

public class GameData
{
  AttackAbility attackAbility = new("Slap", "deals 1 damage.");
  HealAbility healAbility = new("Heal", "heal 100 hp.");
  var container = new AbilityContainer<IAbility>();
}
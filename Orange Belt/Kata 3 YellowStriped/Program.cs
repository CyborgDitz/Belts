using Kata_3_YellowStriped;

AttackAbility attackAbility = new("Slap", "deals 1 damage.");
HealAbility healAbility = new("Heal", "heal 100 hp.");
var abilityContainer = new AbilityContainer<IAbility>();

abilityContainer.AddAbility(attackAbility);
abilityContainer.AddAbility(healAbility);
abilityContainer.PrintContainer(abilityContainer); //seperation of concerns and OCP


﻿using Kata_3_YellowStriped;

Printer printer = new Printer();
AttackAbility attackAbility = new("Slap", "deals 1 damage.");
HealAbility healAbility = new("Heal", "heal 100 hp.");
var container = new AbilityContainer<IAbility>();

container.AddAbility(attackAbility); //Separation of Concerns
container.AddAbility(healAbility); //
printer.PrintContainer(container); //Seperation of concerns and OCP
//YAGNI, wanted to add features to orange belt level 2 but they were redundant for level 1.
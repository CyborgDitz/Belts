using System;
using System.Collections.Generic;

List<Character> characters = new List<Character> 
{
    new(){
        Name = "Warrior",
        Health = 40, 
        PrimaryAction = () => Console.WriteLine("Warrior attacks with sword!")
    },
    new()
    {
        Name = "Healer",
        Health = 60, 
        PrimaryAction = () => Console.WriteLine("Healer casts healing spell!")
    },
};

       
Action<List<Character>> lowHealthAttackers = chars =>
{
    foreach (var character in chars)
    {
        if (character.Health < 50 && character.Name != "Healer")
        {
            Console.WriteLine($"{character.Name} has low health (Health: {character.Health}), performing action...");
            character.PrimaryAction.Invoke();
            healer.P
        }
        }
    }
};

        
lowHealthAttackers(characters);


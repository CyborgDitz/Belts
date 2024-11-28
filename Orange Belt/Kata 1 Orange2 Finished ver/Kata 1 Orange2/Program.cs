using Kata_1_Orange2;

Character warrior = new Character ("Warrior",55 );
Character healer = new Character("Healer", 45);
healer.PrimaryAction = () => Console.WriteLine($"{healer} performs a powerful healing spell!");
warrior.PrimaryAction = () => Console.WriteLine($"{warrior} is attacking!");

Action<Character> attackFirstAction = character =>
{
    Console.WriteLine($"{character} is acting first due to low health!");
    character.PrimaryAction();
};


List<Character> characters = new List<Character> { warrior, healer };

Action<List<Character>> lowHealthHeal = chars =>
{
    Character lowestHealthCharacter = chars.FirstOrDefault();
    foreach (Character character in chars)
    {
        if (character < lowestHealthCharacter.Health)
        {
            lowestHealthCharacter = character;
        }
    }

    healer.PrimaryAction();
    // return lowestHealthCharacter;
};

// Func<List<Character>, bool> lowHealthAttackers = (characters) =>
// {
//     return characters.Any(charcter => character.Health < 50);
// };
Action<List<Character>> lowHealthAttackers = (characters) =>
{
    foreach (Character character in characters)
    {
        if (character.Health < 50)
        {
            attackFirstAction(character);
        }
    }
    
};

void Stuff()
{
    lowHealthAttackers(characters);
    lowHealthHeal(characters);
}

Stuff();

namespace Kata_1_Orange2;
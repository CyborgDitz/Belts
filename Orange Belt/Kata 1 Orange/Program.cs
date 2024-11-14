using Kata_1_Orange;

Character warrior = new Character ("Warrior",45 );
HealerClass healer = new HealerClass ("Healer",50 );

Action<Character> attackAction = character =>
{
    Console.WriteLine($"{character.Name} is attacking first due to low health!");
};

// healer.PrimaryAction = (target) => Console.WriteLine($"{healer.Name} performs a powerful healing spell!");
warrior.PrimaryAction = (target) => Console.WriteLine($"{warrior.Name} is attacking!");
Action<List<Character>> lowHealthAttackers = chars =>
{
    foreach (var character in chars)
    {
        healer.PrimaryAction(character);
        // if (character.Health < 50)
        // {
        //     Console.WriteLine($"{healer.Name} is healing {character.Name}!");
        //     healer.PrimaryAction(target);
        //     character.Health = 100;
        // }

        if (character.Health < 50)
        {
            attackAction(character);
        }
        character.PrimaryAction(character);
        character.Health -= 50;
    }
};
List<Character> characters = new List<Character> { warrior, healer };
lowHealthAttackers(characters);


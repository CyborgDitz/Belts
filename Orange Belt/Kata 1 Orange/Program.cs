using Kata_1_Orange;

Character warrior = new Character { Name = "Warrior", Health = 45 };
Character healer = new Character { Name = "Healer", Health = 50 };

Action<Character> attackAction = character => 
         Console.WriteLine($"{character.Name} is attacking first due to low health!");
healer.PrimaryAction = () => Console.WriteLine($"{healer.Name} performs a powerful healing spell!");
warrior.PrimaryAction = () => Console.WriteLine($"{warrior.Name} is attacking!");
Action<List<Character>> lowHealthAttackers = chars =>
{
    foreach (var character in chars)
    {
        if (character.Health < 50)
        {
            Console.WriteLine($"{healer.Name} is healing {character.Name}!");
            healer.PrimaryAction();
            character.Health = 100;
        }

        if (character.Health < 50)
        {
            attackAction(character);
        }
        character.PrimaryAction();
        character.Health -= 50;
    }
};
List<Character> characters = new List<Character> { warrior, healer };
lowHealthAttackers(characters);


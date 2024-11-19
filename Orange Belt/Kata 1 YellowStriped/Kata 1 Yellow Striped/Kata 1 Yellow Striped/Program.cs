Character warrior = new Character ("Warrior",45 );
Character healer = new Character("Healer", 55);
healer.PrimaryAction = () => Console.WriteLine($"{healer.Name} performs a powerful healing spell!");

warrior.PrimaryAction = () => Console.WriteLine($"{warrior.Name} is attacking!");

Action<Character> attackAction = character =>
{
    Console.WriteLine($"{character.Name} is attacking first due to low health!");
    character.PrimaryAction();
};


List<Character> characters = new List<Character> { warrior, healer };

Action<List<Character>> lowHealthAttackers = chars =>
{
    chars.ForEach(character =>
    {
        if (character.Health < 50)
        {
            attackAction(character);
        }
    });
};
Action<List<Character>> lowHealthHeal = chars =>
    {
        chars.ForEach(character =>
        {
            if (character.Health < 50)
            {
                Console.WriteLine($"{healer.Name} is healing {character.Name}!");
                healer.PrimaryAction();
            }
        });
    };
lowHealthAttackers(characters);
lowHealthHeal(characters);
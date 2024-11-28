using Kata_1_Orange2;
Character warrior = new Character ("Warrior",45 );
Character healer = new Character("Healer", 51);
healer.PrimaryAction = (target) => Console.WriteLine($"{healer.Name} performs a powerful healing spell!");
warrior.PrimaryAction = (target) => Console.WriteLine($"{warrior.Name} is attacking!");
List<Character> characters = new List<Character> { warrior, healer };


Action<Character> attackFirstAction = character =>
{var charFirst = characters.First();
    Console.WriteLine($"{character.Name} is acting first due to low health! ({character.Health} < 50");
    character.PrimaryAction([charFirst]);
};

Action<List<Character>> lowHealthAttackers = (characters) =>
{
    foreach (Character character in characters)
    {
        if (character.Health < 50)
        {
            attackFirstAction(character);
            break;
        }
    }
};
Action<List<Character>> lowHealthHeal = chars =>
{
    Character? lowestHealthCharacter = chars.FirstOrDefault();
    foreach (Character? character in chars)
    {
        if (lowestHealthCharacter != null && character.Health < lowestHealthCharacter.Health)
        {
            lowestHealthCharacter = character;
        }
        healer.PrimaryAction(chars);
        Console.WriteLine($"{healer.Name} heals the lowest health target, which is {lowestHealthCharacter.Name}." +
                          $" (Current health {character.Health}).!");
        break;
    }
};
void Combat()
{
    lowHealthAttackers(characters);
    lowHealthHeal(characters);
}
Combat();
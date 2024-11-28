using Kata_1_Orange2;
Character warrior = new Character ("Warrior",45 );
Character healer = new Character("Healer", 65);
List<Character> characters = new List<Character> { warrior, healer };
healer.PrimaryAction = (character) => Console.WriteLine($"{healer.Name} performs a powerful healing spell!");
warrior.PrimaryAction = (character) => 
    Console.WriteLine("Warrior is attacking for big damuge!");

Action<List<Character>> lowHealthAttackers = (lowHpChar) =>
{
    foreach (Character character in lowHpChar)
    {
        if (character.Health < 50)
        {
            Console.WriteLine($"{character.Name} is acting first due to low health! ({character.Health} < 50");
            character.PrimaryAction(lowHpChar);
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
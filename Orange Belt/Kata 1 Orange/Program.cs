using Kata_1_Orange;

WarriorClass warrior = new WarriorClass ("Warrior",45 );
HealerClass healer = new HealerClass ("Healer",50 );

Action<Character> attackAction = character =>
{
    character.PrimaryAction(character);
};
Action<List<Character>> lowHealthAttackers = chars =>
{
    foreach (var character in chars)
    {
        if (character.Health < 50)
        {
            attackAction(character);
        }
        else
        {
            character.PrimaryAction(character);
        }
        Console.WriteLine($"{character.Name} current health is now {character.Health}");
    }
  
};
List<Character> characters = [warrior, healer];
lowHealthAttackers(characters);


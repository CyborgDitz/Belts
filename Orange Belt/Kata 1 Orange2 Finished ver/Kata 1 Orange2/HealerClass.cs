namespace Kata_1_Orange2;
public class HealerRole 
{
    Action<List<Character>> lowHealthHeal = chars =>
    {
        Character lowestHealthCharacter = chars.FirstOrDefault();
        foreach (Character character in chars)
        {
            if (character.Health < lowestHealthCharacter.Health)
            {
                lowestHealthCharacter = character;
            }
        }
        PrimaryAction();
        // return lowestHealthCharacter;
    };
}
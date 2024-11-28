namespace Kata_1_Orange;

public class HealerClass : Character
{
    public HealerClass(string name, int health) : base(name, health)
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
        };
    }
}
Character character = new Character();
List<Character> characters = new List<Character>();
characters.Add(character);
characters.Add(character);

public class Character
{
    
    private Action SpecialAttack { get; set; }

     Action<Character> action (List<Character> characters, Func<Character, bool> predicate)
    {
        foreach (var character in characters)
        {
            if (predicate(character))
            {
                SpecialAttack();
            }
        }
    }
}
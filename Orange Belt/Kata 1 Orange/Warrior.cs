namespace Kata_1_Orange;

public class WarriorClass
{
    Action<Character> attackAction = character => 
        Console.WriteLine($"{character.Name} is attacking first due to low health!");
}
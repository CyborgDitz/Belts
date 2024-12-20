namespace Kata_Yellow_Exam;

public class Npc : ISpeak
{
   readonly List<string> _dialogue = new List<string>
    {
        "The Villager BoB says: Hello adventurer!",
        "Goodbye Adventurer!"
    };

    public void Speak()
    {
        foreach (var line in _dialogue)
        {
            Console.WriteLine(line);
            Thread.Sleep(500); 
        }
        string input = Console.ReadLine();
    }
}
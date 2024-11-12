

namespace Kata_10;

public class NPC : ISpeak
{
    protected readonly string Name;
    public string Dialogue {get; protected set;}

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;

    }
    public void Speak()
    {
        Console.WriteLine($"{Name} says {Dialogue}!");
        Thread.Sleep(2000);
    }

    public void DialogueList(List<string> dialogue)
    {
        dialogue.Add($"{Name} says: Welcome to our village!");
        dialogue.Add($"{Name} says: What is your name?");
        foreach (string line in dialogue)
        {
            Console.WriteLine(line);
            Thread.Sleep(2000);
        }
    }
    
}

public interface ISpeak
{
    public void Speak();
}
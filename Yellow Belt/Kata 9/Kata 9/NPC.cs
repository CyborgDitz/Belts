namespace Kata_9;

public class NPC
{
    protected readonly string Name;
    private readonly string _dialogue;

    public NPC(string name, string dialogue)
    {
        Name = name;
        _dialogue = dialogue;

    }
    public void Speak()
    {
        Console.WriteLine($"{Name} says {_dialogue}!");
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
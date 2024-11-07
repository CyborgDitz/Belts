namespace Kata_9;

public class NPC : Entity
{
    // private string _name;
    private string _dialogue;

    public NPC(string name, string dialogue)
    {
        Name = name;
        _dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says {_dialogue}!");
    }
}
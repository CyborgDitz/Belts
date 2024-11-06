namespace Kata_9;

public class NPC : Entity
{
    // private string _name;
    private string _dialogue;

    public NPC(string name, string dialogue)
    {
        _name = name;
        _dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{_name} says {_dialogue}!");
    }
}
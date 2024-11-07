namespace Kata_9;

public class NPC : Entity
{
    private readonly string _name;
    
    public List<string> Dialogue;

    public NPC(List<string> dialogue, string name, int health) : base (name, health)
    {
        _name = name;
        Health = health;
        Dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{_name} says {Dialogue}!");
    }

    public List<NPC> dialogue = [];

    void ListDialogue(List<string> dialogue)
    {
        dialogue.Add($"{_name} says: Welcome to our village!");
        
    }
    
}
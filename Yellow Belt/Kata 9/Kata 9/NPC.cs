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

    public string Speak()
    {
        return $"{_name} says {dialogue[0]}!";
    }

    public List<NPC> dialogue = [];

    void ListDialogue(List<string> dialogue)
    {
        dialogue.Add($"{_name} says: Welcome to our village!");
        dialogue.Add($"{_name} says: What is your name?");
        dialogue.Add($"{_name} says: Can you find my missing son?");
        dialogue.Add($"{_name} says: He went into the forest and did not return.");
        dialogue.Add($"{_name} says: The forest is up north. Please find him.");
        foreach (string line in dialogue)
        {
            Console.WriteLine(line);
            Thread.Sleep(2000); // Wait for 2 seconds before displaying the next line
        }
    }
}
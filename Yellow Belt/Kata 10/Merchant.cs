namespace Kata_10;

public class Merchant : NPC
{
    // private string _name;
    private List<string> _inventory;

    public Merchant(
        
        string dialogue,
        string name) : base(name, dialogue)
    {
        _inventory = new List<string>();
        Dialogue = dialogue;
    }

    public void SpeaK()
    {
        Console.WriteLine($"{Name} says {Dialogue}!");
        Thread.Sleep(2000);
    }
        public void Trade()
        {
            _inventory.Add($"Sword");
            _inventory.Add($"Staff");
            foreach (string line in _inventory)
            {
                Console.WriteLine(line);
                
            }
        }
    }

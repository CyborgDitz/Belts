namespace Kata_9;

public class Merchant : NPC
{
    // private string _name;
    private List<string> _inventory;

    public Merchant(
        
        string dialogue,
        string name) : base(name, dialogue)
    {
        _inventory = new List<string>();
        
    }

 
        public void Trade()
        {
            _inventory.Add($"Sword");
            _inventory.Add($"Staff");
            foreach (string line in _inventory)
            {
                Console.WriteLine(line);
            }
            Thread.Sleep(2000);
        }
    }

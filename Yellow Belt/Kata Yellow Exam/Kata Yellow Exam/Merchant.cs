namespace Kata_Yellow_Exam;

public class Merchant : ISpeak
{
   readonly List<string> _inventory = new List<string>()
   { "Sword", "Shield", "Cat Friend", "Beer",
       "Bear"
   };
   readonly List<string> _dialogue = new List<string>()
   {
       "The merchant says: Greetings traveller, are you in need of goods?",
       "Here are my goods!",
       "What do you want?",
       "Ok bye then!"
   };
    public void Speak()
    {
        Console.WriteLine(_dialogue[0]);
        string? input = Console.ReadLine();
        if (input?.ToLower() == "yes" || input?.ToLower() == "y")
        {
            Trade();
        }
        else
        {
            Console.WriteLine(_dialogue[3]);
            Thread.Sleep(500);
        }
        
    }

    public void Trade()
        {
            Console.WriteLine(_dialogue[1]);
            for (int i = 0; i < _inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_inventory[i]}");
            }

            Thread.Sleep(500);
            Console.WriteLine(_dialogue[2]);
            
            Console.WriteLine("Enter number or 'exit':");
            string? input = Console.ReadLine()?.ToLower();

            if (input == "exit") return;

            if (int.TryParse(input, out int itemNumber) && itemNumber >= 1 && itemNumber <= _inventory.Count)
            {
                Console.WriteLine($"You got a: {_inventory[itemNumber - 1]}");
                _inventory.RemoveAt(itemNumber - 1);
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                Trade();
            }
        }
    }

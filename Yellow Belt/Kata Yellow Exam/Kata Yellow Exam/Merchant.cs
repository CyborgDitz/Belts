namespace Kata_Yellow_Exam;

public class Merchant : ISpeak
{
   readonly List<string> _inventory = new List<string>()
   { "Sword", "Shield", "Cat Friend", "Beer",
       "Bear"
   };
    public void Speak()
    {
        Console.WriteLine("The merchant says: Greetings traveller, are you in need of goods?");
        foreach (string inventory in _inventory)
        {Console.WriteLine(inventory);}
    }

    public void Trade()
    {
      
    }
}
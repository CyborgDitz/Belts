// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my potions store. What is your name traveller?");
string name = Console.ReadLine();
Console.WriteLine($"Greetings {name}... My, you must have journeyed far.");
Console.WriteLine("But how dangerous was your journey on a scale of 1 - 10?");

Dank();

void Dank()
{int dank = int.Parse(Console.ReadLine());
    if (dank < 1 || dank > 10) {
        Console.WriteLine("Oh come now, you can’t be serious? Try again, 1-10 how dangerous was it?");
        Dank();
    }
    else {
        switch (dank) {
            case < 7:
                Console.WriteLine("Oh then you will face much more exciting foes on ahead, traveller, ehehe");
                break;
            case >= 7:
                Console.WriteLine("Oh my... Then you are mighty indeed, traveller.");
                break;
        }
    }
}


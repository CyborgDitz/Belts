using ConsoleApp1;

Character goblino = new Character("Goblino", 55);

goblino.HealthChanged += OnHealthChanged;

void OnHealthChanged(int newHealth)
{
    Console.WriteLine($"[Event] Character's health changed to {newHealth}.");
}

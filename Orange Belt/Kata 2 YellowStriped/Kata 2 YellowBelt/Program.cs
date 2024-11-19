using ConsoleApp1;

Character goblino = new Character("Goblino", 55);

goblino.HealthChanged += OnHealthChanged;

void OnHealthChanged(int newHealth)
{
    Console.WriteLine($"[Event] Character's health changed to {newHealth}.");
}

void Attack(int target, int damage, Action<Character> action)
{
    target.health -= damage;
        
   
    action(target);

    OnHealthChanged(target);
}
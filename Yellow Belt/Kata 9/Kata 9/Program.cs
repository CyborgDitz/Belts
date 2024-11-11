using Kata_9;

List<Enemy> enemies = [];
Player player = new ("Abba", 99, 5);
// Enemy enemy = new ("Orc",100,5);
InstaEnemies(enemies);
Combat();

void InstaEnemies(List<Enemy> enemiesList)
{ //basically do this in exam lmao
    enemies.Add(new Enemy("Orc", "Bjork", 100, 5));
    enemies.Add(new Enemy("Goblino", "Babba", 50, 2));
    foreach (Enemy enemy in enemiesList)
    {
        Console.WriteLine($"Enemy Type: {enemy.Type}, Name: {enemy.Name}, Health: {enemy.Health}, Damage: {enemy.Damage}");
    }
}
void Combat()
{
    player.Attack(50, "Orc");
    
}

void NPCChat()
{
    NPC.
}

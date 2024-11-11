using Kata_9;

List<Enemy> enemies = [];
Player player = new Player("Abba", 99, 5);
Enemy orc = (new Enemy("Orc", "Bjork", 100, 5));
Enemy goblino =(new Enemy("Goblino", "Babba", 50, 2));
Village();


InstaEnemies(enemies);
Combat(player, orc);

void Village()
{
    NPC npc = new NPC("Bob", "Welcome our village traveller!");
    Merchant merchant = new Merchant("What are you buying?", "Merchant");
    npc.Speak();
    merchant.Speak();
    merchant.Trade();
}
void InstaEnemies(List<Enemy> enemiesList)
{ //basically do this in exam lmao
    
    enemiesList.Add(goblino);
    enemiesList.Add(orc);
    foreach (Enemy enemy in enemiesList) {
        Console.WriteLine($"Enemy Type: {enemy.Type}, Name: {enemy.Name}, Health: {enemy.Health}, Damage: {enemy.Damage}");
    }

    
}

void Combat(Player player, Enemy enemy)
{
    player.Attack(50, "Orc");
    enemy.TakeDamage();
}



  


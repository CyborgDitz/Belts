using Kata_9;

List<Enemy> enemies = [];
Player player = new ("Abba", 99, 5);
// Enemy enemy = new ("Orc",100,5);
InstaEnemies(enemies);
Combat();

void Combat()
{
    player.Attack(50, "Orc");
}
void InstaEnemies(List<Enemy> enemiesList)
{
    enemies.Add(new Enemy("Orc", "Bjork", 100, 5));
}

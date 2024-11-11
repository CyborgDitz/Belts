using Kata_Yellow_Exam;

Random random = new Random();

string? inputName = CharacterCreation();
var player = new Player(inputName, 155, 5, 69);

string? CharacterCreation()
{
    Console.WriteLine("What is your name Adventurer?");
    return Console.ReadLine();
}

void CombatRound()
{
    SpawnEnemies();
}
void SpawnEnemies()
{
    int randomMonsters = random.Next(1, 4);
    for (int i = 0; i < randomMonsters; i++)
    {
        Enemy randomEnemy = EnemyList();
        Console.WriteLine($"Generated a new enemy: {randomEnemy.Type}" +
                          $" with {randomEnemy.Health} health" +
                          $" and {randomEnemy.Damage} damage.");
    }

}

Enemy EnemyList()
{
    var enemyTypes = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };
    int randomList = random.Next(enemyTypes.Count);
    string randomType = enemyTypes[randomList];
    
    int randomDmg = random.Next(1, 10);
    int randomHealth = random.Next(5, 31);
    
    return new Enemy(randomType, randomDmg, randomHealth);
    
}
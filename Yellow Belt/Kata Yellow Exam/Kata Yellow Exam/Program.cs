using Kata_Yellow_Exam;

Random random = new Random();
CharacterCreation();
SpawnEnemies();
void CharacterCreation()
{
    Console.WriteLine("What is your name Adventurer?");
    string? inputName = Console.ReadLine();
    var player = new Player(inputName, 155, 5, 69);
}

void SpawnEnemies()
{
    EnemyList();
    int randomDmg = random.Next(1, 10);
    int randomHealth = random.Next(30, 100);
    
    // var enemy = new Enemy(
}

void EnemyList()
{
    int randomEnemyFromList = random.Next(0, 4);
    var list = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };
}
using Kata_Yellow_Exam;

Random random = new Random();
void CharacterCreation()
{
    Console.WriteLine("What is your name Adventurer?");
    string inputName = Console.ReadLine();
    if (inputName != null)
    {
        var player = new Player(inputName, 155, 5, 69);
    }
    else Console.WriteLine("Sorry what? Your name, what is your name?");
    CharacterCreation();
}

void SpawnEnemies()
{
    EnemyList();
    int randomDmg = random.Next(1, 10);
    int randomHealth = random.Next(30, 100);
    
    var enemy = new Enemy(
}

void EnemyList(List<string> randomType)
{
    int randomEnemyFromList = random.Next(0, 4);
    randomType = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };
}
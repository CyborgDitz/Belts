using Kata_Yellow_Exam;
GameData gameData = new GameData();
Random random = new Random();
string? inputName = gameData.CharacterCreation();
Player player = new Player(inputName, 155, 5, 69);


void CombatRound()
{
    player.Attack();
}

void GameStart()
{
    while (true)
    {
        gameData.RandomEncounter();
        Thread.Sleep(3000);
    }
}


string? CharacterCreation()
{
    Console.WriteLine("What is your name Adventurer?");
    return Console.ReadLine();
}
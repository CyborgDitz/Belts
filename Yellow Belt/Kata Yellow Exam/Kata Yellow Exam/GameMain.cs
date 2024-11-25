using Kata_Yellow_Exam;
GameData gameData = new GameData();
string? playerName = CharacterCreation();
Player player = new Player(playerName, 105, 0, 0);
int randomPlayerdamage = next
GameLoop();
void GameLoop()
{
    while (player.IsAlive())
    {
        gameData.RandomEncounter();
        while (gameData.CurrentEnemy != null && gameData.CurrentEnemy.IsAlive())
        {
            CombatRound(player, gameData.CurrentEnemy);
            if (!gameData.CurrentEnemy.IsAlive())
            {
                EnemyDefeat();
            }
        }
        
        Thread.Sleep(500);
    }
    Console.WriteLine("Game Over. You have been defeated!");
}

string? CharacterCreation()
{
    Console.WriteLine("What is your name Adventurer?");
    return Console.ReadLine();
}
void EnemyDefeat()
{
    Console.WriteLine($"{gameData.CurrentEnemy.Type} has been defeated!");
    gameData.CurrentEnemy = null; 
    player.GainExperience();
}

void CombatRound(Player player, Enemy enemy)
{
    while (player.IsAlive() && enemy.IsAlive())
    { 
        player.PlayerAction(enemy);
        if (enemy.IsAlive())
        {
            enemy.Attack(player);
        }
        else
        {
            Console.WriteLine($"You are a hero!");
        }
    }
}
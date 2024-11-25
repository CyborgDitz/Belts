using Kata_Yellow_Exam;
GameData gameData = new GameData();
void GameStart(GameData gameData1)
{
    Player player = gameData.Player;

    while (player.IsAlive())
    {
        gameData.RandomEncounter();
        while (gameData.CurrentEnemy != null && gameData.CurrentEnemy.IsAlive())
        {
            CombatRound(player, gameData.CurrentEnemy);
            if (!gameData.CurrentEnemy.IsAlive())
            {
                EnemyDefeat(randomExp);
            }
        }
        
        Thread.Sleep(1500);
    }

    Console.WriteLine("Game Over. You have been defeated!");
}

void EnemyDefeat(int i)
{
    Console.WriteLine($"{gameData.CurrentEnemy.Type} has been defeated!");
    gameData.CurrentEnemy = null; 
    player.GainExperience(randomExp);
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
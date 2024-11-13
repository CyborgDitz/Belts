using Kata_Yellow_Exam;
GameData gameData = new GameData();
Random random = new Random();
Enemy enemy = gameData.EnemyList();
string? inputName = gameData.CharacterCreation();
int playerDamageRoll = random.Next(5, 10);
int playerLevel = 69;
Player player = new Player(inputName, 155, playerDamageRoll, playerLevel, 0);


GameStart();

void GameStart()
{
    while (player.AmAlive())
    {
        gameData.RandomEncounter();
        while (gameData.currentEnemy != null && gameData.currentEnemy.AmAlive())
        {
            CombatRound(player, gameData.currentEnemy);
            if (!gameData.currentEnemy.AmAlive())
            {
                Console.WriteLine($"{gameData.currentEnemy.Type} has been defeated!");
                gameData.currentEnemy = null; 
                int expRoll = random.Next(5,56);
                player.GainExperience(expRoll);
            }
            Thread.Sleep(1500); 
        }
    }

    Console.WriteLine("Game Over. You have been defeated!");
}

void CombatRound(Player player, Enemy enemy)
{
    player.PlayerAction(enemy); // Pass the enemy to PlayerAction
     
    if (enemy.AmAlive())
    {
        enemy.Attack(player);
    }
    gameData.CurrentHealth(player, enemy);
}

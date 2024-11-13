using Kata_Yellow_Exam;

GameData gameData = new GameData();
Random random = new Random();


string? inputName = gameData.CharacterCreation();
int playerDamageRoll = random.Next(5, 10);
int playerLevel = 69;
int playerMaxHealth = 155;
int randomExp = random.Next(50, 76);
Player player = new Player(inputName, playerMaxHealth, playerDamageRoll, playerLevel, 0);


GameStart();
void GameStart()
{
    while (player.AmAlive())
    {
        gameData.RandomEncounter();
        
        // Check if an enemy is encountered and is alive
        while (gameData.CurrentEnemy != null && gameData.CurrentEnemy.AmAlive())
        {
            CombatRound(player, gameData.CurrentEnemy);

            // If the enemy is defeated, reward experience
            if (!gameData.CurrentEnemy.AmAlive())
            {
                EnemyDefeat(randomExp);
            }
        }
        
        Thread.Sleep(1500);
    }

    Console.WriteLine("Game Over. You have been defeated!");
}


void EnemyDefeat(int expReward)
{
    Console.WriteLine($"{gameData.CurrentEnemy.Type} has been defeated!");
    gameData.CurrentEnemy = null; 
              
    player.GainExperience(randomExp);
}
void CombatRound(Player player, Enemy enemy)
{
    player.PlayerAction(enemy); 
    if (enemy.AmAlive())
    {
        enemy.Attack(player);
    }
}

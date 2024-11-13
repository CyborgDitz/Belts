using Kata_Yellow_Exam;
GameData gameData = new GameData();
Random random = new Random();
Enemy enemy = gameData.EnemyList();
string? inputName = gameData.CharacterCreation();
Player player = new Player(inputName, 155, 5, 69, 333);
int expRoll = random.Next(5,56);

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


// void PlayerAction(Enemy enemy)
//     {
//         Console.WriteLine("Will you attack or heal?");
//         string inputAction = Console.ReadLine();
//         if (inputAction.ToLower() == "attack")
//         {
//             player.Attack(enemy);
//         }
//         else if (inputAction.ToLower() == "heal")
//         {
//             int healRandomAmount = random.Next(1, 100);
//             player.PlayerHeal(healRandomAmount, 155);
//         }
//     }
namespace Kata_10;
public class Game
{
    readonly GameData gameData = new GameData();
    public void GameLoop()
    {
       Village();
        while (gameData.orc.IsAlive())
        {
            Combat(gameData.player, gameData.orc);
            Thread.Sleep(2000);
        }
        Console.WriteLine("You win!");
    }
    void Village()
    {
        gameData.npc.Speak();
        gameData.merchant.Speak();
        gameData.merchant.Trade();
    }

    void Combat(Player player, Enemy enemy)
    {
        int playerDamage = player.Attack(enemy);
        enemy.TakeDamage(playerDamage);
    }
}
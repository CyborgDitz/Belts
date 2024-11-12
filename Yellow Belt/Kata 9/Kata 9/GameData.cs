namespace Kata_9;

public class GameData
{
    List<Enemy> enemies = [];
    Player player = new Player("Abba", 99, 5, 55);
    NPC npc = new NPC("Bob", "Welcome our village traveller!");
    Merchant merchant = new Merchant("What are you buying?", "Merchant");
    Enemy orc = (new Enemy("Orc", "Bjork", 100, 5));

    public void GameLoop()
    {
        Village();
        while (orc.IsAlive())
        {
            Combat(player, orc);
        }
    }

    void Village()
    {
        npc.Speak();
        merchant.Speak();
        merchant.Trade();
    }



    void Combat(Player player, Enemy enemy)
    {
        int playerDamage = player.Attack(enemy);
        enemy.TakeDamage(playerDamage);
    }

    
}
namespace Kata_Yellow_Exam;

public class GameData
{
    NPC npc1 = new NPC();
    Merchant merch1 = new Merchant();
    Random random = new Random();
    
    public string? CharacterCreation()
    {
        Console.WriteLine("What is your name Adventurer?");
        return Console.ReadLine();
    }

   public void RandomEncounter()
    { 
        int randomEncounter = random.Next(1, 4);
        if (randomEncounter == 1)
        {
            SpawnEnemies(); 
        }
        else if (randomEncounter == 2)
        {
            npc1.Speak();
        }
        else if (randomEncounter == 3)
        {
            merch1.Speak();
            merch1.Trade();
        }

    }
   
    void SpawnEnemies()
    {
        int randomMonsters = random.Next(1, 4);
        for (int i = 0; i < randomMonsters; i++)
        {
            Enemy randomEnemy = EnemyList();
            Console.WriteLine($"Generated a new enemy: {randomEnemy.Type}" +
                              $" with {randomEnemy.Health} health" +
                              $" and {randomEnemy.Damage} damage.");
        }
    }
    public Enemy EnemyList()
    { 
        var enemyTypes = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };
        int randomList = random.Next(enemyTypes.Count);
        string randomType = enemyTypes[randomList];
    
        int randomDmg = random.Next(1, 10);
        int randomHealth = random.Next(5, 31);
    
        return new Enemy(randomType, randomDmg, randomHealth);
    
    }
   
}
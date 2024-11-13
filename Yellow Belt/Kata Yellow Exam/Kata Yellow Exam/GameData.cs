namespace Kata_Yellow_Exam;

public class GameData
{
    Npc npc1 = new Npc();
    public Enemy? currentEnemy; 
    Merchant merch1 = new Merchant();
    Random random = new Random();
    
    public string? CharacterCreation()
    {
        Console.WriteLine("What is your name Adventurer?");
        return Console.ReadLine();
    }

   public void RandomEncounter()
    { 
        int randomEncounter = random.Next(1, 5);
        if (randomEncounter == 1 || randomEncounter == 2)
        {
            Console.WriteLine("An enemy approaches!");
            currentEnemy = EnemyList();
            Console.WriteLine($"A wild {currentEnemy.Type} appears with {currentEnemy.Health} HP and {currentEnemy.Damage} damage!");

        }
        else if (randomEncounter == 3)
        {
            npc1.Speak();
        }
        else if (randomEncounter == 4)
        {
            merch1.Speak();
        }

    }
    public Enemy EnemyList()
    { 
        var enemyTypes = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };
        int randomList = random.Next(enemyTypes.Count);
        string randomType = enemyTypes[randomList];
    
        int randomDmg = random.Next(1, 10);
        int randomHealth = random.Next(5, 31);
        string name = randomType;
    
        return new Enemy(name, randomDmg, randomHealth, randomType);
    
    }
    public void CurrentHealth(Entity player, Entity enemy)
    {
        Console.WriteLine($"{player.Name}'s Health: {player.Health}");
        Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");
    }
   
}
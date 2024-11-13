namespace Kata_Yellow_Exam;

public class GameData
{
    private readonly Npc _npc;
    private readonly Merchant _merchant;
    private readonly Enemy _enemy;
    public Enemy? CurrentEnemy { get; set; }
    readonly List<string> enemyTypes = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };

    readonly Random _random = new Random();
    public GameData()
    { 
        _npc = new Npc();
        _merchant = new Merchant();
    }


     public string? CharacterCreation()
    {
        Console.WriteLine("What is your name Adventurer?");
        return Console.ReadLine();
    }
    

   public void RandomEncounter()
    { 
        int encounterChance = _random.Next(1, 5);
        switch (encounterChance)
        {
            case 1:
            case 2:
            case 3: 
               EnemySpawn();
                break;

            case 4:
                _npc.Speak();
                break;

            case 5:
                _merchant.Speak();
                break;
        }

    }

    public void EnemySpawn()
    {
        Console.WriteLine("An enemy approaches!");
        CurrentEnemy = GenerateRandomEnemy();
        Console.WriteLine($"A wild {CurrentEnemy.Type} appears with {CurrentEnemy.Health} HP and {CurrentEnemy.Damage} damage!");
    }
    private Enemy GenerateRandomEnemy()
    { 
        int randomList = _random.Next(enemyTypes.Count);
        string randomType = enemyTypes[randomList];
    
        int randomDmg = _random.Next(1, 10);
        int randomHealth = _random.Next(5, 31);
        string name = randomType;
    
        return new Enemy(name, randomDmg, randomHealth, randomType);
    
    }
}
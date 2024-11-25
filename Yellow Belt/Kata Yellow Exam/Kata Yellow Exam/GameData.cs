namespace Kata_Yellow_Exam;

public class GameData
{ 
    private Random _random = new Random();
    private readonly Npc _npc = new();
    private readonly Merchant _merchant = new();
    protected internal Enemy? CurrentEnemy { get; set; }
    readonly List<string> _enemyTypes = new List<string> { "Orc", "Goblino", "Warlock", "Carrotman" };

    public void RandomEncounter()
   {
       int encounterChance = _random.Next(1, 11);
       if (encounterChance <= 5)
       {
           EnemySpawn();
       }
       else if (encounterChance <= 8)
       {
           _npc.Speak();
       }
       else if (encounterChance <= 10) {
           _merchant.Speak();}
   }

   private void EnemySpawn()
    {
        Console.WriteLine("An enemy approaches!");
        CurrentEnemy = GenerateRandomEnemy();
        Console.WriteLine($"A wild {CurrentEnemy.Type} appears with {CurrentEnemy.Health} HP and {CurrentEnemy.DamageRoll} damage!");
    }
    private Enemy GenerateRandomEnemy()
    { 
        int randomList = _random.Next(_enemyTypes.Count);
        string randomType = _enemyTypes[randomList];
        int randomHealth = _random.Next(5, 33);
        
        return new Enemy(randomType, randomHealth,randomType, 1,50);
    }
    
}
Random random = new Random();
string namePlayer = "Hero";
int healthPlayer = 155;


string nameEnemy = "Goblin King";
int healthEnemy = 300;


Console.WriteLine("You face the mighty Goblin King in battle. What will you do?");
// game while loop
while (healthPlayer > 0 && healthEnemy > 0) {  
    int atkPwrPlayer = random.Next(100,155);
    int atkPwrEnemy = random.Next(15,34);
    int healPlayer = random.Next(1,99);
        Console.WriteLine("Attack or heal?");
        string input = Console.ReadLine();
        string input2Low = input.ToLower();
        switch (input2Low)
        {
            case "attack": {
                Console.WriteLine($"{namePlayer} is attacking the {nameEnemy}");
                Console.WriteLine($"{nameEnemy} takes {atkPwrPlayer} damage");
                healthEnemy -= atkPwrPlayer;
                break;
            }

            case "heal":
                { 
                    if (healthPlayer == 155)
                    {
                        Console.WriteLine($"You can't heal yourself more!");
                    
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {healPlayer}!");
                        healthPlayer += healPlayer;
                        if (healthPlayer > 155)
                        {
                            healthPlayer = 155;
                        }
                        Console.WriteLine($"The Hero is restored to {healthPlayer} health");
                    }

                    break;
                }
              
                
            }
        if (healthEnemy <= 0) {
            Console.WriteLine("The Goblin King is dead. You have saved the land!");
            break;
        }
        //enemy turn
        Console.WriteLine();
        Console.WriteLine($"{nameEnemy} attacks the {namePlayer}!");
        Console.WriteLine($"{namePlayer} takes {atkPwrEnemy}");
        healthPlayer -= atkPwrEnemy;
        Console.WriteLine($"The Hero has {healthPlayer} health left");

        
        if (healthPlayer <= 0){
            Console.WriteLine("You died");
            break;
        }
        
}

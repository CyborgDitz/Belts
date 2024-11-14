using Kata_1_Orange;


public class HealerClass : Character
{
    // Constructor for HealerClass
    public HealerClass(string name, int health) : base(name, health)
    {
        PrimaryAction = (target) =>
        {
            int maxHealth = 100;
            int healingAmount = maxHealth - health;
            if (target.Health < 50)
            {
                Console.WriteLine($"{Name} is healing {healingAmount}!");
                target.Health = 100;
            }
            else
            {
                Console.WriteLine($"{Name} is healing {healingAmount}!");
                Health = 100;
            }
            
           
        };
    }
}

    
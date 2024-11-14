using Kata_1_Orange;


public class HealerClass : Character
{
    // Constructor for HealerClass
    public HealerClass(string name, int health) : base(name, health)
    {
        PrimaryAction = (target) =>
        {
            int maxHealth = 100;
            int healingAmount = maxHealth - target.Health;
            if (target.Health < 50)
            {
                Console.WriteLine($"{Name} is healing {target.Name} by {healingAmount} points!");
                target.Health = 100;s
            }
            else
            {
                Console.WriteLine($"{Name} healed thesmelf for {healingAmount} points!");
                Health = maxHealth;
            }
        };
    }
}

    
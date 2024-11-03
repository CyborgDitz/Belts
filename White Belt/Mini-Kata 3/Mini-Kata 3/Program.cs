
void DoAttackBeast(){
    Console.WriteLine("Do you want to attack the beast? (Y/N)");
    string input = Console.ReadLine();
    if (input.ToLower() == "y"|| input.ToLower() == "yes")
    {
        Console.WriteLine("Attempting to attack the beast");
        AttackRoll();
    }
    else
    {
        Console.WriteLine("You fail to muster courage in the hour of need... The beast continues its rampage.");
    }
}

DoAttackBeast();

void AttackRoll()
{Random random = new Random();
    int playerLuck = random.Next(1, 11);
    if (playerLuck > 7)
    {
        Console.WriteLine("You hit the beast and slay it!");
    }
    else if (playerLuck == 6)
    {
        Console.WriteLine("You hit the beast, but the beast is too ravenous.");
        DoAttackBeast();
    }
    else
    {
        Console.WriteLine("You fail to hit the beast.");
        DoAttackBeast();
    }
}
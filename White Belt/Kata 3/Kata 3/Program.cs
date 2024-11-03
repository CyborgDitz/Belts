Treasure();
void Treasure() {
    Console.WriteLine("You find a treasure chest on your journey. What will you do");
    Console.WriteLine("1. Open Chest");
    Console.WriteLine("2. Ignore the cest");
    Console.WriteLine("3. Leave the area");
    string input = Console.ReadLine();
    string input2Low = input.ToLower();
    
    Random random = new Random();
    int playerLuck = random.Next(1, 11);
    switch (input2Low)
    {
        case "1":
        case "open":
        {
            if (playerLuck > 7)
            {  Console.WriteLine($"You open the treasure chest and find a diamond gem!");
        
        
            }else if (playerLuck >= 5) {
                Console.WriteLine($"You open the treasure chest and find some gold!");
            }
            else {
                Console.WriteLine($"The chest was trapped!");
            }

            break;
        }
        case "2":
        case "ignore":
        {
            Console.WriteLine("You ignore the chest and continue on your journey");
            break;
        }
        case "3":
        case "leave":
        {
            Console.WriteLine("You leave the chest and go back home for some reason. Weird.");
            break;
        }
    }
}
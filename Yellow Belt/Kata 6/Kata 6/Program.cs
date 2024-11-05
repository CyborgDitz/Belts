string[] enemies = { "Goblin", "Orc", "Dragon", "Slime", "Carrotmon"};
Console.WriteLine("These are the enemies ahead of you, adventurer..");
for (int i = 0; i < enemies.Length; i++)
{
    Console.WriteLine(enemies[i]);
}

List<string> inventory = new List<string>();
inventory.Add("Sword");
inventory.Add("Shield");
inventory.Add("Ashes of a loved one.");
Console.WriteLine("Current inventory list:");
inventory.ForEach(Console.WriteLine);
//add monster parts
inventory.Add("Goblin Ear");
inventory.Add("Orc tusk");
inventory.Add("Dragon claw");
inventory.Add("Slime friend");
inventory.Add("Carrot");
Console.WriteLine("Updated Inventory:");
inventory.ForEach(Console.WriteLine);
//remove ashes
inventory.Remove("Ashes of a loved one.");
inventory.ForEach(Console.WriteLine);
Console.WriteLine("The hero has lost all hope... but ooh wait whats this?");
inventory.Add("Sword+1");
Console.WriteLine("The Hero found a Sword+1 and forgot their sadness.");
Console.WriteLine("Updated Inventory:");
inventory.ForEach(Console.WriteLine);
Console.WriteLine($"Total items in inventory: {inventory.Count}");
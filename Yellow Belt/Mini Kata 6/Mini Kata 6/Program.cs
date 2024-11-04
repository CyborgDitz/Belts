string[] enemies ={"Goblin", "Orc", "Troll", "Money Wizard"};
Console.WriteLine("A choice of enemy in the arena...:");
foreach (string enemy in enemies)
{
    Console.WriteLine(enemy);
}

List<string> inventory = new List<string>();
inventory.Add("Sword");
inventory.Add("Shield");
inventory.Add("Potion");
Console.WriteLine("Player inventory:");
foreach (string item in inventory)
{
    Console.WriteLine(item);
}
inventory.Add("Stick");
Console.WriteLine("New Inventory:");
foreach (string item in inventory)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total items in inventory: {inventory.Count}");
// Console.WriteLine(inventory);
// for (int i = 0; i < inventory.Length; i++)
// {
//     Console.WriteLine(inventory[i]);
// }
// string newItem = "Stick";
// string[] newInventory = new string[inventory.Length + 1];
// for (int i = 0; i < inventory.Length; i++)
// {
//     newInventory[i] = inventory[i];
// }
// newInventory[newInventory.Length-1] = newItem;
//
// Console.WriteLine("New Inventory:");
// for (int i = 0; i < newInventory.Length; i++)
// {
//     Console.WriteLine(newInventory[i]);
// }
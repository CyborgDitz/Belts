string[] enemies ={"Goblin", "Orc", "Troll", "Money Wizard"};
string[] inventory = {"Sword", "Shield", "Potion"};

Console.WriteLine("A choice of enemy in the arena...:");
for (int i = 0; i < enemies.Length; i++)
{
    Console.WriteLine(enemies[i]);
}
Console.WriteLine("Player inventory:");
for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine(inventory[i]);
}
string newItem = "Stick";
string[] newInventory = new string[inventory.Length + 1];
for (int i = 0; i < inventory.Length; i++)
{
    newInventory[i] = inventory[i];
}
newInventory[newInventory.Length-1] = newItem;

Console.WriteLine("New Inventory:");
for (int i = 0; i < newInventory.Length; i++)
{
    Console.WriteLine(newInventory[i]);
}
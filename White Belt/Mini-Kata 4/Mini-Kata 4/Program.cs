Console.WriteLine("Spawning for loop enemies!");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Enemmy #{i + 1} just spawned!");
}
Console.WriteLine("Spawning while loop enemies!");
int enemies = 0;
while (enemies < 5)
{
    Console.WriteLine($"Enemmy #{enemies + 1} just spawned!");
 enemies++;   
}
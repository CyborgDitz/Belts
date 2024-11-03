
for (int i = 0; i < 2; i++)
{Console.WriteLine($"Spawning wave {i+1}!");
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Enemmy #{j + 1} just spawned!");
    }
    Console.WriteLine($"Wave {i+1} complete!");
}
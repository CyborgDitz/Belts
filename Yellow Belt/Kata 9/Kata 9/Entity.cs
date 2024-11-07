namespace Kata_9;

public class Entity
{
    public string Name { get; set; }
    public int Health { get; set; }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
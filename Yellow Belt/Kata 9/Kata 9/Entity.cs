namespace Kata_9;

public class Entity
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    
    public Entity(string name, int health)
    {
        Name = name;
        Health = health;
        
    }

    public bool IsAlive()
    { 
        return Health > 0;
    }
}
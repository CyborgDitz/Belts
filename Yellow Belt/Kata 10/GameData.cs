namespace Kata_10;

public class GameData
{
    public List<Enemy> enemies = []; 
    public Player player = new Player("Abba", 99, 5, 55);
    public  NPC npc = new NPC("Bob", "Welcome our village traveller! ");
    public Merchant merchant = new Merchant("What are you buying?: ", "Merchant");
    public Enemy orc = (new Enemy("Orc", "Bjork", 100, 5));
}
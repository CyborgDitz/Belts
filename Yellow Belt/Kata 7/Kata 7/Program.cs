using DefaultNamespace;

var player = new Player("Karate Kid", 155,5, 500);
player.WriteSheet();

var enemy = new Enemy("OrcBjork", 500, 40);
enemy.WriteSheet();

void CombatRound()
{
    player.Attack(, enemy);
    enemy.TakeDamage(damage);
}
// enemy.TakeDamage();
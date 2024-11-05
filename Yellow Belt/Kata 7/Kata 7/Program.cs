using DefaultNamespace;

var player = new Player("Karate Kid", 155,5, 500);
var enemy = new Enemy("OrcBjork", 200, 40, 303);
player.PlayerSheet();
enemy.EnemySheet();

while (enemy.Health>=0)
{
    CombatRound();
    if (enemy.Health <= 0)
    {
        player.GainExp(enemy.ExpGiven);
        break;
    }
}

void CombatRound()
{
    player.Attack(55, enemy.Name);
    enemy.TakeDamage(55);
}

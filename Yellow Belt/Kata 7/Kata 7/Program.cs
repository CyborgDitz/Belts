using DefaultNamespace;

var player = new Player("Karate Kid", 155,5, 500, 55);
var enemy = new Enemy("OrcBjork", 200, 303);
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
    player.Attack(player._damage, enemy.Name);
    enemy.TakeDamage(player._damage);
}

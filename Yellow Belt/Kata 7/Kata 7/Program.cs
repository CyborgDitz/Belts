using DefaultNamespace;

var player = new Player("Karate Kid", 155,5, 500);
player.PlayerSheet();

var enemy = new Enemy("OrcBjork", 500, 40);
enemy.EnemySheet();

void CombatRound()
{
    player.Attack(55, enemy.Name);
    enemy.TakeDamage(55);
}


while (enemy.Health>=0)
{
    CombatRound();
}

// enemy.TakeDamage();
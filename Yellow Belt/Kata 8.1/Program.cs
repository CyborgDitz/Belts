using Kata_8;

var player = new Player("Karate Kid", 155,55, 5, 53);
var enemy = new Enemy("OrcBjork", 100, 51);
CombatStart();

void CombatStart ()
{
    CharCombatSheet();
    while (enemy.IsAlive())
    {
        CombatRound();
        WaitTime();
        if (!enemy.IsAlive())
        {
            player.GainExp(enemy.ExpGiven);
            break;
        }
    }
}

void CharCombatSheet()
{
    player.PlayerSheet();
    WaitTime();
    enemy.EnemySheet();
}
void CombatRound()
{
    player.Attack(player.Damage, enemy.Name);
    enemy.TakeDamage(player.Damage);
}

void WaitTime()
{
    Thread.Sleep(1000);
}
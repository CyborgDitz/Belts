string enemyName = "Goblin King";
string playerName = "Luke";
int damage;

void AttackEnemy() {
    damage = 63;
    Console.WriteLine($"{playerName} attacked {enemyName} and dealt {damage} damage!");
}

void EnemyAttack()
{
    Console.WriteLine($"{enemyName} retaliated and attacked {playerName}, dealing {damage} damage!");
    damage = 45;
}

void HealPlayer() {
    int healAmount = 50;
    Console.WriteLine($"{playerName} cast heal, and healed themself for {healAmount} health!");
}

    AttackEnemy();
    EnemyAttack();
    HealPlayer();

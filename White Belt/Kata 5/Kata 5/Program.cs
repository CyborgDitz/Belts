CombatRound();

void CombatRound()
{
    AttackEnemy("Orc", 42);
    HealPlayer("Oddball", 55);
}

void AttackEnemy(string enemyName, int damage)
{
    Console.Write($"Player attacks {enemyName} for {damage} damage!");
}

void HealPlayer(string playerName, int healAmount)
{
    Console.Write($"Player heals {playerName} for {healAmount} health!");
}
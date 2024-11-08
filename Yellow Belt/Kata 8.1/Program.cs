﻿using Kata_8;

var player = new Player("Karate Kid", 155,5, 253);
var enemy = new Enemy("OrcBjork", 100, 40, 303);

CombatStart();

void CombatStart ()
{
    CharCombatSheet();
    while (enemy.IsAlive())
    {
        CombatRound();
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
    enemy.EnemySheet();
}
void CombatRound()
{
    player.Attack(55, enemy.Name);
    enemy.TakeDamage(enemy.Damage);
}
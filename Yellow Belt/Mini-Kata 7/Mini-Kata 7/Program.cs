using Mini_Kata_7;
using static Mini_Kata_7.Enemy;
using static Mini_Kata_7.Player;

var player = new Player("Abba",100,54);
player.WriteSheet();

var enemy = new Enemy("Goblin King", 2, 2);
enemy.WriteSheet();
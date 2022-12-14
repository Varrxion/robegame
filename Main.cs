using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            Graphics.DrawTitle();
            Graphics.DrawTitleOptions();

            Player player = new Player(100, 10, "Player");
            Enemy enemy = new Enemy(50, 5, "Dirty Goblin");
            Enemy[] enemies = new Enemy[5];
            enemies[0] = enemy;

            Console.Write("\n\n\n\n\n");
            Graphics.DrawBattle(player, enemies);
            Console.Write("\n\n\n\n\n");

            enemy.TakeDamage(player.Attack());

            Console.WriteLine(player.Attack());

            enemy.PrintStats();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal static class Coordinator
    {
        private static bool playerdead = false;
        private static bool enemiesdead = false;

        public static void Battle(Player player, Enemy[] enemies)
        {
            while(playerdead==false && enemiesdead == false)
            {
                Turn(player, enemies);
                printall(player, enemies); //just for debug
                CheckDead(player, enemies);
            }
            if (playerdead && enemiesdead)
            {
                Console.WriteLine("Battle over because everyone died."); //this should be impossible right now, but self damage attacks might be added
            }
            else if (playerdead)
            {
                Console.WriteLine("Battle over because player died.");
            }
            else
            {
                Console.WriteLine("Battle over because enemies died.");
            }
        }

        public static void Turn(Player player, Enemy[] enemies)
        {
            int target = 0;
            enemies[target].TakeDamage(player.Attack());
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null && enemy.GetHealth() > 0)
                {
                    player.TakeDamage(enemy.Attack());
                }
            }
        }

        private static void CheckDead(Player player, Enemy[] enemies)
        {
            if (player.GetHealth() <= 0)
            {
                playerdead = true;
            }

            enemiesdead = true; //assume enemies are dead until check proves otherwise

            foreach (Enemy enemy in enemies)
            {
                if (enemy != null && enemy.GetHealth() > 0)
                {
                    enemiesdead = false;
                }
            }
        }

        public static void printall(Player player, Enemy[] enemies) //this function will intentionally become deprecated
        {
            player.PrintStats();
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.PrintStats();
                }
            }
        }
    }
}

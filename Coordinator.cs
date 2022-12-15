using System;
using System.Collections.Generic;
using System.Text;

namespace Robe
{
    internal static class Coordinator
    {
        public static bool PlayerDead;
        private static bool EnemiesDead;
        private static int KillCounter; //used to determine difficulty
        private static double DiffCoef;

        static Random rand;

        static Coordinator()
        {
            PlayerDead = false;
            EnemiesDead = false;
            KillCounter = 0;
            DiffCoef = 1.0;
            rand = new Random();
        }

        public static bool Title() //returns false to play, true on quit
        {
            string input = "";
            while (input != "1" && input != "3")
            {
                Graphics.DrawTitle();
                Graphics.DrawTitleOptions();
                input = UserInput.OneTwoThreeSelection();
                Graphics.Wipe();

                if (input == "2")
                {
                    //draw settings when implemented
                }
            }

            if (input == "3")
            {
                return true;
            }
            return false;
        }

        public static void Battle(Player player, List<Enemy> enemies)
        {
            EnemiesDead = false;

            while (PlayerDead==false && EnemiesDead == false)
            {
                Turn(player, enemies);
                //PrintAll(player, enemies); //just for debug
                CheckDead(player, enemies);
            }
            Graphics.Wipe();
            Graphics.DrawBattle(player, enemies);
            if (PlayerDead && EnemiesDead)
            {
                Console.WriteLine("Battle over because everyone died."); //this should be impossible right now, but self damage attacks might be added
            }
            else if (PlayerDead)
            {
                Console.WriteLine("Battle over because player died.");
            }
            else
            {
                Console.WriteLine("Battle over because enemies died.");
            }
        }

        public static void Turn(Player player, List<Enemy> enemies)
        {
            Graphics.Wipe();
            Graphics.DrawBattle(player, enemies);
            Graphics.DrawBattleOptions();

            bool confirmedinput = false;

            string input = "";

            while (confirmedinput == false) //because user must confirm magic selection
            {
                input = UserInput.OneTwoThreeSelection();

                if (input == "1")
                {
                    TurnAttack(player, enemies);
                    confirmedinput = true;
                }

                if (input == "2")
                {

                }

                if (input == "3")
                {

                }
            }
        }

        public static void TurnAttack(Player player, List<Enemy> enemies)
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

        private static void CheckDead(Player player, List<Enemy> enemies)
        {
            if (player.GetHealth() <= 0)
            {
                PlayerDead = true;
            }

            EnemiesDead = true; //assume enemies are dead until check proves otherwise

            foreach (Enemy enemy in enemies)
            {
                if (enemy != null && enemy.GetHealth() > 0)
                {
                    EnemiesDead = false;
                }
            }
            if (EnemiesDead)
            {
                KillCounter++;
            }
        }

        public static void PrintAll(Player player, List<Enemy> enemies) //this function will intentionally become deprecated
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

        public static int GenerateEnemyHealth()
        {
            CalculateDiffCoef();
            return (int)Math.Floor(rand.Next(30, 60) * DiffCoef);
        }
        public static int GenerateEnemyAPower()
        {
            return (int)Math.Floor(rand.Next(5, 20) * DiffCoef);
        }
        public static string GenerateEnemyName()
        {
            int temp = rand.Next(1, 5);
            if (temp == 1)
            {
                return "Goblin";
            }
            else if (temp == 2)
            {
                return "Troll";
            }
            else if (temp == 3)
            {
                return "Evil Wizard";
            }
            else if (temp == 4)
            {
                return "Demon";
            }
            else //should not be possible
            {
                return "MISSINGNO"; 
            }

        }

        private static void CalculateDiffCoef()
        {
            if (KillCounter <= 100) //each kill below 100 adds 5%
            {
                DiffCoef = 1 + KillCounter * 0.05; //this will cap out at DiffCoef of 6
            }
            else //each kill after 100 adds 20%
            {
                DiffCoef = 6 + (KillCounter-100) * 0.20; //this is the death wall.
            }
        }

    }
}

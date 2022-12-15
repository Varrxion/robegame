using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            bool Quit = false;

            Graphics.DrawTitle();
            //Graphics.DrawTitleOptions();

            Player player = new Player(1000, 10, "Player");
            List<Enemy> enemies = new List<Enemy>();
            enemies.Capacity = 5;

            Enemy enemy;

            Console.WriteLine("Press Enter to battle");
            Console.ReadLine();
            Graphics.Wipe();

            string quit = "";
            while (Quit == false)
            {
                enemy = new Enemy(Coordinator.GenerateEnemyHealth(), Coordinator.GenerateEnemyAPower(), Coordinator.GenerateEnemyName());
           
                enemies.Clear(); // One enemy always for now
                enemies.Add(enemy);

                Graphics.DrawBattle(player, enemies);
                Coordinator.Battle(player, enemies);

                Console.WriteLine("Press Enter to Continue to next battle");
                quit=Console.ReadLine();
                Graphics.Wipe();
                if (quit == "quit" || quit=="Quit")
                {
                    Quit = true;
                }
            }

        }
    }
}
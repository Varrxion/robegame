using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            MakeRelics.MakeRelicsFile();
            bool Quit = false;

            Player player = new Player(100, 10, "Player");
            List<Enemy> enemies = new List<Enemy>();
            enemies.Capacity = 5;
            Enemy enemy;

            Quit = Coordinator.Title();

            string quit = "";
            while (Quit == false && Coordinator.PlayerDead == false)
            {
                enemy = new Enemy(Coordinator.GenerateEnemyHealth(), Coordinator.GenerateEnemyAPower(), Coordinator.GenerateEnemyName());
           
                enemies.Clear(); // One enemy always for now
                enemies.Add(enemy);

                Coordinator.Battle(player, enemies);

                Console.WriteLine("Press Enter to Continue to next battle");
                quit = Console.ReadLine();
                Graphics.Wipe();
                if (quit == "quit" || quit=="Quit")
                {
                    Quit = true;
                }
            }

        }
    }
}
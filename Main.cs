using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            bool Quit = false;

            Graphics.DrawTitle();
            Graphics.DrawTitleOptions();

            Player player = new Player(1000, 10, "Player");
            List<Enemy> enemies = new List<Enemy>();
            enemies.Capacity = 5;

            Enemy enemy;
            int count = 0;

            while (Quit == false)
            {
                enemy = new Enemy(Coordinator.GenerateEnemyHealth(), Coordinator.GenerateEnemyAPower(), Coordinator.GenerateEnemyName());
           
                enemies.Clear(); // One enemy always for now
                enemies.Add(enemy);

                Coordinator.Battle(player, enemies);

                count++;

                if( count == 5)
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
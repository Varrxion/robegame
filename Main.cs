using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            string input = "";
            bool Quit = false;

            Player player = new Player(1000, 10, "Player");
            List<Enemy> enemies = new List<Enemy>();
            enemies.Capacity = 5;
            Enemy enemy;

            while (input != "1" && input != "3")
            {
                Graphics.DrawTitle();
                Graphics.DrawTitleOptions();
                input = UserInput.TitleSelection();
                Graphics.Wipe();

                if (input == "2")
                {
                    //draw settings when implemented
                }
            }

            if (input == "3")
            {
                Quit = true;
            }

            string quit = "";
            while (Quit == false)
            {
                enemy = new Enemy(Coordinator.GenerateEnemyHealth(), Coordinator.GenerateEnemyAPower(), Coordinator.GenerateEnemyName());
           
                enemies.Clear(); // One enemy always for now
                enemies.Add(enemy);

                Graphics.DrawBattle(player, enemies);
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
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

            string PostBattleInput;
            while (Quit == false && Coordinator.PlayerDead == false)
            {
                enemy = new Enemy(Coordinator.GenerateEnemyHealth(), Coordinator.GenerateEnemyAPower(), Coordinator.GenerateEnemyName());
           
                enemies.Clear(); // One enemy always for now
                enemies.Add(enemy);

                Coordinator.Battle(player, enemies);

                if (!Coordinator.PlayerDead)
                {
                    Console.WriteLine("NEXT BATTLE (1)                    QUIT (z)");
                    PostBattleInput = UserInput.OneOrZSelection();
                    Graphics.Wipe();
                    if (PostBattleInput == "2")
                    {
                        Quit = true;
                    }
                    else if (PostBattleInput == "z")
                    {
                        // Do nothing
                    }
                }
                else
                {
                    PostBattleInput = UserInput.OneOrZSelection();
                    Graphics.Wipe();
                    if (PostBattleInput == "z")
                    {
                        Quit = true;
                    }
                    else if (PostBattleInput == "1")
                    {
                        Coordinator.Reset(player);
                        Graphics.Wipe();
                        Graphics.DrawTitle();
                        Thread.Sleep(2000);
                    }
                }
            }

        }
    }
}
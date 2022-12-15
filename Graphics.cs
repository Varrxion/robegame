using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal static class Graphics
    {
        public static void DrawTitle()
        {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            Console.WriteLine(""" ___    ________________________________________   ___""");
            Console.WriteLine(""" \  \   \______  \   / ___\  |   ___ \|   _____/   \  \""");
            Console.WriteLine("""  \  \   |      _/  /  | | \ |   |_|_/|   ____/     \  \""");
            Console.WriteLine("""   |  )  |    |  \ /   |_|  \|   |_| \|       \      |  )""");
            Console.WriteLine("""  /__/   |____| \_\\______  /|______  /|______ \    /__/""");
            Console.WriteLine(""" /__/        \/           \/        \/        \/   /__/""");
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }

        public static void DrawTitleOptions()
        {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/START (1)/          /SETTINGS (2)/          /QUIT (3)/""");
        }

        public static void DrawBattle(Player player, Enemy[] enemies)
        {
            //if (Enemy.Length > 5){
            //    throw new Exception("Too many enemies, max is 5");
            //}

            //if (Enemy.Length < 1){
            //    throw new Exception("Not enough enemies, min is 1");
            //}

            const int PADDING = 11;
            string[] Temp = new string[5];

            int i = 0;
            foreach (Enemy enemy in enemies)
            {
               
                if (enemy != null)
                {
                    Temp[i] = enemy.GetName().ToString();
                }
                i++;
            }
            i = 0;
            Console.WriteLine($"{Temp[0],PADDING}{Temp[1],PADDING}{Temp[2],PADDING}{Temp[3],PADDING}{Temp[4],PADDING}");
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    Temp[i] = "HP:" + enemy.GetHealth().ToString();
                }
                i++;
            }

            i = 0;
            Console.WriteLine($"{Temp[0],PADDING}{Temp[1],PADDING}{Temp[2],PADDING}{Temp[3],PADDING}{Temp[4],PADDING}");
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    Temp[i] = "AP:" + enemy.GetAPower().ToString();
                }
                i++;
            }


            Console.WriteLine($"{Temp[0],PADDING}{Temp[1],PADDING}{Temp[2],PADDING}{Temp[3],PADDING}{Temp[4],PADDING}");

           


            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            Console.WriteLine("");

            Console.WriteLine($"{player.GetName()}".PadRight(PADDING, ' ').PadRight(54, '/'));
            Console.WriteLine($"HP:{player.GetHealth()}".PadRight(PADDING, ' ').PadRight(54, '/')) ;
            Console.WriteLine($"AP:{player.GetAPower()}".PadRight(PADDING, ' ').PadRight(54, '/'));

            Console.WriteLine("");
            

        }

        public static void DrawBattleOptions()
        {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/ATTACK (1)/          /DEFEND (2)/          /ITEM (3)/""");
        }

        public static void DrawDeathScreen()
        {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            Console.WriteLine("""    _______   _      _       _       _____   _   _ """);
            Console.WriteLine("""    |  ___|  / \    | |     | |     | ____| | \ | |""");
            Console.WriteLine("""    | |_    / _ \   | |     | |     |  _|   |  \| |""");
            Console.WriteLine("""    |  _|  / ___ \  | |___  | |___  | |___  | |\  |""");
            Console.WriteLine("""    |_|   /_/   \_\ |_____| |_____| |_____| |_| \_|""");
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }

        public static void DrawDeathScreenOptions()
        {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/RESTART (1)/                                /QUIT (2)/""");
        }

        //public void DrawEvent()
        //{
        //
        //}

        //public void DrawEventOptions()
        //{
        //
        //}

        //public void DrawSettings()
        //{
        //
        //}

        //public void DrawSettingsOptions()
        //{
        //
        //}

        //public void DrawInventory()
        //{
        //
        //}

        //public void DrawInventoryOptions()
        //{
        //
        //}

    }
}
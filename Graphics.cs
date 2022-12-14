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


            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");

            Console.Write($"{player.GetName()} | ");
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    Console.Write($"{enemy.GetName()} ");
                }
            }
            Console.WriteLine("");

            Console.Write($"HP:{player.GetHealth()} | ");
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    Console.Write($"HP:{enemy.GetHealth()} ");
                }                
            }
            Console.WriteLine("");
            Console.Write($"AP:{player.GetAPower()} | ");
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    Console.Write($"AP:{enemy.GetAPower()} ");
                }                
            }
            Console.WriteLine("");
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////");

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal class Graphics
    {
        public void DrawTitle()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            console.WriteLine(""" ___    ________________________________________   ___""");
            console.WriteLine(""" \  \   \______  \   / ___\  |   ___ \|   _____/   \  \""");
            console.WriteLine("""  \  \   |      _/  /  | | \ |   |_|_/|   ____/     \  \""");
            console.WriteLine("""   |  )  |    |  \ /   |_|  \|   |_| \|       \      |  )""");
            console.WriteLine("""  /__/   |____| \_\\______  /|______  /|______ \    /__/""");
            console.WriteLine(""" /__/        \/           \/        \/        \/   /__/""");
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }

        public void DrawTitleOptions()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/START (1)/          /SETTINGS (2)/          /QUIT (3)/""");
        }

        public void DrawBattle(Entity player, Entity[] Enemy)
        {
            if (Enemy.Length > 5){
                throw new Exception("Too many enemies, max is 5");
            }
            String[] EnemyArray = ("", "", "", "", "");
            
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (Enemy[i] == null)
                {
                    
                }
            }
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            console.WriteLine($"");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            console.WriteLine($"");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine("");
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }
    }
}
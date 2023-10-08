using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal static class UserInput
    {
        public static string OneTwoThreeSelection()
        {
            bool ValidInput = false;
            string UserInput = "";
            while (ValidInput == false)
            {
                UserInput = Console.ReadLine();
                if(UserInput=="1" || UserInput=="2" || UserInput == "3")
                {
                    ValidInput = true;
                }
                else
                {
                    Graphics.ClearLine();
                }
            }
            return UserInput;
        }

        public static string OneOrZSelection()
        {
            bool ValidInput = false;
            string UserInput = "";
            while (ValidInput == false)
            {
                UserInput = Console.ReadLine();
                if (UserInput == "1" || UserInput == "z")
                {
                    ValidInput = true;
                }
                else
                {
                    Graphics.ClearLine();
                }
            }
            return UserInput;

        }
    }
}

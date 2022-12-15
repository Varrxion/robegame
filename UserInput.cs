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
            bool validinput = false;
            string userinput = "";
            while (validinput == false)
            {
                userinput = Console.ReadLine();
                if(userinput=="1" || userinput=="2" || userinput == "3")
                {
                    validinput = true;
                }
                else
                {
                    Graphics.ClearLine();
                }
            }
            return userinput;
        }
    }
}

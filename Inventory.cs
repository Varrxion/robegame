using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal static class Inventory
    {
        private static int Gold = 0;
        private static bool[] relics = new bool[2];

        //Gold
        public static int GetGold() { return Gold; }
        public static void SetGold(int gold) { Gold = gold; }
        //Fire Relic
        public static bool GetRelic(int index) { return relics[index]; }
        public static void SetRelic(int index, bool has) { relics[index] = has; }
    }
}

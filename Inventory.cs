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
        private static bool FireRelic = false; //Increases damage dealt by 50%
        private static bool FrostRelic = false; //Decreases damage taken by 50%

        //Gold
        public static int GetGold() { return Gold; }
        public static void SetGold(int gold) { Gold = gold; }
        //Fire Relic
        public static bool GetFireRelic() { return FireRelic; }
        public static void SetFireRelic(bool has) { FireRelic = has; }
        //Frost Relic
        public static bool GetFrostRelic() { return FrostRelic; }
        public static void SetFrostRelic(bool has) { FrostRelic = has; }


    }
}

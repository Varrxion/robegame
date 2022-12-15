using System;
using System.Collections.Generic;
using System.Text;

namespace Robe
{
    internal static class Inventory
    {
        private static int Gold = 0;
        //private static bool[] Relics = new bool[RelicPoolSize];

        // Create a map where the key is the name of the relic and the value is the boolean true or false if the relic is in the inventory
        private static Dictionary<string, bool> RelicPool = new Dictionary<string, bool>();
        
        // New relics should be added in the constructor to Inventory
        // Relics subject to change, needed to add more to test something
        static Inventory()
        {
            RelicPool.Add("FireRelic", false);
            RelicPool.Add("FrostRelic", false);
            RelicPool.Add("WaterRelic", false);
            RelicPool.Add("EarthRelic", false);
            RelicPool.Add("AirRelic", false);
            RelicPool.Add("DeathRelic", false);
            RelicPool.Add("KeyRelic", false);
            RelicPool.Add("LightRelic", false);
            RelicPool.Add("DarkRelic", false);
        }



        //Gold
        public static int GetGold() { return Gold; }
        public static void SetGold(int gold) { Gold = gold; }

        //Relics
        public static bool GetRelic(string relic) { return RelicPool[relic]; }
        public static void SetRelic(string relic, bool has) { RelicPool[relic] = has; }

        public static List<string> GetActiveRelics() {
            int i = 0;
            List<string> CurrentRelics = new List<string>();
            foreach (System.Collections.Generic.KeyValuePair<string, bool> relic in RelicPool)
            {
                if (relic.Value == true)
                {
                 
                    CurrentRelics.Add(relic.Key);
                    i++;
                }
                
            }
            
            return CurrentRelics;
        }
    }
}

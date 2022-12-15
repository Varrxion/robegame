using System;
using System.Collections.Generic;
using System.Text;

namespace Robe
{
    internal static class MakeRelics
    {
        private static Dictionary<string, string> relicDict = new Dictionary<string, string>();
        static MakeRelics()
        {
            relicDict.Add("FireRelic", "Increases damage dealt by 50%");
            relicDict.Add("WaterRelic", "Decreases damage dealt by 50%");
            relicDict.Add("EarthRelic", "Increases healing by 50%");
            relicDict.Add("AirRelic", "Increases speed by 50%");
            relicDict.Add("LightRelic", "Increases resistance to poison by 50%");
            relicDict.Add("DarkRelic", "Increases resistance to curse by 50%");
            relicDict.Add("FrostRelic", "Increases resistance to chill by 50%");
            relicDict.Add("KeyRelic", "Increases luck by 50%");
            relicDict.Add("DeathRelic", "You cannot be killed from full health");
            MakeRelicsFile();
        }
        public static void MakeRelicsFile()
        {
            using (StreamWriter writer = new StreamWriter("relics.txt"))
            {
                // Write the key-value pairs to the file
                foreach (KeyValuePair<string, string> item in relicDict)
                {
                    writer.WriteLine($"{item.Key}:{item.Value}");
                }
            }
        }
    }
}
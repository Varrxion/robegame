using System;

namespace Robe
{
    public class RobeGame
    {
        static void Main()
        {
            Graphics.DrawTitle();
            Graphics.DrawTitleOptions();

            Player player = new Player(100, 9, "Player");
            Enemy enemy = new Enemy(50, 5, "Dirty Goblin");
            Enemy[] enemies = new Enemy[5];
            enemies[0] = enemy;

            // Add all the relics to the inventory for testing
            Inventory.SetRelic("FireRelic", true);
            Inventory.SetRelic("WaterRelic", true);
            Inventory.SetRelic("EarthRelic", true);
            Inventory.SetRelic("AirRelic", true);
            Inventory.SetRelic("LightRelic", true);
            Inventory.SetRelic("DarkRelic", true);
            Graphics.DrawInventory();
            Graphics.DrawInventoryOptions();
            Graphics.Wipe();
            //Graphics.DrawVictoryRewards(5, "FireRelic");

            Coordinator.Battle(player, enemies);
        }
    }
}
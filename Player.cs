using System;
using System.Collections.Generic;
using System.Text;

namespace Robe
{
    internal class Player : Entity
    {
        private int Defense;

        public Player(int health, int apower, string name) : base(health, apower, name)
        {
            Name = "Player";
        }
        public int GetDefense() { return Defense; }
        private void SetDefense(int defense) { Defense = defense; }

        public override int Attack() //redundant function but keep for now
        {
            if (Inventory.GetRelic("FireRelic")) //if player has the fire relic do 1.5x damage rounded down.
            {
                return (int)Math.Floor(GetAPower() * 1.5);
            }
            else
            {
                return GetAPower();
            }
        }

        public override void TakeDamage(int rawdamage)
        {
            int truedamage = rawdamage - Defense;
            if (truedamage < 0)
            {
                truedamage = 0;
            }

            if (Inventory.GetRelic("FrostRelic")) //do damage halfing AFTER defense is applied
            {
                truedamage = (int)Math.Ceiling(truedamage / 2.0); //Damage reduction is ROUNDED UP
            }
            base.TakeDamage(truedamage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private void CalcDamage(int rawdamage)
        {
            int truedamage = rawdamage - Defense;
            if (truedamage < 0)
            {
                truedamage = 0;
            }
            TakeDamage(truedamage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal class Player : Entity
    {
        private int Defense { get; set; }

        public Player(int health, int apower) : base(health, apower)
        {
            Name = "Player";
        }

        public void CalcDamage(int rawdamage)
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

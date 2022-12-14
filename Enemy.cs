using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal class Enemy : Entity
    {
        private int Health { get; set; }
        private int APower { get; set; }

        public Enemy(int health, int apower) : base(health, apower)
        {
        }

        //special modifiers?
    }
}

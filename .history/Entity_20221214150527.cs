using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    public abstract class Entity
    {
        private int Health;
        private int APower;

        public String Name;

        public Entity(int health, int apower)
        {
            Health = health;
            APower = apower;
        }

        public int GetHealth() { return Health; }
        public void SetHealth(int health) { Health = health; }
        public int GetAPower() { return APower; }
        public void SetAPower(int apower) { APower = apower; }
        
        public void SetName(String name) { Name = name; }
        public String getName() { return Name; }

        public virtual int Attack()
        {
            return GetAPower();
        }

        public virtual void Takedamage(int damage)
        {
            Health -= damage;
        }

        public void printstats()
        {
            Console.WriteLine($"My Health is: {Health}");
            Console.WriteLine($"My APower is {APower}");
        }
    }
}
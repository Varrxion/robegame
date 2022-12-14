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

        public string Name;

        public Entity(int health, int apower, string name)
        {
            Health = health;
            APower = apower;
            if (name != null)
            {
                Name = name;
            }
            else
            {
                Name = "SomeName";
            }
        }

        public int GetHealth() { return Health; }
        private void SetHealth(int health) { Health = health; }
        public int GetAPower() { return APower; }
        private void SetAPower(int apower) { APower = apower; }

        private void SetName(String name) { Name = name; }
        public String GetName() { return Name; }

        public virtual int Attack() //redundant function but keep for now
        {
            return GetAPower();
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void PrintStats()
        {
            Console.WriteLine($"My Health is: {Health}");
            Console.WriteLine($"My APower is {APower}");
        }
    }
}
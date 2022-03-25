using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework
{
    public class Creature
    {
        public int Hitpoints { get; set; }
        public string CreatureName { get; set; }

        public void Attack<T>(T enemy)
        {
            //Implement body
        }

        public void RecieveDamage(int damage)
        {
            //Implement body
        }

        public void Loot<T>(T lootableObject)
        {
            //Implement body
        }
    }
}

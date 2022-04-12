using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Model.Creatures;

namespace _2DGameFramework.Interface
{
    public interface ICreature
    {
        public void Attack(Creature enemy);
        public void RecieveDamage(Creature enemy);
        public void Loot(Creature c);
    }
}

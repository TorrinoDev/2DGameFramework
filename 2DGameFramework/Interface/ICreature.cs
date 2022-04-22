using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.Model.World.Objects;

namespace _2DGameFramework.Interface
{
    public interface ICreature
    {
        public void Attack(Creature enemy);
        public void RecieveDamage(Creature enemy);
        public void Loot(Creature enemy);
        public void Loot(WorldObject o);
    }
}

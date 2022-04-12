using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures.Elven;
using _2DGameFramework.Model.Creatures.Human;
using _2DGameFramework.Model.Creatures.Orc;
using _2DGameFramework.Model.Creatures.Race;

namespace _2DGameFramework.Factory
{
    public class EnemyFactory : IFactory
    {
        Elven e = Elven.Instance;
        Human h = Human.Instance;
        Orc o = Orc.Instance;
        public ICreature GetCreature(RaceType typeOfRace)
        {
            switch (typeOfRace)
            {
                case RaceType.ELVEN: return new ElvenEnemy(e);
                case RaceType.HUMAN: return new HumanEnemy(h);
                case RaceType.ORC: return new OrcEnemy(o);
            }

            return null;
        }
    }
}

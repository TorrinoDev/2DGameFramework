using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class PlayerFactory : IFactory
    {
        /// <summary>
        /// An object factory of the Player type
        /// </summary>
        public PlayerFactory()
        {

        }

        /// <summary>
        /// An object factory of the Player type
        /// </summary>
        /// <param name="ts">Give a tracesource to get a TraceEvent each time a factory has been created</param>
        public PlayerFactory(TraceSource ts)
        {
            ts.TraceEvent(TraceEventType.Information, 100, "A Player Factory has been created");
        }
        Elven e = Elven.Instance;
        Human h = Human.Instance;
        Orc o = Orc.Instance;
        /// <summary>
        /// Get an object of the Player type
        /// </summary>
        /// <param name="typeOfRace">Race type of the player</param>
        /// <returns></returns>
        public ICreature GetCreature(RaceType typeOfRace)
        {
            switch (typeOfRace)
            {
                case RaceType.ELVEN: return new ElvenPlayer(e);
                case RaceType.HUMAN: return new HumanPlayer(h);
                case RaceType.ORC: return new OrcPlayer(o);
            }

            return null;
        }
    }
}

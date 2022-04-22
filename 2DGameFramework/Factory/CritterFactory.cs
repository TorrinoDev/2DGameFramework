using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;

namespace _2DGameFramework.Factory
{
    public class CritterFactory : IFactory
    {
        /// <summary>
        /// An object factory of the Critter type
        /// </summary>
        public CritterFactory()
        {

        }

        /// <summary>
        /// An object factory of the Critter type
        /// </summary>
        /// <param name="ts">A tracesource to get a TraceEvent each time a factory has been created</param>
        public CritterFactory(TraceSource ts)
        {
            ts.TraceEvent(TraceEventType.Information, 100, "A Critter Factory has been created");
        }

        /// <summary>
        /// Get an object of the Critter type
        /// </summary>
        /// <param name="typeOfRace">Race type of the critter</param>
        /// <returns></returns>
        public ICreature GetCreature(RaceType typeOfRace)
        {
            return new Critter();
        }
    }
}

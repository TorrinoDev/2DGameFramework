using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.Model.Creatures.Race;
using _2DGameFramework.Tracing;

namespace _2DGameFramework.Factory
{
    public class AbstractFactory
    {
        /// <summary>
        /// Get a Creature factory of a specific type
        /// </summary>
        /// <param name="typeOfFactory">The type of Creature</param>
        /// <returns></returns>
        public static IFactory GetFactory(CreatureType typeOfFactory)
        {
            switch (typeOfFactory)
            {
                case CreatureType.ENEMY: return new EnemyFactory();
                case CreatureType.CRITTER: return new CritterFactory();
                case CreatureType.PLAYER: return new PlayerFactory();
            }
            return null;
        }

        /// <summary>
        /// Get a Creature factory of a specific type with a trace event for each factory created
        /// </summary>
        /// <param name="typeOfFactory">The type of creature</param>
        /// <param name="ts">A tracesource</param>
        /// <returns></returns>
        public static IFactory GetFactory(CreatureType typeOfFactory, TraceSource ts)
        {
            switch (typeOfFactory)
            {
                case CreatureType.ENEMY: return new EnemyFactory(ts);
                case CreatureType.CRITTER: return new CritterFactory(ts);
                case CreatureType.PLAYER: return new PlayerFactory(ts);
            }
            return null;
        }
    }
}

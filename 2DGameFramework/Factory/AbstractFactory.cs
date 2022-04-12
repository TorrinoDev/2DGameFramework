using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.Model.Creatures.Race;

namespace _2DGameFramework.Factory
{
    public class AbstractFactory
    {
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
    }
}

using _2DGameFramework.Factory;
using _2DGameFramework.Model.Creatures.Race;

namespace _2DGameFramework.Interface
{
    public interface IFactory
    {
        ICreature GetCreature(RaceType typeOfRace);
    }
}

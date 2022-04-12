using _2DGameFramework.Factory;

namespace _2DGameFramework.Model.Creatures
{
    public class Critter : Creature
    {

        private CritterType critterType;


        public CritterType CritterType { get; set; }
    }
}

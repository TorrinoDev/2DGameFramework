using _2DGameFramework.Factory;
using _2DGameFramework.Interface;

namespace _2DGameFramework.Model.Creatures
{
    public class Player : Creature
    {
        private string name;

        /// <summary>
        /// Get or Set the name of the Player
        /// </summary>
        public string Name { get => name; set => name = value; }

    }
}

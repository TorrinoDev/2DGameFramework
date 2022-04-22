using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework.Model.Creatures.Human
{
    public class HumanPlayer : Player
    {
        /// <summary>
        /// Create a Human Player Creature
        /// </summary>
        /// <param name="h">Human Singleton that modifies stats to the human race</param>
        public HumanPlayer(Race.Human h)
        {
            Race = h.Race;
            Hitpoints = Convert.ToInt32(Hitpoints * h.HealthModifier);
            AttackDamage = Convert.ToInt32(AttackDamage * h.AttackModifier);
            Defense = Convert.ToInt32(Defense * h.DefenseModifier);
            Evasion = Convert.ToInt32(Evasion * h.EvasionModifier);
        }
    }
}

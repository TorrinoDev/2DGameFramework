using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Factory;
using _2DGameFramework.Model.Creatures.Race;

namespace _2DGameFramework.Model.Creatures.Elven
{
    public class ElvenPlayer : Player
    {
        public ElvenPlayer(Race.Elven e)
        {
            Race = e.Race;
            Hitpoints = Convert.ToInt32(Hitpoints * e.HealthModifier);
            AttackDamage = Convert.ToInt32(AttackDamage * e.AttackModifier);
            Defense = Convert.ToInt32(Defense * e.DefenseModifier);
            Evasion = Convert.ToInt32(Evasion * e.EvasionModifier);
        }
    }
}

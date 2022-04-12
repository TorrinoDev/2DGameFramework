using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework.Model.Creatures.Orc
{
    public class OrcPlayer : Player
    {
        public OrcPlayer(Race.Orc o)
        {
            Race = o.Race;
            Hitpoints = Convert.ToInt32(Hitpoints * o.HealthModifier);
            AttackDamage = Convert.ToInt32(AttackDamage * o.AttackModifier);
            Defense = Convert.ToInt32(Defense * o.DefenseModifier);
            Evasion = Convert.ToInt32(Evasion * o.EvasionModifier);
        }
    }
}

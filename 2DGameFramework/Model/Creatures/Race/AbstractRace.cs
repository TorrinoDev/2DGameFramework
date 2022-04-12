using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Factory;
using _2DGameFramework.Interface;

namespace _2DGameFramework.Model.Creatures.Race
{
    public abstract class AbstractRace : IRace
    {
        public abstract RaceType Race
        {
            get;
        }
        public abstract double HealthModifier
        {
            get;
            set;
        }
        public abstract double AttackModifier
        {
            get;
            set;
        }
        public abstract double DefenseModifier
        {
            get;
            set;
        }
        public abstract double EvasionModifier
        {
            get;
            set;
        }
    }
}

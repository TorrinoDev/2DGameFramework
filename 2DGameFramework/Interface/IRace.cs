using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Factory;

namespace _2DGameFramework.Interface
{
    public interface IRace
    {
        public RaceType Race
        {
            get;
        }
        public double HealthModifier
        {
            get;
            set;
        }
        public double AttackModifier
        {
            get;
            set;
        }
        public double DefenseModifier
        {
            get;
            set;
        }
        public double EvasionModifier
        {
            get;
            set;
        }
    }
}

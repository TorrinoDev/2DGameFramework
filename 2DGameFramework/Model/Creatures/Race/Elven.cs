using _2DGameFramework.Factory;
using _2DGameFramework.Interface;

namespace _2DGameFramework.Model.Creatures.Race
{
    public sealed class Elven : AbstractRace
    {
        private static Elven instance = null;
        private static readonly object padlock = new object();

        private Elven()
        {
        }

        public static Elven Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Elven();
                    }

                    return instance;
                }
            }
        }

        private RaceType race = RaceType.ELVEN;
        private double healthModifier = 0.8;
        private double attackModifier = 1.0;
        private double defenseModifier = 0.8;
        private double evasionModifier = 1.5;

        public override RaceType Race
        {
            get => race;
        }
        public override double HealthModifier
        {
            get => healthModifier;
            set => healthModifier = value;
        }
        public override double AttackModifier { 
            get => attackModifier;
            set => attackModifier = value;
        }
        public override double DefenseModifier { 
            get => defenseModifier;
            set => defenseModifier = value;
        }
        public override double EvasionModifier { 
            get => evasionModifier;
            set => evasionModifier = value;
        }
    }
}

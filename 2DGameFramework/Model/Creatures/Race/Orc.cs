using _2DGameFramework.Factory;

namespace _2DGameFramework.Model.Creatures.Race
{
    public class Orc : AbstractRace
    {
        private static Orc instance = null;
        private static readonly object padlock = new object();

        Orc()
        {
        }

        public static Orc Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Orc();
                    }

                    return instance;
                }
            }
        }

        private RaceType race = RaceType.ORC;
        private double healthModifier = 1.2;
        private double attackModifier = 1.2;
        private double defenseModifier = 1.2;
        private double evasionModifier = 0.6;

        public override RaceType Race
        {
            get => race;
        }
        public override double HealthModifier
        {
            get => healthModifier;
            set => healthModifier = value;
        }

        public override double AttackModifier
        {
            get => attackModifier;
            set => attackModifier = value;
        }

        public override double DefenseModifier
        {
            get => defenseModifier;
            set => defenseModifier = value;
        }

        public override double EvasionModifier
        {
            get => evasionModifier;
            set => evasionModifier = value;
        }
    }
}

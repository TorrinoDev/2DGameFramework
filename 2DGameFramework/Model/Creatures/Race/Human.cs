using _2DGameFramework.Factory;

namespace _2DGameFramework.Model.Creatures.Race
{
    public class Human : AbstractRace
    {
        private static Human instance = null;
        private static readonly object padlock = new object();

        Human()
        {
        }

        public static Human Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Human();
                    }

                    return instance;
                }
            }
        }

        private RaceType race = RaceType.HUMAN;
        private double healthModifier = 1.0;
        private double attackModifier = 1.0;
        private double defenseModifier = 1.0;
        private double evasionModifier = 1.0;

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

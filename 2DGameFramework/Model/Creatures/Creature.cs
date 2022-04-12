using _2DGameFramework.Factory;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures.Race;
using _2DGameFramework.Model.Items;

namespace _2DGameFramework.Model.Creatures
{
    public class Creature : IRace, ICreature
    {
        private RaceType race;
        private int hitpoints = 100;
        private int attackDamage = 10;
        private int defense = 10;
        private int evasion = 20;
        private List<Item> inventory = new List<Item>();

        private double healthModifier;
        private double attackModifier;
        private double defenseModifier;
        private double evasionModifier;

        public RaceType Race { get => race; set => race = value; }
        public int Hitpoints { get => hitpoints; set=> hitpoints = value; }
        public int AttackDamage { get => attackDamage; set => attackDamage = value; }
        public int Defense { get => defense; set => defense= value; }
        public int Evasion { get => evasion; set => evasion = value; }

        public double HealthModifier { get => healthModifier; set => healthModifier = value; }
        public double AttackModifier { get => attackModifier; set => attackModifier = value; }
        public double DefenseModifier { get => defenseModifier; set => defenseModifier = value; }
        public double EvasionModifier { get => evasionModifier; set => evasionModifier = value; }
        public List<Item> Inventory { get => inventory; set => inventory = value; }

        private Random random = new Random();

        public void Attack(Creature enemy)
        {
            int hitBox = 100;
            if (RNG(hitBox, enemy.Evasion))
            {
                RecieveDamage(enemy);
            }

        }

        public void RecieveDamage(Creature enemy)
        {
            enemy.Hitpoints -= (attackDamage * (Defense / 100));
        }

        public void Loot(Creature c)
        {
            if (c.Inventory != null)
            {
                foreach (var item in c.Inventory)
                {
                    Inventory.Add(item);
                }
            }
        }

        private bool RNG(int max, int threshold)
        {
           int diceRoll = random.Next(max + 1);

           if (diceRoll < threshold)
           {
               return false;
           }

           return true;
        }

        public override string ToString()
        {
            return $"{nameof(Hitpoints)}: {Hitpoints}, {nameof(AttackDamage)}: {AttackDamage}, {nameof(Defense)}: {Defense}, {nameof(Evasion)}: {Evasion}";
        }
    }
}

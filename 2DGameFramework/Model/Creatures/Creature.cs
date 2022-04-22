using _2DGameFramework.Factory;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures.Race;
using _2DGameFramework.Model.Items;
using _2DGameFramework.Model.World.Objects;

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
        private bool dead = false;

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
        public bool Dead { get => dead; set => dead = value; }

        private Random random = new Random();

        /// <summary>
        /// Try to attack and damage an adversary
        /// </summary>
        /// <param name="enemy">The adversary</param>
        public void Attack(Creature enemy)
        {
            int hitBox = 100;
            int diceRoll = random.Next(hitBox + 1);
            if (diceRoll < enemy.evasion)
            {
                RecieveDamage(enemy);
            }
        }

        /// <summary>
        /// Damage an adversary
        /// </summary>
        /// <param name="enemy">The adversary</param>
        public void RecieveDamage(Creature enemy)
        {
            enemy.Hitpoints -= (attackDamage * (Defense / 100));
            if (enemy.Hitpoints <= 0)
            {
                enemy.Dead = true;
            };
        }

        /// <summary>
        /// Loot all items
        /// </summary>
        /// <param name="c">The Creature to loot</param>
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

        /// <summary>
        /// Loot all items
        /// </summary>
        /// <param name="o">The WorldObject to loot</param>
        public void Loot(WorldObject o)
        {
            if (o.Lootable)
            {
                foreach (var item in o.Loot)
                {
                    Inventory.Add(item);
                }
            }
        }

        public override string ToString()
        {
            return $"{nameof(Hitpoints)}: {Hitpoints}, {nameof(AttackDamage)}: {AttackDamage}, {nameof(Defense)}: {Defense}, {nameof(Evasion)}: {Evasion}";
        }
    }
}

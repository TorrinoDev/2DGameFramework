using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.ConfigurationFile;
using _2DGameFramework.Factory;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.Model.Items.Armour;
using _2DGameFramework.Model.Items.Weapons;

namespace SmallProgram
{
    public class Game
    {
        List<Enemy> enemies = new List<Enemy>();
        public void Start()
        {
            PlayerCreation(new PlayerFactory());
            /*EnemyCreation(new EnemyFactory());
            enemies[0].Inventory.Add((new Sword()));
            enemies[0].Inventory.Add((new Shield()));
            enemies[1].Inventory.Add((new Spear()));
            enemies[1].Inventory.Add((new Helmet()));
            Configuration.CreateConfigurationFile(enemies);*/
            Configuration.ReadConfiguration();
        }

        public void PlayerCreation(IFactory factory)
        {
            var player1 = factory.GetCreature(RaceType.HUMAN);
            Console.WriteLine(player1.ToString());

        }

        public void EnemyCreation(IFactory factory)
        {
            var c1 = factory.GetCreature(RaceType.ELVEN);
            var c2 = factory.GetCreature(RaceType.ORC);
            enemies.Add((Enemy)c1);
            enemies.Add((Enemy)c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }
    }
}

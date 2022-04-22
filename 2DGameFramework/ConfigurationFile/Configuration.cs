using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using _2DGameFramework.Factory;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.Model.Items;

namespace _2DGameFramework.ConfigurationFile
{
    public class Configuration
    {

        public static List<Enemy> ReadConfiguration(TraceSource ts)
        {
            var filename = "Config.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, filename);

            List<Enemy> enemyList = new List<Enemy>();
            EnemyFactory factory = new EnemyFactory(ts);

            XDocument doc = XDocument.Load(filePath);
            IEnumerable<string> enemies = from e in doc.Descendants("Enemy") select e.Element("Race").Value;
            

            foreach (var e in enemies)
            {
                System.Enum.TryParse(e, out RaceType race);
                var temp = factory.GetCreature(race);
                Console.WriteLine(temp);
                enemyList.Add((Enemy)temp);
            }

            return enemyList;
        }


        public static void CreateConfigurationFile(List<Enemy> enemies)
        {
            XDocument configDoc = new XDocument(
                new XElement("Enemies",
                    from c in enemies
                    select new XElement("Enemy",
                        new XElement("Race", c.Race),
                        new XElement("Hitpoints", c.Hitpoints),
                        new XElement("AttackDamage", c.AttackDamage),
                        new XElement("Defense", c.Defense),
                        new XElement("Evasion", c.Evasion),
                        new XElement("Inventory",
                            from Item i in c.Inventory
                            select new XElement("Item",
                                new XElement("ItemName", i.ItemName),
                                new XElement("ItemType", i.TypeOfItem)
                                                )
                                            )
                                        )
                                    )
                                );

            configDoc.Save("Config.xml");

        }
    }
}

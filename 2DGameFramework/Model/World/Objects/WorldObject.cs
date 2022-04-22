using _2DGameFramework.Model.Items;

namespace _2DGameFramework.Model.World.Objects
{
    public class WorldObject
    {
        public bool Lootable { get; set; }
        public string ObjectName { get; set; }
        public bool Removable { get; set; }
        public List<Item> Loot { get; set; }
    }
}

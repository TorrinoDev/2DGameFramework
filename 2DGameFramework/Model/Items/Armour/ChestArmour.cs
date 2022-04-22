using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class ChestArmour : DefenceItem
    {
        /// <summary>
        /// Create a chest armour
        /// </summary>
        public ChestArmour()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.CHESTARMOUR;
        }

        /// <summary>
        /// Create a chest armour
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public ChestArmour(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.CHESTARMOUR;
        }
    }
}

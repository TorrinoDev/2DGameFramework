using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Spear : AttackItem
    {
        /// <summary>
        /// Create a spear
        /// </summary>
        public Spear()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SPEAR;
        }
        /// <summary>
        /// Create a spear
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public Spear(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SPEAR;
        }
    }
}

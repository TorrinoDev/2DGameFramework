using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Sword : AttackItem
    {
        /// <summary>
        /// Create a sword
        /// </summary>
        public Sword()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SWORD;
        }

        /// <summary>
        /// Create a sword
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public Sword(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SWORD;
        }
    }
}

using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class Shield : DefenceItem
    {
        /// <summary>
        /// Create a shield
        /// </summary>
        public Shield()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SHIELD;
        }

        /// <summary>
        /// Create a shield
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public Shield(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SHIELD;
        }
    }
}

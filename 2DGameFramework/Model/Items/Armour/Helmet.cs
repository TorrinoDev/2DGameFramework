using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class Helmet : DefenceItem
    {
        /// <summary>
        /// Create a helmet
        /// </summary>
        public Helmet()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.HELMET;
        }

        /// <summary>
        /// Create a helmet
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public Helmet(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.HELMET;
        }
    }
}

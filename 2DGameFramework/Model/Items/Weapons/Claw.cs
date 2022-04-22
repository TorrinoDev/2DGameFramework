using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Claw : AttackItem

    {
        /// <summary>
        /// Create a claw
        /// </summary>
        public Claw()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.CLAW;
        }

        /// <summary>
        /// Create a claw
        /// </summary>
        /// <param name="itemName">Set a custom name</param>
        public Claw(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.CLAW;
        }
    }
}

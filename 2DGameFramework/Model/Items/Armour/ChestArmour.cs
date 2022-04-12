using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class ChestArmour : DefenceItem
    {
        public ChestArmour()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.CHESTARMOUR;
        }
        public ChestArmour(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.CHESTARMOUR;
        }
    }
}

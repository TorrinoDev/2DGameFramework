using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Spear : AttackItem
    {
        public Spear()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SPEAR;
        }
        public Spear(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SPEAR;
        }
    }
}

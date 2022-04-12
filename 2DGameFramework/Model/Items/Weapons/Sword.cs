using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Sword : AttackItem
    {
        public Sword()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SWORD;
        }
        public Sword(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SWORD;
        }
    }
}

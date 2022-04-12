using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class Shield : DefenceItem
    {
        public Shield()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.SHIELD;
        }
        public Shield(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.SHIELD;
        }
    }
}

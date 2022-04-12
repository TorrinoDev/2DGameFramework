using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Weapons
{
    public class Claw : AttackItem

    {
        public Claw()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.CLAW;
        }
        public Claw(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.CLAW;
        }
    }
}

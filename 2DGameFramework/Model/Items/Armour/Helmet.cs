﻿using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items.Armour
{
    public class Helmet : DefenceItem
    {
        public Helmet()
        {
            string[] temp = base.ToString().Split('.');
            ItemName = temp[temp.Length - 1];
            TypeOfItem = ItemType.HELMET;
        }
        public Helmet(string itemName)
        {
            ItemName = itemName;
            TypeOfItem = ItemType.HELMET;
        }
    }
}
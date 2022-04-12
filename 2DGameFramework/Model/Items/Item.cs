using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Enum;

namespace _2DGameFramework.Model.Items
{
    public class Item
    {
        private string itemName;
        private ItemType typeOfItem;

        public string ItemName
        {
            get => itemName;
            set => itemName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public ItemType TypeOfItem
        {
            get => typeOfItem;
            set => typeOfItem = value;
        }
    }
}

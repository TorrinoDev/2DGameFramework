using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework
{
    public class AttackItem : WorldObject
    {
        public string ItemName { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
    }
}

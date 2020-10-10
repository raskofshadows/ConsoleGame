using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTillerson
{
    class Item
    {
        public string Name { get; internal set; }
        public Stats Modifier { get; internal set; }

        public static Item redbuckler = new Item() {Name = "Red Buckler", Modifier = new Stats() {healthValue = 2} };

    }


}

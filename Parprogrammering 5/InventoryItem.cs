using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_5
{
    abstract class InventoryItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public InventoryItem(string name, int amount, int price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}

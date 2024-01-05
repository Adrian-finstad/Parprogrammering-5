using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_5
{
    internal class ClothingItem : InventoryItem, Isellable
    {
        private string Size { get; set; }
        private string Color { get; set; }

        public ClothingItem(string name, int price, int amount, string color, string size):base(name, amount, price)
        {
            Size = size;
            Color = color;
            Name = name;
            Price = price;
            Amount = amount;
        }

        public double CalculatePrice() 
        {
            return Price * 1.25;
        }

        public string GetColor() {  return Color; }

        public string GetSize() {  return Size; }

    }
}

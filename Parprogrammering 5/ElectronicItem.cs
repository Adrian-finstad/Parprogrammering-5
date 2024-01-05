using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_5
{
    internal class ElectronicItem : InventoryItem, Isellable
    {
        private string Insurance { get; set; }
        private int Voltage { get; set; }

        public ElectronicItem(string name,int price,int amount, string insurance, int voltage) : base(name, amount, price)
        {
            Insurance = insurance;
            Voltage = voltage;
            Name = name;
            Amount = amount;
            Price = price;
        }

        public string GetInsurance() { return Insurance; }

        public int GetVoltage() { return Voltage; }

        public double CalculatePrice()
        {
            return Price;
        }


    }
}

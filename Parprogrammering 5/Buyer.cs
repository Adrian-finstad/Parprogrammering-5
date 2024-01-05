using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_5
{
    internal class Buyer
    {
        public ClothingItem CustomerClothes { get; set; }
        public ElectronicItem CustomerElectronics { get; set; }
        public List<ClothingItem> BoughtClothes = new List<ClothingItem>();
        
        public List<ElectronicItem> BoughtElectronics = new List<ElectronicItem>();



        public void DisplayClothesInventory()
        {
            foreach (var item in BoughtClothes)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Amount: {item.Amount}, Color: {item.GetColor()}, Size: {item.GetSize()} ");
            }
        }

        public void DisplayElectronicsInventory() 
        {
            foreach(var item in BoughtElectronics) 
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Amount: {item.Amount}, Insurance: {item.GetInsurance()}, Voltage: {item.GetVoltage()} ");
            }
        }
    }
}

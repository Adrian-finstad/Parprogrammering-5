using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_5
{
    internal class Shop
    {
        public Buyer Customer;
        public Shop(Buyer customer)
        {
            Customer = customer;
        }

        public List<ClothingItem> Clothes = new List<ClothingItem>()
        {
            new ClothingItem("Gucci jakke",20000,4,"Beige","43"),
            new ClothingItem("Skinnvest", 1200, 9, "Svart", "L"),
            new ClothingItem("Levis Jeans", 899, 25, "Blå", "M"),
            new ClothingItem("Ullvangsokker", 299, 8, "Stripete grå", "40"),
            new ClothingItem("G-streng", 199, 6, "Rød", "S"),
            new ClothingItem("T-skjorte", 149, 20, "Hvit", "XL"),
            new ClothingItem("Caps", 300, 15, "Rød", "S"),
        };

        public List<ElectronicItem> Electronics = new List<ElectronicItem>()
        {
            new ElectronicItem("Hårføner", 350, 1, "1 år", 230),
            new ElectronicItem("Womanizer",69, 1, "2 år", 24),
            new ElectronicItem("65' TV", 25000, 1, "1 år", 230),
            new ElectronicItem("Lenovo Legion Gaming PC",13000, 5, "1 år", 230),
            new ElectronicItem("Smart-Tannbørste",399, 9, "6 måneder", 24),
        };

        public void InitShop()
        {
            Console.WriteLine("Welcome to the shop!");
            Console.WriteLine("Would you like to see all available clothes, or electronic?");
            Console.WriteLine("Type 1 for clothes, or 2 for electronics.");
            Console.WriteLine("Or type 3 to show your current inventory of clothes.");
            Console.WriteLine("Or type 4 to show your current inventory of electronics.");
            var selectedInventory = Console.ReadLine();
            switch (selectedInventory)
            {
                case "1": DisplayAvailableClothes(); break;
                case "2": DisplayAvailableElectronics(); break;
                case "3": Customer.DisplayClothesInventory(); break;
                case "4": Customer.DisplayElectronicsInventory(); break;
                default: InitShop(); break;
            }
        }

        public void DisplayAvailableClothes()
        {
            for (int i = 0; i < Clothes.Count; i++)
            {
                Console.WriteLine($"{i}. Name:{Clothes[i].Name}, Price: {Clothes[i].Price}, Amount: {Clothes[i].Amount}, Color: {Clothes[i].GetColor()}, Size: {Clothes[i].GetSize()} ");
            }
            Console.WriteLine("Please type in the corresponding number of the item you wish to buy.");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);
            ChooseClothingToBuy(userInputAsNumber);
        }

        public void DisplayAvailableElectronics()
        {
            for (int i = 0; i < Electronics.Count; i++)
            {
                Console.WriteLine($"{i}. Name:{Electronics[i].Name}, Price: {Electronics[i].Price}, Amount: {Electronics[i].Amount}, Insurance: {Electronics[i].GetInsurance()}, Voltage: {Electronics[i].GetVoltage()} ");
            }
            Console.WriteLine("Please type in the corresponding number of the item you wish to buy.");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);
            ChooseElectronicToBuy(userInputAsNumber);
        }

        public void ChooseClothingToBuy(int itemToBuy)
        {
            Customer.BoughtClothes.Add(Clothes[itemToBuy]); 
            Clothes.Remove(Clothes[itemToBuy]);
        }

        public void ChooseElectronicToBuy(int itemToBuy)
        {
            Customer.BoughtElectronics.Add(Electronics[itemToBuy]);
            Electronics.Remove(Electronics[itemToBuy]);
        }
    }
}

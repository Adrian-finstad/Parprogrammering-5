//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.
//Lag to klasser til, ClothingItem og ElectronicItem.
//Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske.
//La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.
//Lag et interface ISellable som har en funksjon som kalkulerer pris.
//Implementer dette interfacet i ClothingItem og ElectronicItem
//Lag noen forskjellige items for å sjekke at det fungerer som tenkt.


//ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
//var salePrice = shirt.CalculateSalePrice();
//Console.WriteLine($"The sale price of the shirt is: {salePrice}");
//ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3400, "1 year");
//salePrice = phone.CalculateSalePrice();
//Console.WriteLine($"The sale price of the phone is: {salePrice}");


using Parprogrammering_5;
var customer = new Buyer();
var netShop = new Shop(customer);
while (true)
{
    netShop.InitShop();
}
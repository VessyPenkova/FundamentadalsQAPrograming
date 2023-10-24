using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;

namespace _07012_Coffee_Shop_with_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceCoffee = 1.00;
            double priceTea = 0.60;
            double priceSugar = 0.40;
            double finalprice = 0;

            string drinkType = Console.ReadLine();

            string additionToDrink = Console.ReadLine();

            if (drinkType == "tea")
            {
                priceTea = 0.60;
                if (additionToDrink == "no")
                {
                    priceSugar = 0;
                    finalprice = priceTea + priceSugar;
                }
                else if (additionToDrink == "sugar")
                {
                    priceSugar = 0.40;
                    finalprice = priceTea + priceSugar;
                }
                else
                {
                    Console.WriteLine("Unknown extra");

                }
            }
            else if (drinkType == "coffee")
            {
                priceCoffee = 1.00;
                if (additionToDrink == "no")
                {
                    priceSugar = 0;
                    finalprice = priceCoffee + priceSugar;
                }
                else if (additionToDrink == "sugar")
                {
                    priceSugar = 0.40;
                    finalprice = priceCoffee + priceSugar;
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }
            }
            else if(drinkType != "tea" && drinkType != "coffee")
            {
                Console.WriteLine("Unknown drink");
            }
            Console.WriteLine($"Final price: ${finalprice:f2}");
        }
    }
}

//Write a program to calculate the price for a drink, which:
//Reads a drink name: either "coffee" or "tea"
//Prints "Unknown drink" if the drink name is invalid and stops
//Reads an extra: either "sugar" or "no"
//Prints "Unknown extra" if the extra is invalid and stops
//Calculate and prints the price in format "Final price: ${price}"

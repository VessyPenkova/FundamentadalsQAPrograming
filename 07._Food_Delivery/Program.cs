using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umberOfChickenMenus = int.Parse(Console.ReadLine());
            int menuWithFish = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double priceChickenMenu = 10.35;
            double ricefishMenu = 12.40;
            double pricevegeterianMenu = 8.15;
            double deliveryPrice = 2.50;

            double chickensAmonunt = umberOfChickenMenus * priceChickenMenu;
            double fishAmount = menuWithFish * ricefishMenu;
            double vegeterianAmount = vegetarianMenu * pricevegeterianMenu;
   
            double netAmount = chickensAmonunt + fishAmount + vegeterianAmount;
            double desertAmount = netAmount /5 ;

            double finalAmount = netAmount + desertAmount + deliveryPrice;

            Console.WriteLine(finalAmount);
        }
    }
}
//7.Food Delivery
//The restaurant opens its doors and offers several menus at preferential prices: 
//  V •	Chicken menu – 10.35 lv. 
//  V •	Menu with fish – 12.40 lv. 
//  V •	Vegetarian menu – 8.15 lv. 
//Write a program that calculates how much it will cost a group of people to order takeaways.

//The group will also order a dessert, the price of which is equal to 20% of the total bill
//(excluding delivery). 

//The delivery price is 2.50 BGN and is finally charged.  
//Input
//From the console read 3 lines:

//  V •	Number of chicken menus – integer in the range [0 ... 99]
//  V •	Number of menus with fish – integer in the range [0 ... 99]
//  V •	Number of vegetarian menus – an integer in the range [0 ... 99]

//Output
//Print out only one line on the console: "{order price}"

namespace _07011_Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prices:

            double priceCoffee = 1.00;
            double priceTea = 0.6;
            double priceSugar = 0.40;
            double finalprice = 0;

            string drinkType = Console.ReadLine();
            string additionToDrink = Console.ReadLine();
            if (additionToDrink =="no")
            {
                priceSugar = 0;
            }
            if (drinkType == "coffee")
            {
                finalprice = priceCoffee+ priceSugar;
            }
            else if (drinkType == "tea")
            {
                finalprice = priceTea + priceSugar;
            }
         
            Console.WriteLine($"Final price: ${finalprice:f2}");  
        }
    }
}

//Write a program to calculate the price for a drink, which:
//Reads a drink name: either "coffee" or "tea"
//Reads an extra: either "sugar" or "no"
//Prints the price in format "Final price: ${price}"

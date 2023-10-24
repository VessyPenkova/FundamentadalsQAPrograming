using System.ComponentModel;

namespace _08001_Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;
            if (product == "Banana")
            {
                if (dayOfTheWeek == "Weekday")
                {
                    price = 2.50;
                }
                else if (dayOfTheWeek == "Weekend")
                {
                    price = 2.70;
                }
            }
            else if (product == "Apple")
            {
                if (dayOfTheWeek == "Weekday")
                {
                    price = 1.30;
                }
                else if (dayOfTheWeek == "Weekend")
                {
                    price = 1.60;
                }
            }
            else if (product == "Kiwi")
            {
                if (dayOfTheWeek == "Weekday")
                {
                    price = 2.20;
                }
                else if (dayOfTheWeek == "Weekend")
                {
                    price = 3.00;
                }
            }
             
            Console.WriteLine($"{price:f2}");
        }
    }
}

//Write a program that:
//•	Reads two strings from the console: product(string) and day(string).
//•	Print the price, formatted to the second digit, based on the price table:
//||================================================
//||   Product     ||   Weekday    ||   Weekend   ||
//==================================================
//||  Banana       ||     2.50     ||      2.70   ||
//||================================================
//||  Apple        ||     1.30     ||      1.60   ||
//||================================================
//||  Kiwi         ||     2.20     ||      3.00   ||
//||================================================

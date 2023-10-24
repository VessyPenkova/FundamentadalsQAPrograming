using System.Buffers.Text;
using System.ComponentModel;

namespace _08004_Food_or_Drink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            if (product == "curry" || product == "noodles" || product == "sushi"
                || product == "spaghetti" || product == "bread")
            {
                Console.WriteLine("food");
            }
            else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
            {
                Console.WriteLine("drink");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
//Write a program that:
//•	Reads a product (string) from the console
//•	Based on type of the given product, print:
// -    If product is one of following v"curry", v"noodles", v"sushi", v"spaghetti" or v"bread" you have to print v"food"
// - 	If product is one of following v"tea", "water", v"coffee" or "juice" you have to print "drink"
// - 	If the product is different from listed products above, print "unknown"

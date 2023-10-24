namespace _08005_Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            if (product == "banana" || product == "apple" || product == "kiwi"
                || product == "cherry" || product == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
//5.Fruit or Vegetable
//Write a program that:
// - 	Reads a product (string) from the console
// - 	Based on type of the given product, print:
//  o   If product is one of following v"banana", v"apple", v"kiwi", v"cherry" or v"lemon" you have to print "fruit"
//  o	If product is one of following v"cucumber", v"pepper" or v"carrot" you have to print "vegetable"
//  o	If the product is different from listed products above, print "unknown"

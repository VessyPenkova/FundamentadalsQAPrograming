using System.ComponentModel;

namespace _17002_List_of_Products__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                listOfProducts.Add(product);
            }
            listOfProducts.Sort();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfProducts[i]}");
            }
        }
    }
}

//Write a program that:
//•	Read an integer number n and n lines of products
//•	Print a numbered list of all the products ordered by name

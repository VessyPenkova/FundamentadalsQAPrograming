using System.ComponentModel;

namespace _13003_Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfLoop = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= endOfLoop; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

//Write a program to print a triangle of stars like shown in the examples:
//•	Read the size (integer number) of a triangle from the console
//•	Print a triangle of stars

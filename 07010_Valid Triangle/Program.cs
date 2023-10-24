using System.ComponentModel;

namespace _07010_Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidTriangle = true;

            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            if (sideA + sideB <= sideC)
            {
                isValidTriangle = false;
            }
            else if (sideA + sideC <= sideB)
            {
                isValidTriangle = false;
            }
            else if (sideB + sideC <= sideA)
            {
                isValidTriangle = false;
            }
            if (isValidTriangle == true)
            {
                Console.WriteLine("Valid Triangle");
            }
            else if (isValidTriangle == false)
            {
                Console.WriteLine("Invalid Triangle");
            }

        }
    }
}
//Write a program to check whether a triangle is valid, which:
//Reads 3 integers: the sides of a triangle
//Checks if each side is shorter than the sum of the other two
//Prints "Valid Triangle" if the above condition is met
//Prints "Invalid Triangle" otherwise 


using System.ComponentModel;

namespace _07002_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            if (numberToCheck % 2 ==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}

//Write a program to check for odd / even number, which: 
//Reads an integer
//If it's even, prints "even"
//If it's odd, prints "odd"

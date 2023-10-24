using System.ComponentModel;

namespace _09003_Biggest_of_Five_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = int.MinValue;

            for (int i = 0; i <= 4; i++)
            {
                int firstNo = int.Parse(Console.ReadLine());
                //int secondNo = int.Parse(Console.ReadLine());
                //int tirthNo = int.Parse(Console.ReadLine());
                if (firstNo > largestNumber)
                {
                    largestNumber = firstNo;
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}

//Write a program to find the biggest among 5 numbers:
//•	Reads 5 integer numbers from the console
//•	Print the biggest number from the given five
//Note: There will not be equal numbers given.

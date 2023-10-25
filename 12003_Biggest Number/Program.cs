using System.ComponentModel;

namespace _12003_Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = int.MinValue;
            int endOfTheLoop = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endOfTheLoop; i++)
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

//Write a program to find the biggest among given n numbers:
//•	Read an integer number n (the amount of input numbers) and n integer numbers from the console
//•	Find and print the biggest number

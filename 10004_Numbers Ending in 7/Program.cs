using System.ComponentModel;

namespace _10004_Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            for (int i = 0; i <= n; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

//Write a program that prints numbers ending in 7 in given range: 
//•	Reads an integer number n – end of the range
//•	Prints all numbers from 7 to n, ending in 7

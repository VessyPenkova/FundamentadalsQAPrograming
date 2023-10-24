using System.ComponentModel;

namespace _11003_Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int printNumber = 0;
            int firstNumber = 1;

            while (printNumber <= n)
            {
                printNumber = ((printNumber * 2) + 1);

                if (printNumber > n)
                {
                    break;
                }
                Console.WriteLine(printNumber);
                firstNumber++;
            }

            //for (int i = 0; i <= n; i++)
            //{
            //    printNumber = ((printNumber * 2) + 1);

            //    if (printNumber > n)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(printNumber);
            //}
        }
    }
}

//Write a program to print a sequence of numbers:
//•	The first number is 1
//•	Each next number is 2 times the previous number + 1
//•	Read an integer number n from the console – the max number
//•	Print the elements of the sequence (starting with 1), which are ≤ n

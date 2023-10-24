using System.ComponentModel;

namespace _10003_Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum+= number;
            }
            Console.WriteLine(sum);
        }
    }
}

//Write a program to sum given N numbers:
//•	Read integer number n – the count of numbers to sum
//•	Read n floating-point numbers and print their sum

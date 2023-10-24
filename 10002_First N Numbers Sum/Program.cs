using System.ComponentModel;
using System.Text;

namespace _10002_First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    sb.Append($"{i}=");
                }
                else
                {
                  sb.Append($"{i}+");
                } 
                sum += i;
            }
            sb.Append(sum);
            Console.WriteLine(sb.ToString());
        }
    }
}

//Write a program, which sums the numbers 1…n:
//•	Reads an integer number n from the console
//•	Sums all numbers from 1 to n
//•	Prints the numbers and the sum on the console as shown below

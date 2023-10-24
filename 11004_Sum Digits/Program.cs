using System.Security.Cryptography;

namespace _11004_Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int RealNumber = Convert.ToInt32(sequence[i]) - '0';
                sum += RealNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

//Write a program to sum the digits of given number:
//•	Read an integer positive number from the console
//•	Sum its digits and print the sum


// - String input = "123678";
// - int indexOfSeven = 4;
// - int x = Convert.ToInt32(input[indexOfSeven]);             // Returns 55
// - int x = Convert.ToInt32(input[indexOfSeven].toString());  // Returns 7

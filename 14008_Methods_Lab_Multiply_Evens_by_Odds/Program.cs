using System.ComponentModel;
using System.Data.SqlTypes;

namespace _14008_Methods_Lab_Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
           number = Math.Abs(number);
           Console.WriteLine(GetMultipleOfEvenAndOdds(number));          
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return  evenSum * oddSum;
        }
        private static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;                   
                }
            }
            return oddSum;
        }
        private static int GetSumOfEvenDigits(int number)
        {
            int evenSum =0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;              
                }               
            }
            return evenSum;
        }
    }
}


//Write a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
//•	Read an integer number from the console
//•	Create a method     GetMultipleOfEvenAndOdds()
//•	Create a method     GetSumOfEvenDigits()
//•	Create              GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers
